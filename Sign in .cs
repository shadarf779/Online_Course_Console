using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index
{
     class Sign_in : UserInfo
    {
        public Sign_in(int id, string[] Email, string[] Password, bool[] Gender, string[] FName )
        {
            LogIn(id , Email , Password ,Gender , FName);
        }
        protected void LogIn(int id, string[] Email, string[] Password , bool[] Gender , string[] FName)
        {
          
            string aEmail = "1";
            while (aEmail != "0")
            {
                Console.WriteLine("Enter Your Email :");
                aEmail = Console.ReadLine();
                Console.WriteLine("Enter Your Password");
                string aPassWord = Console.ReadLine();

                for (int i = 0; i <= id; i++)
                {
                    if (aEmail == Email[i])
                    {
                        for (int j = 0; j <= id; j++)
                        {
                            if (aPassWord == Password[j])
                            {
                                if (Gender[i] )
                                {
                                    Console.WriteLine("id : " + id);
                                    Console.WriteLine($" Wellcome Mr {FName[i]} {LName[i]}");
                                    Wellcome wellcome = new Wellcome(i, Email, Password, Gender , FName);
                                }
                                else
                                {
                                    Console.WriteLine("id : " + id);
                                    Console.WriteLine($" Wellcome Miss {FName[i]} {LName[i]}");
                                    Wellcome wellcome = new Wellcome(id, Email, Password, Gender, FName);
                                }
                            }
                        }
                    }
                    

                }
                {
     
                        Console.WriteLine("Your Email or Your Password is Worng");

                }

                
            }
            Console.WriteLine("Press 0 to stop");
        }
        public Sign_in(int id ,string FName, string LName, string Password, string Email, bool Gender, string aFName)
        {
            this.FName[id] = FName;
            this.LName[id] = LName;
            this.Password[id] = Password;
            this.Email[id] = Email;
            this.Gender[id] = Gender;
        }
    }
 }

