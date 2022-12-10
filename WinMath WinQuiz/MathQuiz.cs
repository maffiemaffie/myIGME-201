using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WinMath_WinQuiz
{
    public static class MathQuiz
    {
        public enum Difficulty
        {
            EASY,
            MEDIUM,
            HARD
        }

        private static string name;
        private static int questions;
        private static int limit;
        private static Difficulty difficulty;

        private static int correct;
        private static int maxRange;

        public static void Start()
        {
            SetupForm setupForm = new SetupForm();
            setupForm.goButton.Click += new EventHandler((sender, e) => {
                Console.WriteLine(setupForm.Name);
                Setup(setupForm.PlayerName, setupForm.Questions, setupForm.Limit, setupForm.Diff);
            });

            Application.Run(setupForm);
        }

        private static void Setup(string name, int questions, int limit, Difficulty diff)
        {
            // store user name
            MathQuiz.name = name;

            // string and int of # of questions
            MathQuiz.questions = questions;

            // int time limit
            MathQuiz.limit = limit;

            // string and base value related to difficultys
            difficulty = diff;
            maxRange = 0;

            // constant for setting difficulty with 1 variable
            const int MAX_BASE = 10;

            // if they choose easy, then set nMaxRange = MAX_BASE, unless myName == "David", then set difficulty to hard
            // if they choose medium, set nMaxRange = MAX_BASE * 2
            // if they choose hard, set nMaxRange = MAX_BASE * 3
            switch (difficulty)
            {
                case Difficulty.EASY:
                    maxRange = MAX_BASE;
                    if (name.ToLower() == "david")
                    {
                        goto case Difficulty.HARD;
                    }
                    break;

                case Difficulty.MEDIUM:
                    maxRange = MAX_BASE * 2;
                    break;

                case Difficulty.HARD:
                    maxRange = MAX_BASE * 3;
                    break;
            }

            // question and # correct counters
            correct = 0;

            // ask each question
            for (int q = 0; q < questions; ++q)
            {
                AskQuestion(q + 1);
            }

            // output how many they got correct and their score
            EndForm endForm = new EndForm(correct, questions);
            endForm.ShowDialog();
        }

        private static void AskQuestion(int q)
        {
            // operator picker
            int nOp = 0;

            // operands and solution
            int val1 = 0;
            int val2 = 0;
            double dAnswer = 0; // answer could be double

            // seed the random number generator
            Random rand = new Random();

            // generate a random number between 0 inclusive and 4 exclusive to get the operation
            nOp = rand.Next(0, 4); // 4 = division

            // if either argument is 0, pick new numbers
            do
            {
                val1 = rand.Next(0, maxRange) + maxRange;
                val2 = rand.Next(0, maxRange);
            } while (val1 == 0 || val2 == 0);


            // if( nOp == 0 )
            // {
            //     nAnswer = val1 + val2;
            //     sQuestions = $"Question #{nCntr + 1}: {val1} + {val2} => ";
            // }
            // else if( nOp == 1 )
            // {
            //     nAnswer = val1 - val2;
            //     sQuestions = $"Question #{nCntr + 1}: {val1} - {val2} => ";
            // }
            // else
            // {
            //     nAnswer = val1 * val2;
            //     sQuestions = $"Question #{nCntr + 1}: {val1} * {val2} => ";
            // }

            string question = "";
            // if nOp == 0, then addition
            // if nOp == 1, then subtraction
            // if nOp == 2, then multiplication
            // if nOp == 3, then division
            switch (nOp)
            {
                case 0:
                    dAnswer = val1 + val2;
                    question = $"{val1} + {val2} => ";
                    break;
                case 1:
                    dAnswer = val1 - val2;
                    question = $"{val1} - {val2} => ";
                    break;
                case 2:
                    dAnswer = val1 * val2;
                    question = $"{val1} * {val2} => ";
                    break;
                case 3:
                    dAnswer = (double)val1 / val2;
                    dAnswer = Math.Round(dAnswer, 2);
                    question = $"(round to 2 decimal places) {val1} / {val2} => ";
                    break;
                default:
                    break;
            }

            QuestionForm questionForm = new QuestionForm(name, question, dAnswer, q, limit);
            questionForm.FormClosing += new FormClosingEventHandler((sender, e) =>
            {
                if (((QuestionForm)sender).correct) correct++;
            });

            questionForm.ShowDialog();
        }
    }
}
