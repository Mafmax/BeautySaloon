using Saloon;
using System;
using System.Windows.Forms;

namespace SaloonClient
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Work[] massageWorks = new Work[10];
          //  massageWorks[0]=new Work("") 
          
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainPageForm());

        }
    }
}
