using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_handling_remaining_tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Task2();
        }
        static void Task1()
        {

            string path = "C:\\Users\\HP\\Documents\\SEMESTER02\\OOP LAB\\week01\\File handling remaining tasks";
            if (File.Exists(path))
            {
                StreamReader filevariable = new StreamReader(path);
                string record;
                while ((record = filevariable.ReadLine()) != null)
                {
                    Console.WriteLine(record);
                }
                filevariable.Close();
            }
            else
            {
                Console.WriteLine("not exists");
            }
            Console.ReadKey();
        }
        static void Task2()
        {
            string path = "C:\\Users\\HP\\Documents\\SEMESTER02\\OOP LAB\\week01\\File handling remaining tasks";
            StreamWriter filevariable = new StreamWriter(path, true);
            filevariable.WriteLine("hello");
            filevariable.Flush();
            filevariable.Close();
            Console.ReadKey();
        }
    }
}
