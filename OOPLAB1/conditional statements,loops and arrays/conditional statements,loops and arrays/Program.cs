using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditional_statements_loops_and_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Task2();
        }
        static void Task1()
        {
            string input;
            float marks;
            Console.WriteLine("enter the marks: ");
            input = Console.ReadLine();
            marks = float.Parse(input);
            if (marks > 50)
            {
                Console.WriteLine("you are passed...");
            }
            else
            {
                Console.WriteLine("you are failed...");
            }
            Console.Read();
        }
        static void Task2()
        {
            for (int x=0;x<5;x++)
            {
                Console.WriteLine("welcome jack");
            }
            Console.Read();
        }
        static void Task3()
        {
            int num;
            int sum = 0;
            Console.Write("enter number: ");
            num = int.Parse(Console.ReadLine());
            while (num!= -1)
            {
                sum = sum + num;
                Console.Write("eneter number: ");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("the total sum is {0} ", sum);
            Console.Read();
        }
        static void Task4()
        {
            int num;
            int sum = 0;
            do
            {
                Console.Write("enter number: ");
                num = int.Parse(Console.ReadLine());
                sum = sum + num;
            }
            while (num != -1) ;
             sum = sum + 1;   
            Console.WriteLine("the total sum is {0} ", sum);
            Console.Read();
        }
        static void Task5()
        {
            // Taking input
            int[] numbers = new int[3];
            for(int idx=0; idx<3; idx++)
            {
                Console.Write("enter the number {0}: ", idx);
                    numbers[idx] = int.Parse(Console.ReadLine());
            }
            // finding largest
            int largest = -1;
            for (int idx = 0; idx < 3; idx++)
            {
               if (numbers[idx] > largest)
                {
                    largest = numbers[idx];
                }
            }
            Console.WriteLine("the largest is {0} ", largest);
            Console.Read();
        }

    }
}
