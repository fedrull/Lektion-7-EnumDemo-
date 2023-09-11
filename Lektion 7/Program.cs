namespace Lektion_7
{

    enum Beverage
    {
        Coffee, 
        Tea,
        Water, 
        Soda, 
        Juice
    }


    internal class Program
    {
      
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the awsome vending machine ");
            Console.WriteLine("Wich beverage do you prefer? (coffee, Tea, Water, Soda, Juice");
            String userinput = Console.ReadLine();

            switch (userinput.ToLower())
            {
                case "coffee":
                    Respond(Beverage.Coffee);
                    break;
                case "tea":
                    Respond(Beverage.Tea);  
                    break;
                case "water":
                    Respond(Beverage.Water);
                    break;
                case "soda":
                    Respond(Beverage.Soda);
                    break;
                case "juice":
                    Respond(Beverage.Juice);
                    break;
                default:
                    Console.WriteLine("Input, the drink does not exists");
                    break;
            }

        }
    
        static void Respond(Beverage drink)
        {
            switch (drink)
            {
                case Beverage.Coffee:
                    Console.WriteLine("You ordered kaffe latte");
                        break;
                case Beverage.Tea:
                    Console.WriteLine("You ordered Tea");
                    break;
                case Beverage.Water:
                    Console.WriteLine("You ordered Water");
                    break;
                case Beverage.Soda:
                    Console.WriteLine("You ordered Soda");
                    break;
                case Beverage.Juice:
                     Console.WriteLine("You ordered Juice");
                    break;
            }
        }
    }
}