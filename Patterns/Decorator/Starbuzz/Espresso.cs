namespace DesignPatterns.Decorator.Starbuzz
{
    /// <summary>
    /// Represents an Esspresso
    /// </summary>
    public class Espresso : Beverage
    {
        /// <summary>
        /// Espresso Constructor
        /// </summary>
        public Espresso()
        {
            this.description = "Espresso";
        }

        /// <summary>
        /// Cost of item
        /// </summary>
        /// <returns>Cost</returns>
        public override double Cost()
        {
            return 1.99;
        }
    }
}
