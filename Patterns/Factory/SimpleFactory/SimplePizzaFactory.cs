using DesignPatterns.Factory.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.SimpleFactory
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type) =>  type switch
            {
                "cheese" => new CheesePizza(),
                "veggie" => new VeggiePizza(),
                _ => throw new ArgumentOutOfRangeException("Unexpected pizza type")
            };
        
    }
}
