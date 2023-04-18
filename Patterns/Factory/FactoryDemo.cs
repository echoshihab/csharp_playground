using DesignPatterns.Factory.SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public static class FactoryPattern
    {
        public static void SimpleFactoryDemo()
        {
            var pizzaStore = new PizzaStore(new SimplePizzaFactory());

            pizzaStore.OrderPizza("cheese");
            pizzaStore.OrderPizza("veggie");
        }
    }
}
