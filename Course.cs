using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Index
{
    internal class Course 
    {
        string a;
        public Course(bool Done, string Email)
        {
            Member Accept = new Member(Done , Email);
        }
        public Course(string Email)
        {
            while ( a !="0")
            {
                Console.WriteLine("1 - CNC Course ");
                Console.WriteLine("2 - Sctchup ");
                Console.WriteLine("3 - Web Development ");
                Console.WriteLine("0 - Exit ");
                Console.WriteLine("Which one of these Courses do You Want to Join ? ");
                a = Console.ReadLine();                
                Join first = new Join(a , Email);
                
            }
  }
           
    }
    public struct Join
    {

        public Join(string a, string Email)
        {
            bool b = false;
            if (a == "0")
            {
                Student student = new Student(Email);
            }
            else if (a == "1")
            {
                Console.WriteLine("~~~~~ CNC Course ~~~~");
                Console.WriteLine("This Course Pirce is 10000IDQ");
                Console.Write("Do you Want Join this Course ? ");
                bool Counform = Convert.ToBoolean(Console.ReadLine());
                b = Conform(Counform);

            }

            else if (a == "2")
            {
                Console.WriteLine("~~~~~ Scetchup Course ~~~~");
                Console.WriteLine("This Course Pirce is 5000IDQ");
                Console.Write("Do you Want Join this Course ? ");
                bool Counform = Convert.ToBoolean(Console.ReadLine());
                b = Conform(Counform);
            }
            else if (a == "3")
            {
                Console.WriteLine("This Course Pirce is 3000IDQ");
                Console.Write("Do you Want Join this Course ? ");
                bool Counform = Convert.ToBoolean(Console.ReadLine());
                b = Conform(Counform);
            }
            else
            {
                Console.WriteLine("You didnt Join any course");
            }
            if (b == true)
            {
                Console.WriteLine("Congraglation Soon You will Add to Our Course if Every Think went right");
                Course Done = new Course(b, Email);
            }

        }

        private bool Conform(bool acc)
        {
            return acc;
        }
    }


}
