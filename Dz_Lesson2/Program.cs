using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstTask();

        }

        private static void FirstTask()
        {
            Console.WriteLine("Вводите строку");
            
            StringBuilder str = new StringBuilder();
            
            var key = Console.ReadKey();
            var point =46;
            int enter =(int)ConsoleKey.Enter;
            int kolProbel = 0;
            do
            {
                if (key.GetHashCode() != enter)
                {
                    str.Append(key.KeyChar);
                }
                if(key.KeyChar==' ')
                {
                    kolProbel++;
                }
                key = Console.ReadKey();

            }
            while (key.GetHashCode() != point);
            Console.WriteLine();
            Console.Write("Строка - ");
            Console.WriteLine(str);
            Console.Write("Количество пробелов - ");
            Console.WriteLine(kolProbel);
            Console.ReadLine();
        }
    }
}
