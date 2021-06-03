using System;
using System.Text;

namespace Lab1.Lab1
{
    public class BaiLab1
    {
        public void lab1()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("name:");
            string name = Console.ReadLine();
            Console.WriteLine("address:");
            string address = Console.ReadLine();
            Console.WriteLine("phone:");
            string phone = Console.ReadLine();
            Console.WriteLine($"name: {name} | address: {address} | phone: {phone} ");
        }
        
        public void lab2()
        {
            Console.WriteLine("number 1:");
            int one = int.Parse(Console.ReadLine());
            Console.WriteLine("number 2:");
            int two = int.Parse(Console.ReadLine());
            Console.WriteLine("number 3:");
            int three = int.Parse(Console.ReadLine());
            if (one > two && two > three)
            {
                Console.WriteLine(one);
            }
            else if (two > one && one > three)
            {
                Console.WriteLine(two);
            }
            else
            {
                Console.WriteLine($"max {three}");
            }
        }
        
        public void lab3()
        {
            Console.WriteLine("choice (1-7) to display the corresponding day of the week");
            Console.WriteLine("choice 8 exit");
            int choice = int.Parse(Console.ReadLine());

            if (choice >= 1 && choice < 7)
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;
                }
            }
        }
        
        public void lab4()
        {
            
            Console.WriteLine("Enter n:");
            int a = int.Parse(Console.ReadLine());
            {
                    
            }
            for (int i = 1; i < 10; i++)
            {
                int sun = a * i;
                Console.WriteLine($"{a} x {i} = {sun}");
            }
        }
        
        public void lab5()
        {
            int i,fact=1,number;      
            Console.Write("Enter any Number: ");      
            number= int.Parse(Console.ReadLine());     
            for(i=1;i<=number;i++){      
                fact=fact*i;      
            }      
            Console.Write("Factorial of " +number+" is: "+fact);    
        }
        
    }
}