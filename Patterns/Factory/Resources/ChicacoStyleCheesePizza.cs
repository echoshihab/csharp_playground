using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Factory.SimpleFactory;

namespace DesignPatterns.Factory.Resources
{
    public class ChicacoStyleCheesePizza : Pizza
    {
        public ChicacoStyleCheesePizza()
        {
            base.name = "Chicaco Style Deep Dish Cheese Pizza";
            base.dough = "Extra thick Crust Dough";
            base.sauce = "Plum Tomato Sauce";

            base.toppings.Add("Shredded Mozzarella Cheese");
        }

    }
}
