namespace DesignPatterns.Decorator.Starbuzz
{
    /// <summary>
    /// Represents a Dark Roast
    /// </summary>
    public class DarkRoast : Beverage
    {
        /// <summary>
        /// The Dark roast constructor
        /// </summary>
        public DarkRoast()
        {
            this.description = "Dark Roast Coffee";
        }
        
        /// <summary>
        /// Cost of item
        /// </summary>
        /// <returns>cost</returns>
        public override double Cost()
        {
            return .99;
        }
    }
}
