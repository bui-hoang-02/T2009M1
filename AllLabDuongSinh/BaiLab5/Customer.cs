using System;

namespace AllLabDuongSinh.BaiLab5
{
    public class Customer
    {
        public string Name { get; set; }
        public void getName()
        {
            Console.WriteLine("Enter you name.");
            Name = Console.ReadLine();
        }
    }
}