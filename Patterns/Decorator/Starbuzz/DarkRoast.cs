namespace DesignPatterns.Decorator.Starbuzz
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            this.description = "Dark Roast Coffee";
        }
        public override double Cost()
        {
            return .99;
        }
    }
}
