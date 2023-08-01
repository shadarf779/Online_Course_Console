using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index
{
    internal class Wellcome : UserInfo
    {
        string a;
        public Wellcome()
        {
         
        }
        public Wellcome(int id, string[] Email, string[] Password, bool[] Gender , string[] FName)
        {
            while (a != "Exit")
            {
                Console.WriteLine($"Id {id} , Email {Email[id]} , Name {FName[id]} ");
                Console.WriteLine("PI Organization is Organization which thier target is improve human skills about\r\nengineering and Human developent and Information technalogy and language");
                Console.WriteLine("1- BE Student at Pi Organization : ");              
                Console.WriteLine("0 - Exit ");;
                a = Console.ReadLine();
               if (a == "1")
                {
                    Student student = new Student( Email);
                }
                else if (a == "0")
                {
                    Account account = new Account(id, Email, Password, Gender ,FName);
                }
                else
                {
                    Console.WriteLine("SomeThing Going Worng please try again ");
                }

            }
        }

    }
}
