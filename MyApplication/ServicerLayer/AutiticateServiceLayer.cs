using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyApplication.ServicerLayer
{
    public class AutiticateServiceLayer
    {
        public static bool Login(string username, string password)
        {
           return AutiticateDBLayer.Login(username, password);
        }
    }
}