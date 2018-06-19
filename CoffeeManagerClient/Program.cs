using ContentType;
using System;

namespace CoffeeManagerClient
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeAPI.CoffeeServiceContractClient server = new CoffeeAPI.CoffeeServiceContractClient();

            Console.WriteLine("==== Welcome to Coffee Manager ====");

            ConsoleKeyInfo cki;
            Console.TreatControlCAsInput = true;
            Console.WriteLine("Press <Esc> to exit... ");

            Console.WriteLine("Press <1> to create a coffee... ");
            do
            {
                cki = Console.ReadKey();
                if(cki.Key == ConsoleKey.D1 || cki.Key == ConsoleKey.NumPad1)
                {
                    Coffee coffee = new Coffee();
                    coffee.Id = 0;
                    coffee.Title = "São Braz";
                    coffee.Description = "Sabor forte e encorpado";
                    coffee.Date = DateTime.UtcNow;

                    Console.WriteLine($" : The coffee is ready");
                    Console.WriteLine($"Title : {coffee.Title}");
                    Console.WriteLine($"Description : {coffee.Description}");
                    Console.WriteLine($"Fabrication : {coffee.Date}");

                    server.SaveCoffee(coffee);
                    Coffee pCoffee = server.GetCoffee();

                    Console.WriteLine("- Server Confirmation - ");
                    Console.WriteLine($"- Coffee Saved - : {pCoffee.Title}");

                    Console.ReadKey();
                }

                
            } while (cki.Key != ConsoleKey.Escape);
        }
    }
}
