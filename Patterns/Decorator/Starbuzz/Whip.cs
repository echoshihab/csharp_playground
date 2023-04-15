namespace DesignPatterns.Decorator.Starbuzz
{
    public class Whip : CondimentDecorator
    {
        private Beverage beverage;
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return .10 + beverage.Cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Whip";
        }
    }
}
