using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Task10();
        }
        static void task1()
        {
            Console.Write("hello world!!");
            Console.Write("hello programming");
        }
        static void task2()
        {
            Console.WriteLine("hello world!!");
            Console.WriteLine("hello programming");
        }
        static void task3()
        {
            int variable = 7;
            Console.WriteLine("VALUE: ");
            Console.Write(variable);
            Console.ReadKey();
        }

        static void task4()
        {
            string variable = "i am a string";
            Console.WriteLine("string: ");
            Console.Write(variable);
            Console.ReadKey();
        }
        static void task5()
        {
            char variable = 'A';
            Console.WriteLine("character: ");
            Console.Write(variable);
            Console.ReadKey();
        }
        static void Task6()
        {
           float variable = 2.2F;
            Console.WriteLine("Decimal: ");
            Console.Write(variable);
            Console.ReadKey();
        }
        static void Task7()
        {
            string str;
            str = Console.ReadLine();
            Console.WriteLine("you have inputted: ");
            Console.WriteLine(str);
            Console.ReadKey();
        }
        static void Task8()
        {
            string str;
            str = Console.ReadLine();
            Console.WriteLine("you have inputted: ");
            int num = int.Parse(str);
            Console.WriteLine("the number is: ");
            Console.Write(num);
            Console.ReadKey();
        }
        static void Task9()
        {
            string str;
            Console.WriteLine("enter floating point value: ");
            str = Console.ReadLine();
            float num = float.Parse(str);
            Console.WriteLine("the floating number is: ");
            Console.Write(num);
            Console.ReadKey();
        }
        static void Task10()
        {
            float length;
            float area;
            string str;
            Console.WriteLine("enter length: ");
            str = Console.ReadLine();
            length = float.Parse(str);
            area = length * length;
            Console.WriteLine("the area is: ");
            Console.Write(area);
            Console.ReadKey();
        }
    }
}
