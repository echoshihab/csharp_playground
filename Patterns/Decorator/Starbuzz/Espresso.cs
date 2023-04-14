using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Starbuzz
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            this.description = "Espresso";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}
