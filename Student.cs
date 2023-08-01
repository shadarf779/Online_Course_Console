using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Index
{
    internal class Student : Wellcome
    {
        Dictionary<string, long> Student_Code = new Dictionary<string, long>();

        public Student(bool AddStudent , string Email , int Sirial )
        {
            if (AddStudent == true)
            {
                Console.WriteLine("This is Your Serial Code Save Your Serial Code");
                Student_Code.Add(Email, Sirial);
                if (Student_Code.ContainsKey(Email))
                {
                    Console.WriteLine(Email + " number is " + Student_Code[Email]);
                }
                Console.ReadKey();
            }else if (AddStudent == false)
            {
                Console.WriteLine("Sorry You Cant Join This Course Check Please Try SomeTHing else ");
                Console.WriteLine("Contact US at : 07501111111");
            }
        }
        public Student(string Email)
        {
            Wellcome wellcome = new Wellcome();
        }
        public Student( string[] Email)
        {

            Console.WriteLine("Your Email : ");
            string aEmail = Console.ReadLine();
            Student_Code = new Dictionary<string, long>();
            for (int i = 0; i < Email.Length; i++)
            {
                if (aEmail == Email[i])
                {

                    {
                        Course course = new Course(aEmail);
                    }

                }

            }
        }
    }
}
