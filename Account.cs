using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index
{
    internal class Account : UserInfo
    {
            public Account(int id, string[] Email, string[] Password, bool[] Gender, string[] FName)
        {
            Console.Write("Have Account ? ");
            bool HaveAccount=Convert.ToBoolean(Console.ReadLine());
                if (HaveAccount )
                {
                    Sign_in sign_In = new Sign_in(id, Email, Password, Gender, FName);
                }
                else
                {
                
                    SignUp signUp = new SignUp(id, Email, Password, Gender);
                }

          
        }
    }
}
