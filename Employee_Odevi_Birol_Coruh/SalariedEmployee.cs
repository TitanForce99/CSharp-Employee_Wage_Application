using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Odevi_Birol_Coruh
{
    public class SalariedEmployee : Employee
    {
        private double earning;
        private double _weaklySalary;
        

        public double WeaklySalary
        {
            get { return _weaklySalary; }
            set { _weaklySalary = value; }
        }

        public SalariedEmployee(double weaklySalary )
        {
           _weaklySalary=weaklySalary;
        }


        public override void Earnings()
        {
            earning = _weaklySalary;
               
        }
        public override string ToString()
        {
            return "your title is Salaried Employee and your total earnings are " + earning.ToString()+" tl";
        }

        //public void toString()
        //{
        //   Console.WriteLine("your title is Salaried Employee and your total earnings are {0}",earning);

        //}
    }
}
