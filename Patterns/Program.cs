using DesignPatterns.Decorator.Starbuzz;
using DesignPatterns.Observer;

Console.WriteLine(@"Enter a number to display a specific pattern demo:
1  - Observer Implementation (Push)
2  - Observer Implementation (Pull)
3  - Decorator Implementation
"
);

var validInput = int.TryParse(Console.ReadLine(), out int result);

if (!validInput)
{
    Console.WriteLine("Input is invalid");
} 
else
{
    switch (result)
    {
        case 1:
            ObserverDemo.ObserverPushImplementation();
            break;
        case 2:
            ObserverDemo.ObserverPullImplementation();
            break;
        case 3:
            DecoratorDemo.StarbuzzCoffeeDecoratorDemo();
            break;
        default:
            Console.WriteLine("Invalid Entry");
            break;
    }        
}



