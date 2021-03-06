using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SaloonServer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Настраиваем точку, из которой сервер будет слушать входящие сообщения
            IPHostEntry iPHost = Dns.GetHostEntry("localhost");
            IPAddress iPAddress = iPHost.AddressList[0];

            const int port = 8081;
            IPEndPoint endPoint = new IPEndPoint(iPAddress, port);
            var tcpSocket = new Socket(iPAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                tcpSocket.Bind(endPoint);
                tcpSocket.Listen(10);

                while (true)
                {
                    Console.WriteLine($"Ожидается подключение через {endPoint} порт");
                    //Дождались подключения
                    Socket listener = tcpSocket.Accept();

                    //Получаем данные
                    string request = null;
                    byte[] bytes = new byte[4096];
                    int bytesLength = listener.Receive(bytes);
                    request += Encoding.UTF8.GetString(bytes, 0, bytesLength);

                    //Формируем и отправляем ответ
                    string response = RequestHandler.GetResponse(request);
                    byte[] responseMessage = Encoding.UTF8.GetBytes(response);
                    listener.Send(responseMessage);

                    //Закрываем соединение
                    listener.Shutdown(SocketShutdown.Both);
                    listener.Close();


                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.Read();
            }



        }
    }
}
