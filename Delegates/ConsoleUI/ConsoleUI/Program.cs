using System;
using System.Collections.Generic;
using DemoLibrary;

namespace ConsoleUI
{
    class Program
    {
        private static ShoppingCartModel _cart = new ShoppingCartModel();

        
        static void Main(string[] args)
        {
            PopulateCartWithDemoData();

            Console.WriteLine($"The Discounted total for the cart is {_cart.GenerateTotal(ShowTotalBeforeDiscount, CalculateDiscount, AlertMethodCompletion):C2}");
            Console.WriteLine("Please press any key to exit the application");
            Console.ReadKey();

        }

        private static void AlertMethodCompletion(string message)
        {
            Console.WriteLine(message);
        }

        //this just has to match the method signature of delegate method declared in shopping cart model
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


        private static decimal CalculateDiscount(List<ProductModel> items, decimal subTotal)
        {
            return subTotal switch
            {
                > 100 => subTotal * 0.80M,
                > 50 => subTotal * 0.85M,
                > 10 => subTotal * 0.90M,
                _ => subTotal
            };
        }
    }
}
