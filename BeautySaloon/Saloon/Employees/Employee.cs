using Saloon.Masters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Saloon.Employees
{
    //Класс, отвечающий за конкретного работника салона
    public class Employee
    {
        public WorkType Specialization { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Id { get; set; }
        //Заказы, приуроченные к конкретному мастеру
        public List<Appointment> Appointments { get; set; } = new List<Appointment>();
       //Метод, позволяющий установить заказы мастеру на основе строки в формате id1-id2-...-idn
        public void SetAppointments(string Ids, List<Appointment> allAppointments)
        {
            Appointments.Clear();
            var splitIds = Ids.Split('-');
            for (int i = 0; i < splitIds.Length; i++)
            {
                try
                {

                    Appointments.Add(allAppointments.Where(x => x.Id == Int32.Parse(splitIds[i])).FirstOrDefault());
                }
                catch
                {

                }
            }
        }
        //Метод, который собирает идентификаторы заявок в формат id1-id2-...-idn
        public string GetAppointmentsString()
        {
            StringBuilder str = new StringBuilder();
            foreach (var app in Appointments)
            {
                str.Append($"{app.Id}-");
            }
            str.Remove(str.Length - 1, 1);
            return str.ToString();
        }
        public override string ToString()
        {
            return $"(#{Id}) {Name}";
        }

    }
}
