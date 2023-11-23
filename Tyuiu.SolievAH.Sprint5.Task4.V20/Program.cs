using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SolievAH.Sprint5.Task4.V20.Lib;

namespace Tyuiu.SolievAH.Sprint5.Task4.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Солиев А.Х | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый фай                         *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Солиев Алижон Хотамжонович | СМАРТб-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            string path = @"C:\DataSprint5\InPutDataFileTask4V20.txt";
            Console.WriteLine("Данные находятся в файле:" + path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
