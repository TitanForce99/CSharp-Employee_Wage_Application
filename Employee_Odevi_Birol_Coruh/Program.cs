using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Odevi_Birol_Coruh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SalariedEmployee s1 = new SalariedEmployee(500);
            s1.FirstName = "Birol";
            s1.LastName = "Coruh";
            s1.SSN = "39021743640";
            s1.Earnings();
            Console.WriteLine(s1.ToString());

            CommissionEmployee c1 = new CommissionEmployee(5000, 11);
            c1.FirstName = "Adem";
            c1.LastName = "Erkant";
            c1.SSN = "39155532127";
            c1.Earnings();
            Console.WriteLine(c1.ToString());

            HourlyEmployee h1 = new HourlyEmployee(1250, 37);
            h1.FirstName = "Kenan";
            h1.LastName = "Çetin";
            h1.SSN = "21639122015";
            h1.Earnings();
            Console.WriteLine(h1.ToString());

            BasePlusCommissionEmployee bc1 = new BasePlusCommissionEmployee(2500, 1000, 11);
            bc1.FirstName = "Serkan";
            bc1.LastName = "Çelik";
            bc1.SSN = "67164322811";
            bc1.Earnings();
            Console.WriteLine(bc1.ToString());

            Console.ReadKey();
        }
    }
}
