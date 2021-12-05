using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Odevi_Birol_Coruh
{
    public class CommissionEmployee : Employee
    {
        private double earning;
        private double _grossSales;

        public double GrossSales
        {
            get { return _grossSales; }
            set { _grossSales = value; }
        }
        private double _commissionRate;

        public double CommissionRate
        {
            get { return _commissionRate; }
            set { _commissionRate= value; }
        }
        public CommissionEmployee(double grossSales,double commissionRate)
        {
            _grossSales = grossSales;
            _commissionRate = commissionRate;
        }

        public override void Earnings()
        {
            earning = _grossSales * _commissionRate;
        }
        public override string ToString()
        {
            return "your title is Commission Employee and your total earnings are " + earning.ToString()+ " tl";
        }
    }
}
