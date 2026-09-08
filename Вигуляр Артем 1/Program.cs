using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Вигуляр_Артем_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double result = a * b * b;
            Console.WriteLine(result);
            //2
            int alldays = Convert.ToInt32(Console.ReadLine());
            int weeks = alldays / 7;
            int days = alldays % 7;
            Console.WriteLine(weeks + " тижні " + days + " дні");
            //3
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num * 0.12);
            //5
            string name = Console.ReadLine();
            int year = Convert.ToInt32(Console.ReadLine());
            int age = 2026 - year;
            Console.WriteLine("Вітаю " + name + ", вам " + age + " років.");
            













        }
    }
}
