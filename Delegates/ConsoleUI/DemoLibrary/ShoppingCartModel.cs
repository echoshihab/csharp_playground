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

        public decimal GenerateTotal(DisplayTotalBeforeDiscount displayTotalBeforeDiscount)
        {
            decimal subTotal = Items.Sum(x => x.Price);

            displayTotalBeforeDiscount(subTotal);

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
