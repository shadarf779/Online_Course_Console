using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Index
{
    internal class SignUp : UserInfo
    {
         public SignUp(int id, string[] Email, string[] Password, bool[] Gender) 
        {
            id++;
            CreateAccount(id);
        } 
        public void CreateAccount(int id)
        {
            Console.WriteLine("ID : " + id);
            //First Name            
            Console.WriteLine("First name");
            FName[id] = Console.ReadLine();
            //Last Name
            Console.WriteLine("last name");
            LName[id] = Console.ReadLine();
            //Gender
            Console.WriteLine("Gender");
            Gender[id] = Convert.ToBoolean(Console.ReadLine());
            //Email
            Console.WriteLine("Email");
            Email[id] = Console.ReadLine();
            string[] Pass = aPassword(id);
        }
        private string[] aPassword(int id)
        {
         
            //Verifyng The Password
            Password[id] = "0";
            Verify[id] = "22";
            while (true)
            {
                //Password
                while (true)
                {
                    Console.WriteLine("Password");
                    Password[id] = Console.ReadLine();
                    if (Password[id].Length < 8)
                    {
                        Console.WriteLine("You password should be 8 letter");
                        continue;
                    }
                    else
                    {
                        break;
                    }

                }
                int[] b = new int[Password[id].Length];
                char[] a = Password[id].ToCharArray();

                for (int i = 0; i < Password[id].Length; i++)
                {
                    b[i] = Convert.ToInt32(a[i]);
                }
                for (int i = 0; i < Password[id].Length; i++)
                {
                    if (b[i] <= 57 && b[i] >= 48)
                    {
                        for (int c = 0; c < Password[id].Length; c++)
                        {
                            if (b[c] <= 90 && b[c] >= 65)
                            {
                                for (int d = 0; d < Password[id].Length; d++)
                                {
                                    if (b[d] <= 122 && b[d] >= 97)
                                    {
                                        for (int j = 0; j < Password[id].Length; j++)
                                        {
                                            if ((b[j] <= 126 && b[j] > 122) || (b[j] < 97 && b[j] > 90) || (b[j] < 65 && b[j] > 57) || (b[j] < 48 && b[j] > 32))
                                            {
                                                //Verifying Password
                                                Console.WriteLine("VPassword");
                                                Verify[id] = Console.ReadLine();
                                                if (Password[id] == Verify[id])
                                                {
                                                    Sign_in Log = new Sign_in(id , FName[id], LName[id], Password[id], Email[id], Gender[id],FName[id]);
                                                    Wellcome wellcome = new Wellcome(id, Email, Password, Gender , FName);
                                                    return (Verify);                                                                                                   
                                                }
                                                else
                                                {
                                                    Console.WriteLine(" the password isnt Correct!!!!! Please Try Again");
                                                    aPassword(id);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                Console.WriteLine("The password isnt strong The password should Contain Number and Small and Capital letter and symbol");
            }            
        }
        
    }
}
