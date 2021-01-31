using System;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Product
    {
        public int ProdcutId { get; set; }

        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }

    }
    class Category
    {

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
