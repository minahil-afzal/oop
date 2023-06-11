using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FILE_HANDLING
{
    class Program
    {
        static int add(int n1, int n2)
        {
            return n1 + n2;
        }
        static void Main(string[] args)
        {
            int num1;
            int num2;
            Console.Write("enter first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("enter second number: ");
            num2 = int.Parse(Console.ReadLine());
            int result = add(num1, num2);
            Console.WriteLine("sum is{0}", result);
            Console.Read();

        }
    }
}
