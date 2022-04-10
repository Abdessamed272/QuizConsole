using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using QuizApp.DeserializeQCMJson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace QuizApp
{
    public class QuizManagment
    {

        public void UpdateQuestion(Quiz quiz)
        {

            Console.WriteLine("Enter the question's number that you would like to update");
            int IndexQuestionEdit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the new question");
            string? NewQuestion = Console.ReadLine();
          //  quiz.QuestionsAndAnswer[IndexQuestionEdit][0] = NewQuestion;

            Console.WriteLine("Enter the 4 possible answers");
            for (int i = 0; i < 4; i++)
            {
              //  quiz.QuestionsAndAnswer[IndexQuestionEdit][i] = Console.ReadLine();
            }
            Console.WriteLine("Whitch one is the correct answer? enter 1 or 2 or 3 or 4");
       //     quiz.QuestionsAndAnswer[IndexQuestionEdit][4] = Console.ReadLine();

            Console.WriteLine("The question {0} was updated!", IndexQuestionEdit);

        }

        public void DeleteQuestion()
        {

        }

        public void AddQuestion()
        {

        }

        public static Dictionary<string, QCM> ReadQuestionsFromJsonFile()
        {

            string path = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));
            var myJsonString = File.ReadAllText(path + "\\" + "QuestionsAndAnswers.json");

            var qcmData = JsonConvert.DeserializeObject<QCMDataModel>(myJsonString);
            return qcmData.AllQCM;

        }
    }
}
