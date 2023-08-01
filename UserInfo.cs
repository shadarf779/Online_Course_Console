using System.Data;
using System.Net;
using System.Xml.Linq;

namespace Index
{
    internal class UserInfo
    {
        protected string[] FName = new string[100], LName = new string[100], Password = new string[100], Verify = new string[100], Email = new string[100];
        protected bool[] Gender = new bool[100];
        int aid;
        public UserInfo()
        {
            FName[aid] = "Shad";
            LName[aid] = "Arf";
            Password[aid] = "12!@qwQW";
            Email[aid] = "shad_arf";
            Gender[aid] = true;
            FName[++aid] = "azad";
            LName[aid] = "dana";
            Password[aid] = "12!@qwQW";
            Email[aid] = "hana_dana";
            Gender[aid] = true;
            FName[++aid] = "sara";
            LName[aid] = "dara";
            Password[aid] = "12!@qwQW";
            Email[aid] = "sara_dara";
            Gender[aid] = false;
            FName[++aid] = "shara";
            LName[aid] = "aram";
            Password[aid] = "12!@qwQW";
            Email[aid] = "shara_aram";
            Gender[aid] = false;
            
        }
       
        public void Account()
        {
            Account account = new Account(aid , Email , Password , Gender , FName);
        }
    }
}
