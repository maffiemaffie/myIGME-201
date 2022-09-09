using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Author: Maffie Cohen
// Purpose: Mad Libs game
// Restrictions: 
namespace Cohen_PE7
{
    // Purpose: 
    // Restrictions: 
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to play Mad Libs? (yes/no)");
            bool isStart = false;
            while (true)
            {
                string answer = Console.ReadLine().ToLower();
                if (answer.Equals("yes"))
                {
                    isStart = true;
                    break;
                }
                if (answer.Equals("no"))
                {
                    isStart = false;
                    break;
                }
                Console.WriteLine("I don't understand, please answer yes or no");
            }

            if (isStart)
            {
                StreamReader sr = null;
                int count = 0;

                try
                {
                    sr = new StreamReader("C:\\templates\\MadlibsTemplate.txt");
                    while (sr.ReadLine() != null)
                    {
                        count++;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error with file: " + e.Message);
                }
                finally
                {
                    if (sr != null)
                        sr.Close();
                }

                string[] lines = new string[count];
                sr = null;
                try
                {
                    sr = new StreamReader("C:\\templates\\MadlibsTemplate.txt");
                    for (int i = 0; i < count; i++)
                    {
                        lines[i] = sr.ReadLine();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error with file: " + e.Message);
                }
                finally
                {
                    if (sr != null)
                        sr.Close();
                }

                Console.WriteLine("Please pick a story (choose a number between 1 and " + count + ")");
                int story = 0;
                while (true)
                {
                    try
                    {
                        story = Convert.ToInt32(Console.ReadLine());
                        if (story > 0 && story <= count)
                        {
                            break;
                        }
                        Console.WriteLine("I don't think I have that one, can we try another? (Hint: your number should be between 1 and " + count + ")");
                    }
                    catch
                    {
                        Console.WriteLine("I don't think I have that one, can we try another? (Hint: I was expecting an integer value)");
                    }
                }

                string resultString = "";
                foreach (string word in lines[story - 1].Split(' ')) // 1-6 to 0-5
                {
                    switch (word.ToCharArray()[0])
                    {
                        case '\\':
                            resultString += '\n';
                            break;
                        case '{':
                            char[] promptChars = word.ToCharArray();

                            bool open = false;
                            string promptParsed = "";
                            string tag = "";

                            foreach (char ch in promptChars)
                            {
                                switch (ch)
                                {
                                    case '{':
                                        open = true;
                                        break;
                                    case '}':
                                        open = false;
                                        break;
                                    // case '_':  // alternative to the Replace() later on
                                    //    promptParsed += promptChars[i];
                                    //    break;
                                    default:
                                        if (open)
                                            promptParsed += ch;
                                        else
                                            tag += ch;
                                        break;
                                }
                            }

                            Console.WriteLine("Please enter a " + promptParsed.Replace('_', ' '));
                            resultString += Console.ReadLine() + tag + ' ';
                            break;
                        case '.':
                            resultString = resultString.Substring(0, resultString.Length - 1) + word + ' ';
                            break;
                        default:
                            resultString += word + ' ';
                            break;
                    }
                }

                Console.WriteLine(resultString);
            }

            
        }
    }
}
