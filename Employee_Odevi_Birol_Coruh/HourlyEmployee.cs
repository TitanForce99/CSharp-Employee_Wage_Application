using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Odevi_Birol_Coruh
{
    public class HourlyEmployee : Employee
    {
        private double earning;
        private double _wage;

        public double Wage
        {
            get { return _wage; }
            set { _wage = value; }
        }

        private double _hours;

        public double Hours
        {
            get { return _hours; }
            set { _hours = value; }
        }
        public HourlyEmployee(double wage, double hours)
        {
            _wage = wage;
            _hours = hours; 
        }

        public override void Earnings()
        {
            if (_hours <= 40)
            {
                earning = _wage * _hours;
            }
            else
            {
                earning = (40 * _wage) + (_hours - 40) * _wage * 1.5;
            }
        }
        public override string ToString()
        {
            return "your title is Hourly Employee and your total earnings are " + earning.ToString()+ " tl";
        }
    }
}
