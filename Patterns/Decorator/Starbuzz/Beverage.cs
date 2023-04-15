namespace DesignPatterns.Decorator.Starbuzz
{
    public abstract class  Beverage
    {
        protected string description = "Unknown Beverage";

        public virtual string GetDescription()
        {
            return this.description;
        }

        public abstract double Cost();

    }
}
