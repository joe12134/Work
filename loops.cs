using System;

using System.Threading.Tasks;

namespace iteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Loop exercises 1
            for (int x = 1; x <= 10; x++)
            {
                Console.WriteLine(x);
            }
            */

            /*
            //Loop exercises 2
            for (int x = 20; x >=1; x--)
            {
                Console.WriteLine(x);

            }
            */


            /*
            //Loop exercises 3


            string word = Console.ReadLine();
            int timesOutputted = int.Parse(Console.ReadLine());

            for (int i = 1; i<=timesOutputted; i++)
            {
                Console.WriteLine(word);
            }
            */

            /*
            //Loop exercise 4
             string GetInput()
            {
                return Console.ReadLine();
            }

            do
            {
                Console.WriteLine("Enter capitcla city of England");
            } while (GetInput().ToLower() != "london");
            */

            /*
            // loop exercise 6
            Random rand = new Random();
            int num = rand.Next(10);

            Console.WriteLine(num);

            bool GetGuess()
            {
                int guess = int.Parse(Console.ReadLine());
                Console.WriteLine(guess);
                if (guess == num)
                {
                    return true;

                } else
                {
                    return false;
                }

               
            }

            int attempts = 0;
            do
            {   
                
                Console.WriteLine("Guess random num between 1-10");
               
                attempts++;

            } while (!GetGuess());
            Console.WriteLine("Correct took: " + attempts + " attempt(s).");
            */

            /*
            //Colour screen

            Random random = new Random();
            
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Task.Delay(1);
                Console.Clear();
                
                Console.BackgroundColor = ConsoleColor.Black;
                Task.Delay(1);
                Console.Clear();
                
            }
            */

            /* 
            //Loop thing
            for (int i = 1; i<= 7; i++)
            {
                string thing = "";
                for (int j = i; j > 0; j--)
                {
                    thing = j + thing;

                }
                int starsRequired = 7-i;

                thing = thing + string.Concat(Enumerable.Repeat("*", starsRequired));
                Console.WriteLine(thing);
            }
            */

            /*
            Console.WriteLine("Enter Check Prime Number");

            long input = long.Parse(Console.ReadLine());

            for (long i = 2; i <= Math.Sqrt(input); i++)
            {
                if (input % i == 0)
                {
                    Console.WriteLine("Not Prime");
                    return;
                }
            }
            Console.WriteLine("Prime.");
            */
        }
    }
}
