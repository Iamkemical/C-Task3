using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of the Random class
            Random rand = new Random();
            Console.WriteLine("=>=>You're welcome to Iamkemical's Guessing game<=<=");
            Console.Write("Press any key to commence playing the game");
            Console.ReadKey();
            
             // Users inputs what level of difficulty they can handle
            Console.Write("\nE- Easy, M- Medium, H- Hard\nEnter your Preferred level of difficulty: ");
            string userInput = Console.ReadLine();
            if (userInput == "E")
            {
                Console.WriteLine("You've chosen the easy level, you've a maximum of 6 guesses and you're required to guess numbers between 1 to 10");
                for (int i = 0; i <= 5; i++)
                {
                    int a;
                    Console.WriteLine("\nYou have {0} chances left", a = 6 - i);
                    Console.Write("Guess a number: ");
                    int numOne = Convert.ToInt32(Console.ReadLine());
                    rand.Next(1, 11);
                    if (numOne == rand.Next(1, 11))
                    {
                        Console.WriteLine("\nYou got it right!");
                    }
                    else
                    {
                        Console.WriteLine("\nThat was wrong!");
                    }  
                }
                // If all the above conditions are not satisfied the loops breaks
                Console.WriteLine("\nGame over!");
            }
            else if (userInput == "M")
            {
                Console.WriteLine("You've chosen the medium level, you've a maximum of 4 guesses and you're required to guess numbers between 1 to 20");
                for (int i = 0; i <= 3; i++)
                {
                    int a;
                    Console.WriteLine("\nYou have {0} chances left", a = 4 - i);
                    Console.Write("Guess a number: ");
                    int numOne = Convert.ToInt32(Console.ReadLine());
                    rand.Next(1, 21);
                    if (numOne == rand.Next(1, 21))
                    {
                        Console.WriteLine("\nYou got it right!");
                    }
                    else
                    {
                        Console.WriteLine("\nThat was wrong!");
                    }
                }
                Console.WriteLine("\nGame over!");
            }
            else if(userInput == "H")
            {
                Console.WriteLine("You've chosen the hard level, you've a maximum of 3 guess and you're required to guess numbers between 1 to 50");
                for (int i = 0; i <= 2; i++)
                {
                    int a;
                    Console.WriteLine("\nYou have {0} chances left", a = 3 - i);
                    Console.Write("Guess a number: ");
                    int numOne = Convert.ToInt32(Console.ReadLine());
                    rand.Next(1, 51);
                    if (numOne == rand.Next(1, 51))
                    {
                        Console.WriteLine("\nYou got it right!");
                    }
                    else
                    {
                        Console.WriteLine("\nThat was wrong!");
                    }
                }
                Console.WriteLine("\nGame over!");
            }
            else
            {
                Console.WriteLine("\nYou've entered the wrong input, please check again!!!");
            }
        }
    }
}
