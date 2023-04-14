namespace DesignPatterns.Decorator.Starbuzz
{
    public abstract class  Beverage
    {
        protected string description = "Unknown Beverage";

        public string GetDescription()
        {
            return this.description;
        }

        public abstract double Cost();

    }
}
