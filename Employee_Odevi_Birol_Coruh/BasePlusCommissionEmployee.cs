using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Odevi_Birol_Coruh
{
    public class BasePlusCommissionEmployee:CommissionEmployee
    {

        private double earning;
        private double _baseSalary;
       
        public double BaseSalary
        {
            get { return _baseSalary; }
            set { _baseSalary = value; }
        }
    
        public  BasePlusCommissionEmployee(double baseSalary,double grossSales,double commissionRate):base(grossSales,commissionRate)
        {
            
            _baseSalary = baseSalary;
          
        }
     
        public override void Earnings()
        {
            earning = (CommissionRate * GrossSales) + _baseSalary;
        }
        public override string ToString()
        {
            return "your title is Base Plus Commission Employee and your total earnings are " + earning.ToString()+ " tl";
        }
    }
}
