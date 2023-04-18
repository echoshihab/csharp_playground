namespace DesignPatterns.Factory.SimpleFactory
{
    public class VeggiePizza : Pizza
    {
        public VeggiePizza()
        {
            base.name = "Veggie Pizza";
            base.dough = "Regular Dough";
            base.sauce = "Marinara Sauce";

            base.toppings.AddRange(new List<string> { "tomatoes", "jalapeno", "mushrooms" });

        }
    }
}
