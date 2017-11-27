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
            // SecondTask();
            // ThirdTask();
            //FourthTask();
            //FifthTask();
        }

        private static void FifthTask()
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            Console.WriteLine("Ваша строка - ");
            for(int i = str.Length - 1; i > -1; i--)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        private static void FourthTask()
        {
            int A;
            int B;
            Console.WriteLine("Введите число А(А<B)");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число B(А<B)");
            B = int.Parse(Console.ReadLine());
            for (int i = A; i <= B; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        private static void ThirdTask()
        {
            string str;
            Console.WriteLine("Введите строку");
            str = Console.ReadLine();
            int register;
            Console.WriteLine("Выберите регистер: 1 - нижний регистр, 2 - верхний регистр");
            register = int.Parse(Console.ReadLine());
            if (register == 1)
            {
                Console.WriteLine(str.ToLower());
            }
            else if (register == 2)
            {
                Console.WriteLine(str.ToUpper());
            }
            else
            {
                Console.WriteLine("Вы ввели неверное число");
            }
            Console.ReadLine();
        }

        private static void SecondTask()
        {
            int[] ticket = new int[6];
            int sumOfFirstPart = 0;
            int sumOfSecondPart = 0;

            for (int i = 0; i < ticket.Length; i++)
            {
                Console.Write("Введите ");
                Console.Write(i + 1);
                Console.WriteLine(" номер билета");
                ticket[i] = int.Parse(Console.ReadLine());
                if (i < 3)
                {
                    sumOfFirstPart += ticket[i];
                }
                else
                {
                    sumOfSecondPart += ticket[i];
                }
            }
            if (sumOfFirstPart == sumOfSecondPart)
            {
                Console.WriteLine("Билет счастливый!!");
            }
            else
            {
                Console.WriteLine("Билет не счастливый :(");
            }
            Console.ReadLine();



        }

        private static void FirstTask()
        {
            Console.WriteLine("Вводите строку");

            StringBuilder str = new StringBuilder();

            var key = Console.ReadKey();
            var point = 46;
            int enter = (int)ConsoleKey.Enter;
            int countProbel = 0;
            do
            {
                if (key.GetHashCode() != enter)
                {
                    str.Append(key.KeyChar);
                }
                if (key.KeyChar == ' ')
                {
                    countProbel++;
                }
                key = Console.ReadKey();

            }
            while (key.GetHashCode() != point);
            Console.WriteLine();
            Console.Write("Строка - ");
            Console.WriteLine(str);
            Console.Write("Количество пробелов - ");
            Console.WriteLine(countProbel);
            Console.ReadLine();
        }
    }
}
