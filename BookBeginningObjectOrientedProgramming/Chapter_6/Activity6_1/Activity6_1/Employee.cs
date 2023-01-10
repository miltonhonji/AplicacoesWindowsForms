using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity6_1
{
    class Employee
    {
        #region Variables

        private int _empID;
        private string _loginName;
        private string _password;
        private int _securityLevel;

        #endregion Variables

        #region Properties

        public int EmployeeID
        {
            get { return _empID; }
        }

        public string LoginName
        {
            get { return _loginName; }
            set { _loginName = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public int SecurityLevel
        {
            get { return _securityLevel; }
        }

        #endregion Properties

        #region Methods
        public Boolean Login (string loginName, string password)
        {
            LoginName = loginName;
            Password = password;

            //Data Nomally retrieved from database
            if(loginName == "Smith" & password == "js")
            {
                _empID = 1;
                _securityLevel = 2;
                return true;
            }
            else if(loginName == "Jones" & password == "mj")
            {
                _empID = 2;
                _securityLevel = 4;
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion Methods
    }
}
