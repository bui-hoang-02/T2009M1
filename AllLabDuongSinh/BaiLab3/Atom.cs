using System;
using System.Collections.Generic;

namespace AllLabDuongSinh.BaiLab3
{
    public class Atom
    {
        public int number { get; set; }
        public string symbol { get; set; }
        public string name { get; set; }
        public double weight { get; set; }

        private List<Atom> _listAtomic = new List<Atom>();
        
        public bool accepts()
        {
            var atom = new Atom();
            Console.WriteLine("Please enter atomic number.");
            atom.number = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter symbol");
            atom.symbol = Console.ReadLine();
            Console.WriteLine("Please enter full name.");
            atom.name = Console.ReadLine();
            Console.WriteLine("Please enter atomic weight.");
            atom.weight = double.Parse(Console.ReadLine());
            _listAtomic.Add(atom);
            return true;
        }

        public void display()
        {
            for (int i = 0; i < _listAtomic.Count; i++)
            {
                Atom atom = _listAtomic[i];
                if (-_listAtomic.Count > 10)
                {
                    Console.WriteLine("Chỉ nhận 10 phần tử");
                    return;
                }
                else
                {
                    Console.WriteLine($"{atom.number}, {atom.symbol}, {atom.name}, {atom.weight}");
                }
                    
            }
        }
    }
}