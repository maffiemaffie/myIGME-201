using System;
using System.Timers;

namespace RoundDelegate
{
    delegate double roundingFunction(double n, int precision);


    static internal class Program
    {
        static bool bTimeOut = false;

        static Timer gameClock;

        static void Main(string[] args)
        {
        start:

            int nQuestion = 0;
            string sAnswer = "";
            string sAgain = "";
            string sCorrect = "";
            bool bAnsweredCorrectly = false;

            Console.Write("Choose your question (1-3): ");
            while (true)
            {
                try
                {
                    nQuestion = int.Parse(Console.ReadLine());
                    if (nQuestion >= 1 && nQuestion <= 3) break;
                }
                catch
                {
                    Console.Write("\nPlease enter an integer: ");
                }
            }

            gameClock = new Timer(5000);
            gameClock.Elapsed += new ElapsedEventHandler(TimeOut);
            gameClock.Start();
            Console.WriteLine("You have 5 seconds to answer the following question:");

            switch (nQuestion)
            {
                case 1:
                    sCorrect = "black";
                    Console.WriteLine("What is your favorite color?");
                    break;

                case 2:
                    sCorrect = "42";
                    Console.WriteLine("What is the answer to life, the universe and everything?");
                    break;

                case 3:
                    sCorrect = "What do you mean? African or European swallow?";
                    Console.WriteLine("What is the airspeed velocity of an unladen swallow?");
                    break;
                default:
                    break;

            }

            sAnswer = Console.ReadLine();
            gameClock.Stop();

            if (sAnswer.Equals(sCorrect))
            {
                Console.WriteLine("Well done!");
            }
            else
            {
                Console.Write("Wrong!\t");

                Console.WriteLine("The answer is: {0}", sCorrect);
            }

            do
            {
                Console.Write("Play again? ");
                sAgain = Console.ReadLine();

                if (sAgain.ToLower().StartsWith("y")) goto start;
                else if (sAgain.ToLower().StartsWith("n")) break;
            } while (true);
        }

        static void TimeOut(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Time's up!");
            gameClock.Stop();
        }
    }
}
