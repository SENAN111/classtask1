using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12.Models
{
    internal class User
    {
        public string username;
        public string password;
        public bool IsSignedIn;
        public string Username
        {
            get { return username; }
            set
            {
                if (value.Trim().Length > 6 && value.Trim().Length<25)
                {
                    username = value.Trim();
                }
            }
        }
        public string Password
        {
            get { return username; }
            set
            {
                if (value.Length > 6 && value.Length < 25)
                {
                    password = value;
                }
            }
        }
        public bool checkpassword()
        {
            int dight = 0;
            int upper = 0;
            int lower = 0;
            for (int i = 0; i < password.Length; i++)
            {
               if(passw)
                {
                    lower++;
                }
                if (password[i].IsDigit)
                {
                    dight++;
                }
                if (char.IsUpper)
                {
                    upper++;
                }
            }
            if(dight>0 && upper>0 && lower>0)
            {
                return true;
            }
            else
            {
                return false;
            }
           public bool login()
            {

            }
            
        }
    }
}
