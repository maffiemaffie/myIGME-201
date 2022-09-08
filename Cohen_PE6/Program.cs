using System;

// Author: Maffie Cohen
// Purpose: A guessing game
// Restrictions: 
namespace Cohen_PE6
{
    // Purpose: Choose a random number and give the user 8 tries to guess it
    // Restrictions:
    static class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(0, 101); // between 0 inclusive and 101 exclusive

            // Console.WriteLine(randomNumber); // debug

            bool isSucceed = false; // grammar forgone in favor of convention u_u
            for (int i = 1; i <= 8; i++) // guesses 1-8 inclusive
            {
                Console.WriteLine("Enter your guess please:");

                int guess = -1;
                bool isValid = false;
                while (!isValid)
                {
                    try
                    {
                        guess = Convert.ToInt32(Console.ReadLine());
                        if (guess >= 0 && guess <= 100)
                        {
                            isValid = true;
                            break;
                        }
                        Console.WriteLine("Hm, we're looking for a guess between 0 and 100");
                            
                    } 
                    catch
                    {
                        Console.WriteLine("Hm, we're looking for an integer");
                    }
                    Console.WriteLine("Please enter another guess:");
                }

                if (guess > randomNumber)
                {
                    Console.WriteLine("high");
                    continue;
                }
                if (guess < randomNumber)
                {
                    Console.WriteLine("low");
                    continue;
                }
                Console.WriteLine("correct");
                isSucceed = true;

                string suffix;
                switch(i) // 1st, 2nd, 3rd, etc (unneccessary but cute)
                {
                    case 1:
                        suffix = "st";
                        break;
                    case 2:
                        suffix = "nd";
                        break;
                    case 3:
                        suffix = "rd";
                        break;
                    default:
                        suffix = "th";
                        break;
                }
                Console.WriteLine("You guessed correctly on your " + i + suffix + " try!");
                break;
            }

            if (!isSucceed)
            {
                Console.WriteLine("The correct number was " + randomNumber);
            }

        }
    }
}
