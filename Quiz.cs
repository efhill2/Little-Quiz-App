using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Little_Quiz_App
{
    internal class Quiz
    {
        private Question[] _questions;
        private int _score;

        public Quiz(Question[] questions)
        {
            this._questions = questions;
            _score = 0;
        }

        public void StartQuiz()
        {
            Console.WriteLine("Welcome! Try your best, have fun!");
            int questionNumber = 1; // Display question number

            foreach (Question question in _questions)
            {
                Console.WriteLine($"Question {questionNumber++}: ");
                DisplayQuestions(question);
                int userChoice = GetUserChoice();

                if (question.IsChoiceCorrect(userChoice))
                {
                    Console.WriteLine("Correct");
                    _score++;
                }
                else
                {
                    Console.WriteLine($"Wrong! Correct Answer = {question.Answers[question.CorrectAnswer]}");
                }

            }
            DisplayResults();

        }
        
        private void DisplayQuestions(Question question)
        {
            //Formatting and displaying question 
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("----------Question----------");
            Console.ResetColor();
            Console.WriteLine(question.QuestionText);

            //iterating though the answers and adding light formatting
            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow; // Changing text color 
                Console.WriteLine(" ");
                Console.WriteLine(i + 1); // Adding numbers in front and adjusting for 0 indexed array
                Console.ResetColor(); // resets text color 
                Console.WriteLine($". {question.Answers[i]}");
            }

            if (GetUserChoice() == question.CorrectAnswer)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }

        }

        private void DisplayResults()
        {
            //Formatting and displaying results 
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("----------Results----------");
            Console.ResetColor();

            Console.WriteLine($"Your Score is: {_score} out of {_questions.Length}");

            double percentage = _score / _questions.Length;

            if (percentage >= 0.8)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Excellent Work");
            }
            else if (percentage >= 0.5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Great Effort");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You Tried, I guess");
            }
            Console.ResetColor ();

        }

        private int GetUserChoice()
        {
            Console.WriteLine("Enter your answer (number): ");

            string input = Console.ReadLine();
            int choice = 0;

            while (!int.TryParse(input, out choice) || choice < 1 || choice > 4 )
            {
                Console.WriteLine("Invalid Choice! Chose from the options displayed");
                input = Console.ReadLine();
            }

            return choice - 1; // adjusting for 0 indexed array
        }

    }
}
