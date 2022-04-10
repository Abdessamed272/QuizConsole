using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    public class AppDisplay
    {
        private QuizManagment quizManagment = new QuizManagment();
        private Quiz quiz = new Quiz();

        public AppDisplay()
        {


        }
        public void StartupDisplay(User user)
        {

            Console.WriteLine("Hello ! \n \nPlease entre your full name");
            user.Fullname = Console.ReadLine();
            Console.WriteLine("\n \n \n------------------------------------------------Menu------------------------------------------\n");
            Console.WriteLine("Press 'U' to Start the Quiz                      OR                 'A' to login as an admin \n");
            string PressedKey = Console.ReadLine().ToLower();

            if (PressedKey == "a")
            {

                if (Authentication.CheckAuthentication())
                    quizManagment.UpdateQuestion(quiz);

            }
            else if (PressedKey == "u")
            {

                Console.WriteLine("Welcome to the Quiz {0}\n \nYou will be asked 10 QCM and you have to choose one answer! \n \n Ready to start? Let's go!", user.Fullname);
                quiz.StartQuiz(user);
                Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");

                Console.WriteLine("Congratulation! You finished the Quiz \n \nHere is your correct Answers");
                quiz.DisplayQuizResult(user);

            }

        
        }

       
    }
}
