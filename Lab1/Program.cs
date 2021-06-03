using System;
using Lab1.Lab1;

namespace Lab1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            BaiLab1 baiLab1 = new BaiLab1();
            Console.WriteLine("Nhập lab muốn chọn.");
            Console.WriteLine("1: Bài lab 1");
            Console.WriteLine("2: Bài lab 2");
            Console.WriteLine("3: Bài lab 3");
            Console.WriteLine("4: Bài lab 4");
            Console.WriteLine("5: Bài lab 5");
            Console.WriteLine("0: Thoát chương trình.");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    baiLab1.lab1();
                    break;
                case 2:
                    baiLab1.lab2();
                    break;
                case 3:
                    baiLab1.lab3();
                    break;
                case 4:
                    baiLab1.lab4();
                    break;
                case 5:
                    baiLab1.lab5();
                    break;
                case 0:
                    break;
            }
        }
    }
}