using Saloon;
using Saloon.Employees;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaloonServer
{
    //Класс, отвечающий за работу с базой данных
    internal class DbContext : IDisposable
    {
        //Свойство, содержащее подключение к базе данных
        private OleDbConnection Db { get; set; }
        //Конструктор класса, получает в качестве параметра строку подключения к...
        //...базе данных, создает и открывает подключение 
        public DbContext(string connectionString)
        {
            Db = new OleDbConnection(connectionString);
            Db.Open();
        }
        //Метод, реализующий интерфейс IDisposable. Позволяет удобно пользоваться...
        //...конструкцией using и не думать о завершении подключения
        public void Dispose()
        {
            Db.Close();
        }
        //Свойство, подгружающее все работы, хранящиеся в базе данных после обращения к нему
        public List<Work> Works => DownLoadWorks();
        //Свойство, подгружающее всех мастеров, хранящихся в базе данных после обращения к нему
        public List<Employee> Masters => DownLoadMasters();
        //Свойство, подгружающее все записи(заказы), хранящиеся в базе данных после обращения к нему
        public List<Appointment> Appointments => DownLoadAppoinments();
        //Метод добавления заявки в базу данных. Возвращает идентификатор добавленной записи
        public int UploadAppointment(Appointment appointment)
        {
            //SQL запрос на вставку данных
            string addQuery = $"INSERT INTO Appointments " +
                $"(ClientName," +
                $"ClientLastname," +
                $"ClientPhone," +
                $"Works," +
                $"Dtm) " +
                $"VALUES" +
                $"('{appointment.Customer.Name}', " +
                $"'{appointment.Customer.Lastname}', " +
                $"'{appointment.Customer.Phone}', " +
                $"'{appointment.GetWorksString()}'," +
                $"'{appointment.Date + " " + appointment.Time}');";



            OleDbCommand command = new OleDbCommand(addQuery, Db);
            command.ExecuteNonQuery();

            //Запрос на получения идентификатора последнего вставленного элемента
            command.CommandText = $"SELECT @@IDENTITY;";
            Int32.TryParse(command.ExecuteScalar().ToString(), out int id);

            return id;
        }
        //Метод обновления заявок, присущих конкретному мастеру
        public void UpdateMasterAppointments(Employee master)
        {
            //Запрос на обновление данных и установку заявок 
            string query = $"UPDATE Masters " +
                $"Set [Appointments] = '{master.GetAppointmentsString()}' " +
                $"WHERE Id = {master.Id}";
            OleDbCommand command = new OleDbCommand(query, Db);
            command.ExecuteScalar();
        }
        //Метод загрузки заявок из базы
        public List<Appointment> DownLoadAppoinments()
        {
            List<Appointment> appointments = new List<Appointment>();
            //Запрос на вывод данных
            string getAppointmentsQuery = "SELECT Id,ClientName,ClientLastname,ClientPhone,Works,Dtm FROM Appointments";
            OleDbCommand command = new OleDbCommand(getAppointmentsQuery, Db);
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                //Создание заявки в соответствии с подгруженными данными
                var appointment = new Appointment();
                appointment.Id = Int32.Parse(reader[0].ToString());

                var customer = new Customer();
                customer.Name = reader[1].ToString();
                customer.Lastname = reader[2].ToString();
                customer.Phone = reader[3].ToString();
                appointment.Customer = customer;
                appointment.SetWorks(reader[4].ToString(), Works);
                appointment.Date = reader[5].ToString().Split(' ')[0];
                if (reader[5].ToString().Split(' ').Length > 1)
                {

                    appointment.Time = reader[5].ToString().Split(' ')[1];
                }
                appointments.Add(appointment);

            }
            return appointments;

        }
        //Метод загрузки мастеров из базы данных
        private List<Employee> DownLoadMasters()
        {
            List<Employee> downloadedEmployees = new List<Employee>();
            string getMastersQuery = "SELECT Id, MasterName, Type, Phone, Appointments FROM Masters";
            OleDbCommand command = new OleDbCommand(getMastersQuery, Db);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                //Создание класса работника на основе подгруженных данных
                var master = new Employee();
                master.Id = Int32.Parse(reader[0].ToString());
                master.Name = reader[1].ToString();
                string getTypeQuery = $"SELECT Type FROM WorkTypes WHERE Id = {(int)reader[2]}";
                command = new OleDbCommand(getTypeQuery, Db);
                string typeName = command.ExecuteScalar().ToString();
                var workType = (WorkType)Enum.Parse(typeof(WorkType), typeName);
                master.Specialization = workType;
                master.Phone = reader[3].ToString();
                var appointments = Appointments;
                master.SetAppointments(reader[4].ToString(), appointments);
                downloadedEmployees.Add(master);
            }


            return downloadedEmployees;
        }
        //Метод загрузки работ из базы данных
        private List<Work> DownLoadWorks()
        {
            List<Work> downloadedWorks = new List<Work>();
            string getWorksQuery = "SELECT WorkName, Description, Type, Cost,Id FROM Works ";

            OleDbCommand command = new OleDbCommand(getWorksQuery, Db);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                //Создание экземпляра типа Work на основании загруженных данных
                string getTypeQuery = $"SELECT Type FROM WorkTypes WHERE Id = {(int)reader[2]}";
                command = new OleDbCommand(getTypeQuery, Db);
                string typeName = command.ExecuteScalar().ToString();
                var workType = (WorkType)Enum.Parse(typeof(WorkType), typeName);
                var work = new Work(reader[0].ToString(), reader[1].ToString(), workType, Int32.Parse(reader[3].ToString()));
                work.Id = Int32.Parse(reader[4].ToString());
                downloadedWorks.Add(work);

            }
            return downloadedWorks;
        }

   
    }
}
