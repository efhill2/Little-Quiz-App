// See https://aka.ms/new-console-template for more information 

using Little_Quiz_App;

Question[] questions = new Question[]
{
    new Question("What is the capital of Michigan?", // Question Text
    new string[] {"Detroit", "Ann Arbor", "Lansing"}, // Answer Array
    2), // Correct Answer

    new Question("What is 2 + 2", // Question Text
    new string[] {"9", "4", "5"}, // Answer Array
    1), // Correct Answer

    new Question("What color do you get by mixing blue and yellow?", // Question Text
    new string[] {"Green", "White", "Red"}, // Answer Array
    0) // Correct Answer
};

Quiz myQuiz = new Quiz(questions);

myQuiz.StartQuiz();

Console.ReadLine();
