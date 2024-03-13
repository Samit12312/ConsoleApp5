using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        void targil1()
        {
            for (int i = 1; i <= 999; i++)
            {
                int num = i;
                int num1 = i / 100;
                int num2 = i / 10 % 10;
                int num3 = i % 10;
                if ((num1 + num2 + num3) == 5)
                {
                    Console.WriteLine(num);
                }
            }
        }
        void targil2()
        {
            Console.WriteLine("eneter 20 number do numbers");
            for (int i = 1; i <= 20; i++)
            {
                int num = int.Parse(Console.ReadLine());
                int num1 = num / 10 % 10;
                int num2 = num % 10;
                int num3 = num1 + num2;
                Console.WriteLine(num3);


            }
        }
        void targil4()
        {
            for (int i = 1; i <= 100; i++)
            {
                int num = i;
                int num1 = i / 10 % 10;
                int num2 = i % 10;
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
        void targil5()
        {
            Console.WriteLine("eneter number for the amount of the tringle staright");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                string n = "";
                for (int j = 1; j <= i; j++)
                {
                    n += "*";
                }
                Console.WriteLine(n);
            }
        }
        void targil6()
        {
            Console.WriteLine("eneter number for the amount of the tringle staright");
            int num = int.Parse(Console.ReadLine());
            for (int i = num; i >= 1; i--)
            {
                string n = "";
                for (int j = 1; j <= i; j++)
                {
                    n += "*";
                }
                Console.WriteLine(n);
            }
        }
        void targil7()
        {
            for (int i = 1; i <= 10; i++)
            {
                // Iterate over columns
                for (int j = 1; j <= 10; j++)
                {
                    // Calculate the product and print
                    Console.Write($"{i * j,4}");
                }
                // Move to the next row
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {

            Console.ReadLine();
        }
    }
}
