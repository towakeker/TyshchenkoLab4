using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_4_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = SetupShop();

            var user = shop.Users.First();
            var selectedProducts = shop.Products.Take(2).ToList();
            var quantities = new List<int> { 1, 2 };
            shop.PlaceOrder(user, selectedProducts, quantities);

            var filteredProducts = shop.SearchByPriceRange(200, 10000);
            DisplayFilteredProducts(filteredProducts);
        }

        static Shop SetupShop()
        {
            var shop = new Shop();

            shop.AddProduct(new Product("AirPods", 5000, "Wireless headphones", "Electronics"));
            shop.AddProduct(new Product("Video Surveillance Camera", 10000, "Panoramic", "Photo Equipment"));
            shop.AddProduct(new Product("Laptop", 40000, "Playful", "Electronics"));

            shop.AddUser(new User("user1", "12345"));
            shop.AddUser(new User("user2", "54321"));

            return shop;
        }

        static void DisplayFilteredProducts(List<Product> filteredProducts)
        {
            foreach (var product in filteredProducts)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
            }
        }
        }
    }