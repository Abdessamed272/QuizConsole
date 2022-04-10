using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp;

public class User
{
    public static int userNumber = 0;
    public string? Fullname { get; set; }
    public int Score { get; set; }
    public List<int> IndexOfCorrectAnswer { get; set; }

    public User()
    {
        userNumber++;
        Score = 0;
        IndexOfCorrectAnswer = new List<int>();
    }

 
}
