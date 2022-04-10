using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp;

public class Authentication
{
    private static string _password = "Admin2022";
    private static int _numberOfAttempts = 1;
    private static int _numberOfRetries = 3;
    private static string?  password;

   
    public static bool CheckAuthentication()
    {
        Console.WriteLine("Enter your password to login. ");
        do
        {
            password = Console.ReadLine();

            if (password == _password)
            {
                _numberOfAttempts = 0;
                return true;
            }
            else
            {
                Console.WriteLine("The password is inccorect, try again! ( {0} try left )", _numberOfRetries - _numberOfAttempts);
                _numberOfAttempts++;


            }
        }
        while (_numberOfAttempts <= _numberOfRetries);

        Console.WriteLine("you entreed 3 times wrog password, Login is suspended ");
        return false;
    }
}


