namespace DesignPatterns.Decorator.Starbuzz
{
    public class Mocha : CondimentDecorator
    {
        Beverage beverage;

        public Mocha()
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
