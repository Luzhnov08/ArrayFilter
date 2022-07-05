using System;

namespace ArrayFilter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //string[] StartArray = { "hello", "2", "world", ":-)" };
            
            int counter = 0;
            string Result = "";
            string UserData = "";

            //Ввод данных пользователя
            Console.WriteLine("Добро пожаловать! \nВведите элементы массива через запятую для анализа: ");
            UserData = Console.ReadLine();
            string[] StartArray = UserData.Split(",");

            int ArrLen = StartArray.Length;
            string[] ResultArray = new string[ArrLen];

            //Анализ элементов массива
            for (int i = 0; i < ArrLen; i++)
            {
                if (StartArray[i].Length <= 3)
                {
                    ResultArray[counter] = StartArray[i];
                    counter = counter + 1;
                }
            }

            //Формируем строку-результат для вывода на экран
            for (int i = 0; i < counter; i++)
            {
                if (i < counter-1)
                {
                    Result = Result + ResultArray[i] + ",";
                }
                else
                {
                    Result = Result + ResultArray[i];
                    Result = "[" + Result + "]";
                }
            }

            Console.WriteLine("Результат: " + Result);
            Console.ReadKey();
        }
    }
}