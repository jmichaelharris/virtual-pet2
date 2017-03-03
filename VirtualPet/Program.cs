using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VirtualPet
{
    public class Program
    {

        static void Main(string[] args)
        {

            string food = string.Empty;
            string water = string.Empty;
            string play = string.Empty;
            VirtualPet Godzooky = new VirtualPet();

            Random rnd = new Random();
            int hungerLevel = rnd.Next(1, 17);
            int thirstLevel = rnd.Next(1, 18);
            int boredomLevel = rnd.Next(1, 18);

            Console.WriteLine("Welcome to Michael's VirtualPet Project");
            Console.WriteLine(" Hi, I'm Godzilla's kid, {0} ", Godzooky.name, "lets have fun");

            int n = 10;
            int results = 1;
            while (true)
            {
                results *= n;
                n--;
          
                {
                int result = Environment.TickCount & Int32.MaxValue;
                Console.WriteLine("TickCount: {0}", result);
                }

                
                Console.WriteLine(" choose 0 Pet Option, it will pause the Virtual Pet ");
                Console.WriteLine(" choose 1 Pet Option, it will feed {0} ", Godzooky.Name);
                Console.WriteLine(" choose 2 Pet Option, it will give {0} some water", Godzooky.Name);
                Console.WriteLine(" choose 3 Pet Option,{0} will talk to you", Godzooky.Name);
                Console.WriteLine(" choose 4 Pet Option, you can play with {0} ", Godzooky.Name);
                Console.WriteLine(" choose 5 Pet Option, you can quit the program " );
                Console.WriteLine(" TYPE your Pet Option as a number 0, 1, 2, 3, 4 or, 5 ");
                int petOptions = int.Parse(Console.ReadLine());
   

                switch (petOptions)
                {
                case 0:
                    Console.WriteLine("OK, I'm gonna take a nap ");
                    Thread.Sleep(0);
                    break;

                case 1:
                     Console.WriteLine("You fed {0} ", Godzooky.Name);
                     Godzooky.Eat(food);
                    break;

                case 2:
                     Console.WriteLine("{0} drank some water ", Godzooky.Name);
                     Godzooky.Drink(water);
                    break;

                case 3:
                     Console.WriteLine(" {0}spoke ", Godzooky.Name);
                     Godzooky.Speak();
                    break;

                case 4:
                     Console.WriteLine(" You played with {0} ", Godzooky.Name);
                     Godzooky.Boredom(play);
                    break;
                case 5:
                     Console.WriteLine(" You're gonna miss out on a lot of fun, goodbye ");
                     Environment.Exit(0);
                    break;

                default:

                    Console.WriteLine(" Invalid selection ");
                    Console.WriteLine(" Please choose Pet Option 0, 1, 2, 3, 4, or, 5 ");
                    break;
                    
               }
       
           }
        }
    }
}
