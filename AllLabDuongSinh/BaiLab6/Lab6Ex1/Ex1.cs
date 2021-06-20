using System;

namespace BaiLab6.Lab6Ex1
{
    public class Ex1
    {
        public delegate void Increment(ref int x);
        public static void Add2(ref int x)
        {
            x += 2;
        }
        
        public static void Add3(ref int x)
        {
            x += 3;
        }
        public void MenuEx1()
        {
            Increment increment = new Increment(Add2);
            increment += Add3;
            increment += Add2;
            int x = 5;
            increment(ref x);
            Console.WriteLine(x);
        }
    }
}