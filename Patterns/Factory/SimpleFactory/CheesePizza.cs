using DesignPatterns.Factory.SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Resources
{
    public class CheesePizza : Pizza
    {
        public CheesePizza()
        {
            base.name = "Cheese Pizza";
            base.dough = "Regular Dough";
            base.sauce = "Marinara Sauce";

            base.toppings.Add("More Cheese");
        }
    }
}
