using Newtonsoft.Json;
using Saloon;
using Saloon.Employees;
using Saloon.Masters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SaloonClient
{
    //Класс, реализующий общение клиентской части с сервеной 
    public class Server
    {

        public string URL { get; }
        public int Port { get; }
        //Конструктор класса
        public Server(string url, int port)
        {
            URL = url;
            Port = port;
        }
        //Метод отправки сообщения на сервер и ожидания ответа
        private ClientServerMessage SendMessage(ClientServerMessage message)
        {
            byte[] bytes = new byte[4096];
            //Конфигурируем точку, к которой будем обращаться
            IPHostEntry ipHost = Dns.GetHostEntry(URL);
            IPAddress iPAddress = ipHost.AddressList[0];
            IPEndPoint iPEndPoint = new IPEndPoint(iPAddress, Port);
            //Открываем сокет в конечной точке и соединяемся с ним
            var sender = new Socket(iPAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            sender.Connect(iPEndPoint);
            //Отправляем сообщение на сервер
            byte[] msg = Encoding.UTF8.GetBytes(message.Message);
            sender.Send(msg);
            //Принимаем сообщение с сервера
            int bytesReceived = sender.Receive(bytes);
            ClientServerMessage receivedMessage = new ClientServerMessage(Encoding.UTF8.GetString(bytes, 0, bytesReceived));
            //Закрываем соединение
            sender.Shutdown(SocketShutdown.Both);
            sender.Close();
            //Возвращаем сообщение, полученное с сервера
            return receivedMessage;
        }
        //Проверка сообщения на присутствие аргумента result в значении success
        private bool CheckReceivedMessage(ClientServerMessage message)
        {
            return message.Arguments.ContainsKey("result") && message.Arguments["result"] == "success";
        }
        //Метод получения информации о сотрудниках определенного типа с сервера
        public List<Employee> GetMasters(WorkType masterType)
        {
            string masterJson = ((int)masterType).ToString();
            string command = "GET_MASTERS";
            Dictionary<string, string> args = new Dictionary<string, string>();
            args.Add("cmd", command);
            args.Add("master", masterJson);

            ClientServerMessage receivedMessage = SendMessage(new ClientServerMessage(args));

            if (CheckReceivedMessage(receivedMessage) && receivedMessage.Arguments.ContainsKey("masters"))
            {

                return JsonConvert.DeserializeObject<List<Employee>>(receivedMessage.Arguments["masters"]);
            }
            else
            {
                return null;
            }
        }

        //Метод получения работ определенного типа с сервера
        public List<Work> GetWorks(WorkType masterType)
        {
            string masterJson = ((int)masterType).ToString();
            string command = "GET_MASTER_WORKS";
            Dictionary<string, string> args = new Dictionary<string, string>();
            args.Add("cmd", command);
            args.Add("master", masterJson);

            ClientServerMessage receivedMessage = SendMessage(new ClientServerMessage(args));
            if (CheckReceivedMessage(receivedMessage) && receivedMessage.Arguments.ContainsKey("works"))
            {

                return JsonConvert.DeserializeObject<List<Work>>(receivedMessage.Arguments["works"]);
            }
            else
            {
                return null;
            }

        }
        //Метод отправки заявки на сервер
        public void AddAppointment(Appointment appointment, Employee master)
        {
            string masterJson = JsonConvert.SerializeObject(master);
            string appointmentJson = JsonConvert.SerializeObject(appointment);
            string command = "ADD_APPOINTMENT";
            Dictionary<string, string> args = new Dictionary<string, string>();
            args.Add("cmd", command);
            args.Add("master", masterJson);
            args.Add("appointment", appointmentJson);

            SendMessage(new ClientServerMessage(args));

        }


    }
}
