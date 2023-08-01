using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index
{

    internal class Member : UserInfo
    {
        private int Sirial;
        //string[] Role = new string[100];
        //double[] Points = new double[100];
        //int[] SecretNumber = new int[100];
        protected Member()
        {

        }
        public Member(bool a, string Email)
        {
            aStudent(a , Email);
        }
        private void  aStudent(bool NewStudent, string Email)
        {
            Console.WriteLine($"This  want to join this Course Will you Accept him ?");
            NewStudent = Convert.ToBoolean(Console.ReadLine());
            if (NewStudent == true)
            {
                Console.Write("Give a Serial Code : ");
                Sirial = Convert.ToInt32(Console.ReadLine());
                Student r = new Student(NewStudent, Email, Sirial);
            }
        }

    }
}
