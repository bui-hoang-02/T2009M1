using System;
using AllLabDuongSinh.BaiLab2;
using AllLabDuongSinh.BaiLab3;
using AllLabDuongSinh.BaiLab5.Ex2;
using BaiLab6.Ex2;
using BaiLab6.Lab6Ex1;


namespace AllLabDuongSinh
{
    internal class Program 
    {
        public static void Main(string[] args)
        {
        //Ex Lab 7    
            // Menu menu = new Menu();
            // menu.menuEmployee();
            // MenuMain menu = new MenuMain();
            // Customer customer = new Customer();
            // while (true)
            // {
            //     Console.OutputEncoding = Encoding.UTF8;
            //     Console.WriteLine("Chon 1 hoặc 2.");
            //     int choice = int.Parse(Console.ReadLine());
            //     switch (choice)
            //     {
            //         case 1:
            //             customer.getName();
            //             Console.WriteLine("Nhập tên thành công.");
            //             break;
            //         case 2:
            //             menu.MenuCustomer();
            //             break;
            //     }
            // }
            
        //Ex Lab 6
            while (true)
            {
                Ex1 ex1 = new Ex1();
                Menu menu = new Menu();
                Console.WriteLine("1: Chạy bài ex1 lab 6.");
                Console.WriteLine("2: Chạy bài ex2 lab 6.");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1: 
                        ex1.MenuEx1();
                        break;
                    case 2:
                        menu.MenuEx2();
                        break;
                }
            }
            
        //Ex Lab 5
            
      


        //Ex Lab 3
        // Employee employee = new Employee();
        // Console.WriteLine("Please enter first name.");
        // employee.FirstName = Console.ReadLine();
        // Console.WriteLine("Please enter last name");
        // employee.LastName = Console.ReadLine();
        // Console.WriteLine("Please enter address.");
        // employee.Address = Console.ReadLine();
        // Console.WriteLine("Please enter sin.");
        // employee.Sin = long.Parse(Console.ReadLine());
        // Console.WriteLine("Please enter salary.");
        // employee.Salary = double.Parse(Console.ReadLine());
        // employee.ToString();
        //
        // double a = double.Parse(Console.ReadLine());
        // employee.TienThuong(a);

        //Ex Lab 3    
        // Atom atom = new Atom();
        // while (true)
        // {
        //     atom.accepts();
        //     Console.WriteLine("1: Tiếp tục. 2: Dừng");
        //     int choice = int.Parse(Console.ReadLine());
        //     while (choice != 1)
        //     {
        //         break;
        //     }
        //     atom.display();
        // }

        //Ex Lab 2
        // Ex1 ex1 = new Ex1();
        // ex1.BaoHienXaHoi();
        }
    }
}