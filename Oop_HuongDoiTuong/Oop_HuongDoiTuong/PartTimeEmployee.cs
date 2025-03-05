using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_HuongDoiTuong
{
    internal class PartTimeEmployee : Employee
    {
        private int workingHour_332;
        public PartTimeEmployee()
        {
            
        }

        public PartTimeEmployee(string name_332, int paymentPerHour_332, int workingHour_332) : base(name_332, paymentPerHour_332)
        {
            this.workingHour_332 = workingHour_332;
        }


        public override int CaculateSalary()
        {
            return workingHour_332*this.GetPaymentPerHour();
        }
    }
}
