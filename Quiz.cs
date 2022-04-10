using QuizApp.DeserializeQCMJson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp;

public class Quiz
{
    public static int NumberOfRealisedTest = 0;
    private QCM value = new QCM();
    public Dictionary<string, QCM> QuestionsAndAnswer { get; set; }
    public int SuccessPercontage { get; set; }

    public Quiz()
    {

        NumberOfRealisedTest++;
        QuestionsAndAnswer = QuizManagment.ReadQuestionsFromJsonFile();

    }

    //public bool CheckAnswer(int QuestionNumber, string CandidateAnswer)
    //{

    //    var ab = QuestionsAndAnswer.TryGetValue("QCM" + QuestionNumber.ToString(), out value);

    //    if (CandidateAnswer == value.GoodAnswer.ToString())
    //        return true;
    //    else
    //        return false;

    //}

    public QCM RetriveQCMDataByQuestionIndex(int i)
    {
        var a = QuestionsAndAnswer.TryGetValue("QCM" + i.ToString(), out value);
        return value;
    }

    public void StartQuiz(User user)
    {



        for (var i = 1; i < 10; i++)
        {

            var qcm = RetriveQCMDataByQuestionIndex(i);
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
            Console.WriteLine("+                                          Question °: "+i+"                                              +");
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
            Console.WriteLine("\n"+ value.Question+ "\n \n");


            Console.WriteLine("Possible answer: \n");
            value.Answers.ForEach(a => Console.WriteLine(a + "\n"));


            Console.WriteLine("Choose the correct answer by typing 1 or 2 or 3 or 4 \n");
            string? EntredAnswer = Console.ReadLine();

            if (value.GoodAnswer == Convert.ToUInt32(EntredAnswer))
            {
                user.IndexOfCorrectAnswer.Add(i);
                user.Score++;
            }

        }
   
    }



    public void DisplayQuizResult(User user)
    {

        foreach (var correctanswerIndex in user.IndexOfCorrectAnswer)
        {
            Console.WriteLine("");
            Console.WriteLine("Question {0} : \n", correctanswerIndex, RetriveQCMDataByQuestionIndex(correctanswerIndex).Question);
            Console.WriteLine("Your Answer {0} is correct \n", RetriveQCMDataByQuestionIndex(correctanswerIndex).GoodAnswer);
        }
        Console.WriteLine("Your Score is {0} / {1} ", user.Score, "not filled yet");

    }


}
