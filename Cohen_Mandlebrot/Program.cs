using System;

namespace Mandelbrot
{
    /// <summary>
    /// This class generates Mandelbrot sets in the console window!
    /// </summary>


    class Class1
    {
        /// <summary>
        /// This is the Main() method for Class1 -
        /// this is where we call the Mandelbrot generator!
        /// </summary>
        /// <param name="args">
        /// The args parameter is used to read in
        /// arguments passed from the console window
        /// </param>

        [STAThread]
        static void Main(string[] args)
        {
            double imagMax = 1.2;
            double imagMin = -1.2;
            double realMax = 1.77;
            double realMin = -.6;

            bool isNext;


            Console.WriteLine("Hello! Let's get some bounds first :3");
            Console.WriteLine("Please enter the lower bound for the imaginary axis (typically around " + imagMin + "):");
            isNext = false;
            while(!isNext)
            {
                try
                {
                    imagMin = Convert.ToDouble(Console.ReadLine());
                    isNext = true;
                }
                catch
                {
                    Console.WriteLine("Uh oh @w@ something doesn't look right... (Remember that we're looking for a number ^-^)");
                    Console.WriteLine("Let's try that again:");
                };
            }

            Console.WriteLine("Perfect! Now the upper bound for the imaginary axis (typically around " + imagMax + "):");
            isNext = false;
            while (!isNext)
            {
                try
                {
                    imagMax = Convert.ToDouble(Console.ReadLine());
                    if (imagMax <= imagMin)
                    {
                        Console.WriteLine("Uh oh @w@ something doesn't look right... (Remember that your upper bound should be greater than your lower bound ^-^)");
                        Console.WriteLine("Let's try that again:");
                        continue;
                    }
                    isNext = true;
                }
                catch
                {
                    Console.WriteLine("Uh oh @w@ something doesn't look right... (Remember that we're looking for a number ^-^)");
                    Console.WriteLine("Let's try that again:");
                };
            }

            Console.WriteLine("Great! Now the lower bound for the real axis (typically around " + realMin + "):");
            isNext = false;
            while (!isNext)
            {
                try
                {
                    realMin = Convert.ToDouble(Console.ReadLine());
                    isNext = true;
                }
                catch
                {
                    Console.WriteLine("Uh oh @w@ something doesn't look right... (Remember that we're looking for a number ^-^)");
                    Console.WriteLine("Let's try that again:");
                };
            }

            Console.WriteLine("Awesome! Just need the upper bound for the real axis (typically around " + realMax + "):");
            isNext = false;
            while (!isNext)
            {
                try
                {
                    realMax = Convert.ToDouble(Console.ReadLine());
                    if (realMax <= realMin)
                    {
                        Console.WriteLine("Uh oh @w@ something doesn't look right... (Remember that your upper bound should be greater than your lower bound ^-^)");
                        Console.WriteLine("Let's try that again:");
                        continue;
                    }
                    isNext = true;
                }
                catch
                {
                    Console.WriteLine("Uh oh @w@ something doesn't look right... (Remember that we're looking for a number ^-^)");
                    Console.WriteLine("Let's try that again:");
                };
            }

            Console.WriteLine("Everything looks good, thank you ^-^");
            double imagStep = (imagMax - imagMin) / 47; // include min and max value
            double realStep = (realMax - realMin) / 79; // include min and max value

            double realCoord, imagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;
            for (imagCoord = imagMax; imagCoord >= imagMin; imagCoord -= imagStep)
            {
                for (realCoord = realMin; realCoord <= realMax; realCoord += realStep)
                {
                    iterations = 0;
                    realTemp = realCoord;
                    imagTemp = imagCoord;
                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                           - realCoord;
                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                }
                Console.Write("\n");
            }

        }
    }
}
