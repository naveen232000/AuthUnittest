using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthLib
{
    public class Authentication
    {
        public string SignIn(string username, string password)
        {
            string msg = "";
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
               msg = "Provide Username and password";
            }
            else
            {
                if(username == "naveen" && password == "naveen@123") {
                    msg = "Signin Success";
                }
                else
                {
                    msg = "Invalid Credientials";
                }
            }
            return msg;
        }
    }
}
