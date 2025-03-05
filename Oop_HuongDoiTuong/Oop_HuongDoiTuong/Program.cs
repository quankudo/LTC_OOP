using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_HuongDoiTuong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            PartTimeEmployee partTimeEmployee_332 = new PartTimeEmployee("Nguyễn Hữu Quân", 100, 5);
            FullTimeEmployee fullTimeEmployee_332 = new FullTimeEmployee("Lê Thị Diệu Huyền", 200);

            Console.WriteLine($"Nhân viên làm part time:\nHọ tên: {partTimeEmployee_332.GetName()}\nLương {partTimeEmployee_332.GetPaymentPerHour()}$/h ({partTimeEmployee_332.GetWorkingHour()} giờ): {partTimeEmployee_332.CaculateSalary()}$");
            Console.WriteLine("--------------------------");
            Console.WriteLine($"Nhân viên làm full time:\nHọ tên: {fullTimeEmployee_332.GetName()}\nLương 1 ngày: {fullTimeEmployee_332.CaculateSalary()}$");

            Console.ReadKey();
        }
    }
}
