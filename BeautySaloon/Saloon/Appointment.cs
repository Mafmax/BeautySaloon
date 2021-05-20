using Saloon.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saloon
{
    //Класс, олицетворяющий заказ
    public class Appointment
    {
        public int Id { get; set; }
        //Работы, выполняемые в рамках заказа
        public List<Work> Works { get; set; } = new List<Work>();
        //Метод установки работ из строки формата id1-id2-...-idn
        public void SetWorks(string Ids, List<Work> allWorks)
        {
            Works.Clear();
            string[] splitIds = Ids.Split('-');
            for (int i = 0; i < splitIds.Length; i++)
            {
                try
                {

                    Works.Add(allWorks.Where(x => x.Id == Int32.Parse(splitIds[i])).FirstOrDefault());
                }
                catch
                {

                }
            }

        }
        //Метод установки работ в строку в формате id1-id2-...-idn
        public string GetWorksString()
        {
            StringBuilder str = new StringBuilder();
            foreach (var work in Works)
            {
                str.Append($"{work.Id}-");
            }
            str.Remove(str.Length - 1, 1);
            return str.ToString();
        }
        //Метод, рассчитывающий стоимость заявки
        public int GetAllCost()
        {
            int sum = 0;
            foreach (var work in Works)
            {
                sum += work.Cost;
            }
            return sum;
        }
        //Заказчик услуг
        public Customer Customer { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
    }
}
