using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Factory.SimpleFactory;

namespace DesignPatterns.Factory.Resources
{
    public class NyStyleCheesePizza : Pizza
    {
        public NyStyleCheesePizza()
        {
            base.name = "NY Style Sauce and Cheese Pizza";
            base.dough = "Thin Crust Dough";
            base.sauce = "Marinara Sauce";

            base.toppings.Add("Grated Reggiano Cheese");
        }
    }
}
