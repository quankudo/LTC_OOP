using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Oop_HuongDoiTuong
{
    abstract class Employee : IEmployee
    {
        private string name_332;
        private int paymentPerHour_332;

        public Employee()
        {
            
        }

        public Employee(string name_332, int paymentPerHour_332)
        {
            this.name_332 = name_332;
            this.paymentPerHour_332 = paymentPerHour_332;
        }

        public abstract int CaculateSalary();

        public string GetName()
        {
            return name_332;
        }

        public void SetName(string name_332)
        {
            this.name_332 = name_332;
        }

        public int GetPaymentPerHour()
        {
            return paymentPerHour_332;
        }

        public void SetPaymentPerHour(int paymentPerHour_332)
        {
            this.paymentPerHour_332 = paymentPerHour_332;
        }
    }
}
