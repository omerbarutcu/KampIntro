using System;

namespace Metods
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.İnfo = "Amasya elması";

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.İnfo = "Diyarbakır karpuzu";

            Product[] products = new Product[] {product1,product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.İnfo);
            }

            Console.WriteLine("-------------------Metodlar--------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);

            sepetManager.Add2("Armut","Yeşil Armut",12);
            
        }
    }
}
