using System;
using System.Text;

namespace AllLabDuongSinh.BaiLab3
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public long Sin { get; set; }
        public double Salary { get; set; }

        public void ToString()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"Full name: {FirstName} {LastName}, Address: {Address}, Sin: {Sin}, Salary: {Salary}$");
        }

        public void TienThuong(double percentage)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"Tiền thưởng: {Salary * percentage}$");
        } 
    }
}