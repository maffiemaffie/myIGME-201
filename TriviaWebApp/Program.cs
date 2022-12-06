using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using System.Net;
using System.IO;
using System.Web;

namespace TriviaWebApp
{
    class TriviaResult
    {
        public string category;
        public string type;
        public string difficulty;
        public string question;
        public string correct_answer;
        public List<string> incorrect_answers;
    }
    class Trivia
    {
        public int response_code;
        public List<TriviaResult> results;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string url = null;
            string s = null;

            HttpWebRequest request;
            HttpWebResponse response;
            StreamReader reader;

            url = "https://opentdb.com/api.php?amount=1&type=multiple";

            request = (HttpWebRequest)WebRequest.Create(url);
            response = (HttpWebResponse)request.GetResponse();
            reader = new StreamReader(response.GetResponseStream());
            s = reader.ReadToEnd();
            reader.Close();

            Trivia trivia = JsonConvert.DeserializeObject<Trivia>(s);
            TriviaResult result = trivia.results[0];

            for (int i = 0; i < result.incorrect_answers.Count; ++i)
            {
                result.incorrect_answers[i] = HttpUtility.HtmlDecode(result.incorrect_answers[i]);
            }

            Console.WriteLine(HttpUtility.HtmlDecode(result.question) + " (enter the bullet number)");

            List<string> answers = new List<string>();
            answers.Add(result.correct_answer);

            foreach (string answer in result.incorrect_answers)
            {
                answers.Add(answer);
            }

            Random random = new Random();
            int correctIndex = -1;
            for (int i = answers.Count; i > 0; i--)
            {
                int nRandom = random.Next(answers.Count);
                Console.WriteLine(5 - i + ". " + answers[nRandom]);

                answers.RemoveAt(nRandom);

                if (nRandom == 0 && correctIndex == -1) correctIndex = 5 - i;
            }

            while(true)
            {
                string userAnswer = Console.ReadLine().Substring(0, 1);
                if (Char.IsDigit(userAnswer.ToCharArray()[0]))
                {
                    int nUserAnswer = Int32.Parse(userAnswer);
                    if (nUserAnswer > 0 && nUserAnswer <= result.incorrect_answers.Count + 1)
                    {
                        if (nUserAnswer == correctIndex) Console.WriteLine("That's Correct!");
                        else Console.WriteLine("Sorry, the correct answer was " + result.correct_answer);

                        break;
                    }
                }
            }
            
        }
    }
}
