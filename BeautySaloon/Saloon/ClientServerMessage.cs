using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Saloon
{
    //Класс, упрощающий обмен данными с сервером
    public struct ClientServerMessage
    {
        //Словарь аргументов. Ключ словаря- название аргумента, значение словаря- значение аргумента
        public Dictionary<string, string> Arguments { get; }
        //Аргументы, в ввиде одной строки
        public string Message { get; }
        //Конструктор сообщения, через список аргументов
        public ClientServerMessage(Dictionary<string, string> arguments)
        {

            Arguments = arguments;

            Message = ArgsToMessage(arguments);
        }

        //Конструктор сообщения через строку
        public ClientServerMessage(string message)
        {

            Message = message;
            Arguments = SplitByArgs(message);

        }
        //Метод перевода аргументов в строковый вид (arg1;value1/arg2;value2/.../argN;valueN)
        private static string ArgsToMessage(Dictionary<string, string> arguments)
        {
            StringBuilder str = new StringBuilder();
            foreach (var arg in arguments)
            {
                str.Append($"{arg.Key};{arg.Value}/");
            }
            str.Remove(str.Length - 1, 1);
            return str.ToString();
        }
        //Метод перевода аргументов в строковом виде (arg1;value1/arg2;value2/.../argN;valueN) в словарь 
        private static Dictionary<string, string> SplitByArgs(string message)
        {
            
            var argumentValuePairs = message.Split('/');
            Dictionary<string, string> args = new Dictionary<string, string>();
            foreach (var pair in argumentValuePairs)
            {
                var splitPair = pair.Split(';');

                if (splitPair.Length == 2)
                {

                    args[splitPair[0]] = splitPair[1];
                }
                else
                {
                    args[splitPair[0]] = "NULL";
                }


            }
            return args;

        }
    }
}
