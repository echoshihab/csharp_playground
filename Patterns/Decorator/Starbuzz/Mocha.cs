﻿namespace DesignPatterns.Decorator.Starbuzz
{
    public class Mocha : CondimentDecorator
    {
        private Beverage beverage;
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override double Cost()
        {
            return .20 + beverage.Cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Mocha";
        }
    }
}
