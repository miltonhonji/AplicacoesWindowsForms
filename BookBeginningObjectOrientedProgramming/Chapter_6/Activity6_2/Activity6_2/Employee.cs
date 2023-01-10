using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity6_2
{ 
    class Employee
    {
        #region Variables

        private int _empID;
        private string _loginName;
        private string _password;
        private int _securityLevel;
        private int _ssn;
        private string _department;

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

        public int Ssn
        {
            get { return _ssn; }
            set { _ssn = value; }
        }

        public string Department
        {
            get { return _department; }
            set { _department = value; }
        }
        
        #endregion Properties

        #region Constructor

        public Employee()
        {
            _empID = GetNextID();
        }

        public Employee(int empID)
        {
            //Constructor for existing employee
            //Simulates retrieval from database
            if(empID == 1)
            {
                _empID = empID;
                LoginName = "smith";
                Password = "js";
                Ssn = 123456789;
                Department = "IS";
            }
            else if(empID == 2)
            {
                _empID = empID;
                LoginName = "jones";
                Password = "mj";
                Ssn = 987654321;
                Department = "HR";
            }
            else
            {
                throw new Exception("Invalid Employee ID");
            }
        }

        #endregion Constructor

        #region Methods

        private int GetNextID()
        {
            //Simulates the retrieval of next
            //avaiable id from database
            return 100;
        }

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

        public string Update(string loginName, string password)
        {
            LoginName = loginName;
            Password = password;
            return "Security info updated.";
        }

        public string Update(int ssNumber, string department)
        {
            Ssn = ssNumber;
            Department = department;
            return "HR info updated.";
        }

        #endregion Methods
    }
}
