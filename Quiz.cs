using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp;

public class Quiz
{
    public static int NumberOfRealisedTest = 0;
    public List<List<string>> QuestionsAndAnswer { get; set; }
    public int SuccessPercontage { get; set; }

    public Quiz()
    {
        NumberOfRealisedTest++;
        QuestionsAndAnswer = new List<List<string>>(10) ;
    }

    public bool CheckAnswer(int QuestionNumber, string CandidateAnswer)
    {
        if (CandidateAnswer == QuestionsAndAnswer[QuestionNumber][5])
            return true;
        else
            return false;

    }

    public void StartQuiz(User user)
    {
        Console.WriteLine("Hello User ! \nPlease entre your Firstname");
        user.FirstName = Console.ReadLine();
        Console.WriteLine("please enter your Lastnamee");
        user.LastName = Console.ReadLine();

        Console.WriteLine("Welcome to the Quiz {0} {1}, your will be asked 10 QCM and you have to choose one answer! \n Ready to start? Let's go!", user.FirstName, user.LastName);
        for (var i = 0; i < 10; i++)
        {
            //Console.WriteLine("Question number {0} : ", i+1);
            Console.WriteLine(QuestionsAndAnswer[i][0]); //[i,0]);

            for (var j = 1; j <=4; j++)
            {
                Console.WriteLine("{0} :  {1}", j, QuestionsAndAnswer[i][j]);
            }

            Console.WriteLine("choose the correct answer by typing 1 or 2 or 3 or 4 ");
            string? EntredAnswer = Console.ReadLine();

            if (CheckAnswer(i, EntredAnswer))
            {
                user.IndexOfCorrectAnswer.Add(i);
                user.Score++;
            }

        }
        Console.WriteLine("End of questions");
    }

    public void UpdateQuestion()
    {
      
            Console.WriteLine("Enter the question's number that you would like to update");
            int IndexQuestionEdit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the new question");
            string? NewQuestion = Console.ReadLine();
             QuestionsAndAnswer[IndexQuestionEdit][0] = NewQuestion;

            Console.WriteLine("Enter the 4 possible answers");
            for (int i = 0; i < 4; i++)
            {
                QuestionsAndAnswer[IndexQuestionEdit][i] = Console.ReadLine();
            }
            Console.WriteLine("Whitch one is the correct answer? enter 1 or 2 or 3 or 4");
            QuestionsAndAnswer[IndexQuestionEdit][4] = Console.ReadLine();

            Console.WriteLine("The question {0} was updated!",IndexQuestionEdit);

    }

    public void DisplayQuizResult(User user)
    {
        Console.WriteLine("Here is your correct Answers");
        foreach (var correctanswer in user.IndexOfCorrectAnswer)
        {

            Console.WriteLine("Question {0} : ", correctanswer, QuestionsAndAnswer[correctanswer][0]);
            Console.WriteLine("Your Answer {0} is correct ", QuestionsAndAnswer[correctanswer][5]);
        }
        Console.WriteLine("Your Score is {0} / {1} ", user.Score, QuestionsAndAnswer.Count());

    }
}
