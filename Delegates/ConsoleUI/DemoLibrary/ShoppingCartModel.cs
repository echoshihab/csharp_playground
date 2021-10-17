using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace DemoLibrary
{
    public class ShoppingCartModel
    {


        public List<ProductModel> Items { get; set; } 

        public decimal GenerateTotal()
        {
            decimal subTotal = Items.Sum(x => x.Price);

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
