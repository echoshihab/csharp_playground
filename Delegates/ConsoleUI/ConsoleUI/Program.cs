using System;
using DemoLibrary;

namespace ConsoleUI
{
    class Program
    {
        private static ShoppingCartModel _cart;
        static void Main(string[] args)
        {
            PopulateCartWithDemoData();

            Console.WriteLine($"The total for the cart is {_cart.GenerateTotal():C2}");
            Console.WriteLine("Please press any key to exit the application");
            Console.ReadKey();

        }

        private static void PopulateCartWithDemoData()
        {
            _cart.Items.Add(new ProductModel{ItemName = "Cereal", Price = 3.63M});
            _cart.Items.Add(new ProductModel{ItemName = "Milk", Price = 2.95M});
            _cart.Items.Add(new ProductModel{ItemName = "Strawberries", Price = 7.51M});
            _cart.Items.Add(new ProductModel{ItemName = "Blueberries", Price = 8.84M});

        }
    }
}
