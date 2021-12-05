using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Odevi_Birol_Coruh
{
    public abstract class Employee
    {
        private string _firstName;
        private string _lastName;
        private string _SSN;
     
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string SSN
        {
            get { return _SSN; }
            set { _SSN = value; }
        }
        public abstract void Earnings();

    }
}
