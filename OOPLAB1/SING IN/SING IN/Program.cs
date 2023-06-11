﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace SING_IN
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\HP\\Documents\\SEMESTER02\\OOP LAB\\week01";
            string[] names = new string[5];
            string[] password = new string[5];
            int option;
            do
            {
                readData(path, names, password);
                Console.Clear();
                option = menu();
                Console.Clear();
                if (option == 1)
                {
                    Console.WriteLine("Enter name:");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter password:");
                    string p = Console.ReadLine();
                    signIn(n, p, names, password);
                }
                else if (option == 2)
                {
                    Console.WriteLine("Enter name:");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter password:");
                    string p = Console.ReadLine();
                    signUp(n, p, path);
                }
            }
            while (option < 3);
            Console.ReadKey();
        }
        static int menu()
        {
            int option;
            Console.WriteLine("1.  SignIn");
            Console.WriteLine("2.  SignUp");
            Console.WriteLine("Enter option");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        static void readData(string path, string[] names, string[] password)
        {
            int x = 0;
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    names[x] = parseData(record, 1);
                    password[x] = parseData(record, 2);
                    x++;
                    if (x >= 5)
                    {
                        break;
                    }
                }
                fileVariable.Close();
            }
            else
            {
                Console.WriteLine("Not Exists");
            }
        }
        static void signIn(string n, string p, string[] names, string[] password)
        {
            bool flag = false;
            for (int x = 0; x < 5; x++)
            {
                if (n == names[x] && p == password[x])
                {
                    Console.WriteLine("Valid User");
                    flag = true;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Invalid User");
            }
            Console.ReadKey();
        }
        static void signUp(string n, string p, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine();
            file.WriteLine(n + "," + p);
            file.Flush();
            file.Close();
        }
    }
}
