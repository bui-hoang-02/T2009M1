using System;

namespace AllLabDuongSinh.BaiLab5
{
    public class MenuMain
    {
        public void MenuCustomer()
        {
            while (true)
            {
                Console.WriteLine("Which item would you like to order? 1: Grocery goods; 2: Bakery products ");
                int choice = int.Parse(Console.ReadLine());
                Order order = new Order();
                switch (choice)
                {
                    case 1:
                        order.Ord_grocery();
                        Console.WriteLine("You have chosen to buy the product at the grocery store");
                        break;
                    case 2:
                        order.Ord_bakery();
                        Console.WriteLine("You have chosen to buy products at the bakery shop");
                        break;
                }
            }
        }
    }
}