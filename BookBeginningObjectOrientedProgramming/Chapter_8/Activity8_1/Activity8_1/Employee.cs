using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity8_1
{
    public class Employee
    {
        public delegate void LoginEventHandler(string loginName, Boolean status);
        public event LoginEventHandler LoginEvent;

        public void Login(string loginName, string password)
        {
            //Data normally retrievd from database
            if (loginName == "Smith" && password == "js")
                LoginEvent(loginName, true);
            else
                LoginEvent(loginName, false);
        }
    }
}
