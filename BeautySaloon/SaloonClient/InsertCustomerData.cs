using Saloon;
using Saloon.Employees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaloonClient
{
    //Класс формы заполнения данных пользователя
    public partial class InsertCustomerData : Form
    {
        public InsertCustomerData()
        {
            InitializeComponent();
        }
        private Action OnConfirmCallback;
        private Appointment appointment;
        private Employee master;
        //Метод активации формы
        public void Activate(Appointment appointment, Employee master, Action onConfirmCallback)
        {
            //Присваивание значений, принимаемых методом, полям класса
            OnConfirmCallback = onConfirmCallback;
            this.appointment = appointment;
            this.master = master;
            //Сбор информации о заказе и вывод ее на форму
            StringBuilder str = new StringBuilder();
            str.Append($"Мастер: {master.Name}. Телефон: {master.Phone}\n");
            str.Append($"Дата: {appointment.Date}. Время: {appointment.Time}");
            str.Append("\nСписок работ:");
            foreach (var work in appointment.Works)
            {

                str.Append($"\n---{work}");
            }
            str.Append($"\nИтого: {appointment.GetAllCost()}");
            description.Text = str.ToString();
            //Активация и перевод формы в видимое состояние
            Activate();
            Visible = true;
        }
        //Метод обработчик события нажатия на кнопку "Подтвердить"
        private void button1_Click(object sender, EventArgs e)
        {
            //Проверка полей на наличие текста. В противном случае вывод ошибки и возврат из метода
            if (name.Text == "")
            {
                errorLabel.Text = "Введите имя!";
                return;
            }
            if (lastName.Text == "")
            {
                errorLabel.Text = "Введите фамилию!";
                return;
            }
            if (phone.Text == "")
            {
                errorLabel.Text = "Введите телефон!";
                return;
            }
            //Создание экземпляра класса Customer на основе введенных данных
            var customer = new Customer();
            customer.Name = name.Text;
            customer.Lastname = lastName.Text;
            customer.Phone = phone.Text;

            appointment.Customer = customer;
            //Создание экземпляра класса Server и отправка заявки на сервер
            var server = new Server("localhost", 8081);

            server.AddAppointment(appointment, master);
            //Активация метода обратного вызова
            OnConfirmCallback.Invoke();
            //Закрытие формы
            Close();

        }
    }


}
