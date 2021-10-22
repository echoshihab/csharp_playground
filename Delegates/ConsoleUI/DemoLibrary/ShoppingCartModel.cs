using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;

namespace DemoLibrary
{
    public class ShoppingCartModel
    {

        public delegate void DisplayTotalBeforeDiscount(decimal total);

        public List<ProductModel> Items { get; set; } = new List<ProductModel>();

        public decimal GenerateTotal(DisplayTotalBeforeDiscount displayTotalBeforeDiscount,
            Func<List<ProductModel>, decimal, decimal> calculateDiscountedTotal,
            Action<string> signalMethodExecution)
        {
            decimal subTotal = Items.Sum(x => x.Price);

            displayTotalBeforeDiscount(subTotal);

            signalMethodExecution("Generate total method is now executing");
            return calculateDiscountedTotal(Items, subTotal);

        }

    }
}