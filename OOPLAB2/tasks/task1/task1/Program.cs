using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        class students
        {
            public string name;
            public int roll_no;
            public float cgpa;
        }
        static void Main(string[] args)
        {
            students s1 = new students();
            Console.WriteLine("enter name: ");
            s1.name = Console.ReadLine();
            Console.WriteLine("enter roll no: ");
            s1.roll_no = int.Parse(Console.ReadLine());
            Console.WriteLine("enter CGPA: ");
            s1.cgpa = float.Parse(Console.ReadLine());
            Console.WriteLine("name: {0} roll no: {1} cpga:{2}", s1.name, s1.roll_no, s1.cgpa);
            Console.Read();
        }
    }
}
