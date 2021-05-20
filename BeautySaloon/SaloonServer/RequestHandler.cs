using Newtonsoft.Json;
using Saloon;
using Saloon.Employees;
using Saloon.Masters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaloonServer
{
    //Класс, представляющий собой обработчик строки запроса
    public static class RequestHandler
    {
        //Строка подключения к базе данных
        public static string DbConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;";
        //Метод, принимающий запрос и отдающий ответ
        public static string GetResponse(string request)
        {
            ClientServerMessage requestMessage = new ClientServerMessage(request);

            ClientServerMessage response = new ClientServerMessage(new Dictionary<string, string>() { { "result", "failed" } });
            //Обработка запроса в зависимости от команды, прижедшей с клиента
            switch (requestMessage.Arguments["cmd"].ToUpper())
            {

                case "GET_MASTER_WORKS": response = GetMasterWorks(requestMessage); break;
                case "GET_MASTERS": response = GetMasters(requestMessage); break;
                case "ADD_APPOINTMENT": response = AddAppointment(requestMessage); break;
            }

            return response.Message;


        }
        //Метод, добавляющий поступивший заказ в базу данных
        private static ClientServerMessage AddAppointment(ClientServerMessage request)
        {
            var appointment = JsonConvert.DeserializeObject<Appointment>(request.Arguments["appointment"]);
            var master = JsonConvert.DeserializeObject<Employee>(request.Arguments["master"]);

            using (DbContext context = new DbContext(DbConnectionString))
            {

               int id = context.UploadAppointment(appointment);
                appointment.Id = id;
                master.Appointments.Add(appointment);
                context.UpdateMasterAppointments(master);
            }

            return new ClientServerMessage("success;true");
        }
        //Метод, вытягивающий информацию о мастерах из базы данных
        private static ClientServerMessage GetMasters(ClientServerMessage request)
        {
            var masterType = (WorkType)Int32.Parse(request.Arguments["master"]);
            var args = new Dictionary<string, string>();
            args.Add("result", "success");
            ClientServerMessage response;
            List<Employee> mastersToSend = new List<Employee>();
            using (DbContext context = new DbContext(DbConnectionString))
            {
                var masters = context.Masters;
                if (masters != null)
                {

                    mastersToSend = masters.Where(x => x.Specialization == masterType).ToList();
                }
                if (mastersToSend == null)
                {
                    args["result"] = "failed";
                }
                else
                {

                    args.Add("masters", JsonConvert.SerializeObject(mastersToSend));
                }


            }
            response = new ClientServerMessage(args);

            return response;
        }
        //Метод, вытягивающий информацию о работах, соответствующих данному типу мастера
        private static ClientServerMessage GetMasterWorks(ClientServerMessage request)
        {
            var masterType = (WorkType)Int32.Parse(request.Arguments["master"]);
            var args = new Dictionary<string, string>();
            args.Add("result", "success");
            ClientServerMessage response;
            using (DbContext context = new DbContext(DbConnectionString))
            {

                List<Work> works = context.Works.Where(x => x.Type == masterType).ToList();
                if (works == null)
                {
                    args["result"] = "failed";
                }
                else
                {

                    args.Add("works", JsonConvert.SerializeObject(works));
                }


            }
            response = new ClientServerMessage(args);

            return response;
        }
    }
}
