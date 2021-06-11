using System;
using System.Text;

namespace AllLabDuongSinh.BaiLab4
{
    public class Student : Person
    {
        public string Business { get; set; }
        public string ComputerScience { get; set; }
        public string GraphicDesign { get; set; }

        public void HienThiStudent()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"Name: {Name}, Phone: {Phone}, Email: {Email}, Business: {Business}, ComputerScience: {ComputerScience}, Graphic design: {GraphicDesign}");
        }
    }
}