using System;
using System.Collections.Generic;
using System.Text;

namespace Metods
{
    class SepetManager
    {
        public void Add(Product product) 
        {
            Console.WriteLine("Tebirkler Sepete eklendi :" + product.Name);
        }

        public void Add2(string Name,string info,double price)
        {
            Console.WriteLine("Tebirkler Sepete eklendi :" + Name);
        }
    }
}
