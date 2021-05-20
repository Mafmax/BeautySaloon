using Saloon;
using Saloon.Employees;
using Saloon.Masters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace SaloonClient
{
    //Класс формы выбора мастера
    public partial class ChooseMasterForm : Form
    {
        public ChooseMasterForm()
        {
            InitializeComponent();


        }

        private MasterBase master;
        private Server dataServer;
        private List<Work> works = new List<Work>();
        private List<Employee> masters = new List<Employee>();
        private InsertCustomerData customerForm;
        private Dictionary<string, RadioButton> times = new Dictionary<string, RadioButton>();
     //Метод, открывающий форму и устанавливающий начальные значения
        public void Activate(MasterBase masterBase)
        {
            master = masterBase;
            //Создание экземпляр типа Server для общения с сервером
            dataServer = new Server("localhost", 8081);
            //Получение с сервера информации о работах с типом, соответствующим специализации мастера
            works = dataServer.GetWorks(master.GetSpecialization());
            //Получение с сервера информации о мастерах со...
            //..специализацией, соответствующией специализации выбранного мастера
            masters = dataServer.GetMasters(master.GetSpecialization());
            //Помещение в словарь элементов формы типа RadioButton, позволяющих...
            //...выбрать время услуги для удобства использования
            times.Add("7:00", time7);
            times.Add("8:00", time8);
            times.Add("9:00", time9);
            times.Add("10:00", time10);
            times.Add("11:00", time11);
            times.Add("13:00", time13);
            times.Add("14:00", time14);
            times.Add("15:00", time15);
            times.Add("16:00", time16);
            times.Add("17:00", time17);
            //Добавление в элемент listBox1 полученных с сервера мастеров
            if (masters != null && masters.Count() > 0)
            {
                foreach (var person in masters)
                {
                    listBox1.Items.Add(person);
                }
                listBox1.SelectedIndex = 0;
                UpdateTimes();
            }
            //Добавление в элемент checkedListBox1 полученных с серврера работ
            if (works == null)
            {
                int index = checkedListBox1.Items.Add("Нет работ");
                checkedListBox1.Size = new Size(1, 1);
            }
            else
            {

                checkedListBox1.Items.AddRange(works.ToArray());
            }
            //Активация формы и перевод ее в видимое состояние
            this.Activate();
            this.Visible = true;
        }


        //Метод обработчик события изменения выбранного индекса элемента управления checkedListBox1
        private void checkedListBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            //Вывод описания работы в элемент управления workDescription типа Label
            workDescription.Text = ((Work)checkedListBox1.SelectedItem).Description;

        }





        //Метод обработчик события клика на элемент управления "Расчет"
        private void button1_Click(object sender, System.EventArgs e)
        {
            //Расчет суммы стоимостей выделенных работ
            int sum = 0;

            foreach (var checkedItem in checkedListBox1.CheckedItems)
            {
                sum += (checkedItem as Work).Cost;
            }
            Sum.Text = $"Сумма: {sum} р.";
        }
        //Метод обновляющий состояние элементов управления RadioButton, отвечающих...
        //...за выбор времени услуги
        private void UpdateTimes()
        {
            //Получение даты с элемента управления monthCalendar1 типа MonthCalendar
            string date = monthCalendar1.SelectionRange.Start.ToString().Split(' ')[0];
            //Получение выделенного мастера на элементе управления типа ListBox
            var selectedMaster = listBox1.SelectedItem as Employee;
            //Проверка для каждой пары ключ-значение словаря times корректности времени
            foreach (var time in times.Keys)
            {
                //Если дата выбрана не корректно, то все элементы RadioButon переходят в...
                //...состояние .Enabled=false
                if (monthCalendar1.SelectionRange.Start < DateTime.Now)
                {
                    times[time].Enabled = false;
                    errorLabel.Text = "Запись возможна как минимум за день";
                }
                else
                {
                    //Иначе состояние элемента RadioButton противоположно наличию у мастера записи на это время
                    //(Если время занято, то .Enabled=false)
                    times[time].Enabled = !selectedMaster.Appointments.Where(x => x.Time == time && x.Date == date).Any();
                    errorLabel.Text = "";
                }
                times[time].ForeColor = Color.Green;
                if (times[time].Enabled)
                {
                    times[time].Checked = true;
                }
            }

        }


        //Метод обработчик события изменения индекса выбранного элемента на listBox1
        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            UpdateTimes();
        }
        //Метод обработчик изменения выбранной даты
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            UpdateTimes();


        }
        //Метод обработчик клика на кнопку "Записаться"
        private void button2_Click(object sender, System.EventArgs e)
        {
            //Если работы не выбраны, то вывод ошибки и возврат из метода
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                errorLabel.Text = "Необходимо выбрать работу";
                return;
            }
            //Если время не выбрано, то вывод ошибки и возврат из метода
            if (!times.Where(x => x.Value.Checked).Any())
            {
                errorLabel.Text = "Необходимо выбрать время";
                return;
            }
            //Формирование заявки
            var appointment = new Appointment();
            appointment.Time = times.Where(x => x.Value.Checked).FirstOrDefault().Key;
            appointment.Date = monthCalendar1.SelectionRange.Start.ToString().Split(' ')[0];
            var checkedWorks = checkedListBox1.CheckedItems;
            for (int i = 0; i < checkedWorks.Count; i++)
            {
                appointment.Works.Add((Work)checkedWorks[i]);

            }
            var selectedMaster = new Employee();
            selectedMaster = (Employee)listBox1.SelectedItem;
            //Создание формы заполнения данных клиента
            customerForm = new InsertCustomerData();
            //Подписка на событие закрытия формы заполнения данных клиента
            customerForm.FormClosed += OnCustomerFormClosed;
            //Вызов метода активации на экземпляре класса формы заполнения данных клиента
            customerForm.Activate(appointment, selectedMaster, OnAppointSuccess);
            //Перевод текущей формы в невидимое состояни
            this.Visible = false;
        }

        //Обработчик события закрытия формы заполнения данных клиента
        private void OnCustomerFormClosed(object sender, FormClosedEventArgs e)
        {
            //Перевод текущей формы в видимое состояние
            this.Visible = true;
        }

        //Метод обратного вызова. Вызывается при успешном заполнении данных пользователя
        private void OnAppointSuccess()
        {
            //Отписка от события закрытия формы заполнения данных пользователя
            customerForm.FormClosed -= OnCustomerFormClosed;
            //Закрытие текущей формы
            Close();
        }
    }
}
