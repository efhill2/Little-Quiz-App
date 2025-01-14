using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Little_Quiz_App
{
    internal class Question
    {
        public string QuestionText { get; }
        public string[] Answers { get; }
        public int CorrectAnswer { get; }

        public Question(string questionText, string[] answers, int answerChoices)
        {
            QuestionText = questionText;
            Answers = answers;
            CorrectAnswer = answerChoices;
        }

        //Method to Check if the answer is correct
        public bool IsChoiceCorrect(int choice)
        {
            return CorrectAnswer == choice;
        }


    }
}
