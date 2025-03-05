using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_HuongDoiTuong
{
    internal class FullTimeEmployee : Employee
    {
        public FullTimeEmployee()
        {
            
        }

        public FullTimeEmployee(string name_332, int paymentPerHour_332): base(name_332, paymentPerHour_332)
        {
            
        }

        public override int CaculateSalary()
        {
            return 8*this.GetPaymentPerHour();
        }
    }
}
