namespace DesignPatterns.Factory.SimpleFactory
{
    /// <summary>
    /// Represents a Pizza class
    /// </summary>
    public abstract class Pizza
    {
        protected string name;
        protected string dough;
        protected string sauce;
        protected List<string> toppings = new List<string>();

        /// <summary>
        /// Prepares the pizza
        /// </summary>
        public void Prepare()
        {
            Console.WriteLine($"Preparing {name}");
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine($"Adding toppings: {string.Join(" ", toppings)}");
        }

        /// <summary>
        /// Bakes the pizza
        /// </summary>
        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        /// <summary>
        /// Cuts the pizza
        /// </summary>
        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        /// <summary>
        /// Box the pizza
        /// </summary>
        public void Box()
        {
            Console.WriteLine("Place pizza in official Pizzastore Box");
        }

        /// <summary>
        /// Gets the pizza name
        /// </summary>
        /// <returns>Pizza name</returns>
        public string GetName()
        {
            return name;
        }
    }
}
