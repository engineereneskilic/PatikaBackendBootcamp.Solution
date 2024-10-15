using _4.week_2_Fieds_Methods;
using System;

namespace _4.week_2_Fieds_Methods_Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Product laptop = new Product();
            laptop.Name = "Laptop";
            laptop.Price = 10000;
            laptop.Stock = 10;

            Product phone = new Product();
            phone.Name = "Telefon";
            phone.Price = 500;
            phone.Stock = 20;

            laptop.DisplayProduct();

            phone.DisplayProduct();

            laptop.SellProduct(2);
            phone.SellProduct(5);

            laptop.RestockProduct(5);
            phone.RestockProduct(10);

            Console.ReadKey();
        }
    }
}
