using Saloon.Masters;
using System;
using System.Windows.Forms;

namespace SaloonClient
{
    //Класс главной формы
    public partial class MainPageForm : Form
    {
        public MainPageForm()
        {
            InitializeComponent();
        }
        //Обработчик события нажатия на кнопку "массажист"
        private void massageButton_Click(object sender, EventArgs e)
        {


            OpenMasterForm(new Masseur());

        }
        //Открытие формы выбора мастера
        private void OpenMasterForm(MasterBase master)
        {
            //Создание формы
            var form = new ChooseMasterForm();
            //Подпись на событие закрытия формы
            form.FormClosed += OnClosedMasterForm;
            //Активация формы выбора мастера
            form.Activate(master);
            //Перевод текущей формы в невидимое состояние
            this.Visible = false;
        }
        //Метод обработчик события закрытия формы выбора мастера
        private void OnClosedMasterForm(object sender, FormClosedEventArgs e)
        {
            //Перевод текущей формы в видимое состояние
            this.Visible = true;
        }
        //Обработчик события нажатия на кнопку "парикмахер"
        private void hairdresserButton_Click(object sender, EventArgs e)
        {
            OpenMasterForm(new Hairdresser());

        }
        //Обработчик события нажатия на кнопку "визажист"
        private void visagistButton_Click(object sender, EventArgs e)
        {
            OpenMasterForm(new Visagiste());

        }
        //Обработчик события нажатия на кнопку "мастер маникюра"
        private void manicureButton_Click(object sender, EventArgs e)
        {
            OpenMasterForm(new ManicureMaster());


        }
    }
}
