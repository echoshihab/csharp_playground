using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Starbuzz
{
    /// <summary>
    /// Represents the decorator demo
    /// </summary>
    public static class DecoratorDemo
    {
        /// <summary>
        /// Executes the star buzz cofee decorator demo
        /// </summary>
        public static void StarbuzzCoffeeDecoratorDemo()
        {
            // Espresso
            Beverage espresso = new Espresso();
            Console.WriteLine($"{espresso.GetDescription()} ${espresso.Cost()}");

            // Double Mocha with whip
            Beverage  beverage = new DarkRoast();
            beverage = new Mocha(beverage);            
            beverage = new Mocha(beverage);
            beverage = new Whip(beverage);

            Console.WriteLine($"{beverage.GetDescription()} ${beverage.Cost()}");









        }

    }
}
