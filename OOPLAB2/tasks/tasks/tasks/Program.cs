using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks
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
            //first object
            students s1 = new students();
            s1.name = "ahmed";
            s1.roll_no = 5;
            s1.cgpa = 3.9F;
            Console.WriteLine("name: {0} roll no: {1} cpga:{2}", s1.name, s1.roll_no, s1.cgpa);
            //second object
            students s2 = new students();
            s2.name = "bilal";
            s2.roll_no = 6;
            s2.cgpa = 3.5F;
            Console.WriteLine("name: {0} roll no: {1} cpga:{2}", s2.name, s2.roll_no, s2.cgpa);
            Console.Read();
            
        }
    }
}
