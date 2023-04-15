namespace DesignPatterns.Decorator.Starbuzz
{
    /// <summary>
    /// Represents a Decaf Class
    /// </summary>
    public class Decaf : Beverage
    {
        /// <summary>
        /// Decaf Constructor
        /// </summary>
        public Decaf()
        {
            this.description = "Decaf Coffe";
        }

        /// <summary>
        /// cost of item
        /// </summary>
        /// <returns>cost</returns>
        public override double Cost()
        {
            return 1.05;
        }
    }
}
