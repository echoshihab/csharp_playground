namespace DesignPatterns.Decorator.Starbuzz
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            this.description = "Decaf Coffe";
        }
        public override double Cost()
        {
            return 1.05;
        }
    }
}
