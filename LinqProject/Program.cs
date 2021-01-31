using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category {CategoryId=1,CategoryName="Bilgisayar"},
                new Category {CategoryId=2,CategoryName="Telefon"},
            };

            List<Product> products = new List<Product> {
            new Product  {ProdcutId =1,CategoryId=1,ProductName="Asus",
            QuantityPerUnit ="32 Gb Ram",UnitInStock =100,UnitPrice=5000
            },
            new Product  {ProdcutId =2,CategoryId=1,ProductName="HP",
            QuantityPerUnit ="8 Gb Ram",UnitInStock =10,UnitPrice=7500
            },
            new Product  {ProdcutId =3,CategoryId=1,ProductName="Acer",
            QuantityPerUnit ="4 Gb Ram",UnitInStock =20,UnitPrice=3000
            },
            new Product  {ProdcutId =4,CategoryId=2,ProductName="Samsung",
            QuantityPerUnit ="4 Gb Ram",UnitInStock =50,UnitPrice=7000
            },
            new Product  {ProdcutId =5,CategoryId=2,ProductName="APPLE",
            QuantityPerUnit ="8 Gb Ram",UnitInStock =0,UnitPrice=10000
            },
            };
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitInStock > 3)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
            Console.WriteLine("-----LINQ------");
            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 3);
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }
            Console.WriteLine("----USE METHOD----");
            getProducts(products);
            Console.WriteLine("LINQ USED METHOD");
            foreach (var item in getProductsLinq(products))
            {
                Console.WriteLine(item.ProductName);
            }
        }
        static List<Product> getProducts(List<Product> products)
        {
            List<Product> filteredProduct = new List<Product>();
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitInStock > 3)
                {
                    filteredProduct.Add(product);
                }
            }
            return filteredProduct;
        }

        static List<Product> getProductsLinq(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 3).ToList();
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
