using System;
using DemoLibrary;

namespace ConsoleUI
{
    class Program
    {
        private static ShoppingCartModel _cart = new ShoppingCartModel();

        
        static void Main(string[] args)
        {
            PopulateCartWithDemoData();

            Console.WriteLine($"The Discounted total for the cart is {_cart.GenerateTotal(ShowTotalBeforeDiscount):C2}");
            Console.WriteLine("Please press any key to exit the application");
            Console.ReadKey();

        }

        private static void ShowTotalBeforeDiscount(decimal total)
        {
            Console.WriteLine($"Total before discount: {total:C2}");
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
