


using QuizApp;

User user1 = new User();
Quiz Quiz1 = new Quiz();

// Question 1
Quiz1.QuestionsAndAnswer[0, 0] = "Question1: CLR signifie";
Quiz1.QuestionsAndAnswer[0, 1] = "1: Common Local Runtime";
Quiz1.QuestionsAndAnswer[0, 2] = "2: Common Language Runtime";
Quiz1.QuestionsAndAnswer[0, 3] = "3: Common Language Realtime";
Quiz1.QuestionsAndAnswer[0, 4] = "4: Common Local Realtime";
Quiz1.QuestionsAndAnswer[0, 5] = "2";

//Question 2
Quiz1.QuestionsAndAnswer[1, 0] = "CLR est responsable de __________ ?";
Quiz1.QuestionsAndAnswer[1, 1] = "Garbage-collector";
Quiz1.QuestionsAndAnswer[1, 2] = "Sécurité d’accès au code";
Quiz1.QuestionsAndAnswer[1, 3] = "Vérification du code";
Quiz1.QuestionsAndAnswer[1, 4] = "Tout les réponses sont vrais";
Quiz1.QuestionsAndAnswer[1, 5] = "4";


//Question 3
Quiz1.QuestionsAndAnswer[2, 0] = "GAC signifie __________ ?";
Quiz1.QuestionsAndAnswer[2, 1] = "1: Global Assembly Cache";
Quiz1.QuestionsAndAnswer[2, 2] = "2: Global Assembly Store";
Quiz1.QuestionsAndAnswer[2, 3] = "3: Garbage Assemble Cache";
Quiz1.QuestionsAndAnswer[2, 4] = "4: Global Advanced Cache";
Quiz1.QuestionsAndAnswer[2, 5] = "1";

//Question 4
Quiz1.QuestionsAndAnswer[3, 0] = "Question 4: Que fait GAC ?";
Quiz1.QuestionsAndAnswer[3, 1] = "1: Stocke les « assembly » .net partagés entre plusieurs applications.";
Quiz1.QuestionsAndAnswer[3, 2] = "2: Stocke les dll globales.";
Quiz1.QuestionsAndAnswer[3, 3] = "3: Mettre en cache les données d’application.";
Quiz1.QuestionsAndAnswer[3, 4] = "4: Aucune de ces réponses";
Quiz1.QuestionsAndAnswer[3, 5] = "1";


//Question 5
Quiz1.QuestionsAndAnswer[4, 0] = "Question 5: Quels sont les types de JIT?";
Quiz1.QuestionsAndAnswer[4, 1] = "1: Pre-JIT";
Quiz1.QuestionsAndAnswer[4, 2] = "2: Econo-JT";
Quiz1.QuestionsAndAnswer[4, 3] = "3: Normal-JIT";
Quiz1.QuestionsAndAnswer[4, 4] = "4: Tout les réponses sont vrais";
Quiz1.QuestionsAndAnswer[4, 5] = "4";


//Question 6
Quiz1.QuestionsAndAnswer[5, 0] = "Question 6: Garbage collector(GC) comprend _______ générations.";
Quiz1.QuestionsAndAnswer[5, 1] = "1: Un";
Quiz1.QuestionsAndAnswer[5, 2] = "2: Deux";
Quiz1.QuestionsAndAnswer[5, 3] = "3: Trois";
Quiz1.QuestionsAndAnswer[5, 4] = "4: Cinq";
Quiz1.QuestionsAndAnswer[5, 5] = "3";



//Question 7
Quiz1.QuestionsAndAnswer[6, 0] = "Comment forcer le garbage-collector à s’exécuter?";
Quiz1.QuestionsAndAnswer[6, 1] = "1: Utilisation de la méthode GC.Run()";
Quiz1.QuestionsAndAnswer[6, 2] = "2: Utilisation de la méthode GC.Collect()";
Quiz1.QuestionsAndAnswer[6, 3] = "3: Utilisation de la méthode GC.Collection()";
Quiz1.QuestionsAndAnswer[6, 4] = "4: Utilisation de la méthode GC.Finalize()";
Quiz1.QuestionsAndAnswer[6, 5] = "2";


//Question 8
Quiz1.QuestionsAndAnswer[7, 0] = "IL en.Net signifie ________?";
Quiz1.QuestionsAndAnswer[7, 1] = "1: Intermediate Language";
Quiz1.QuestionsAndAnswer[7, 2] = "2: International Language";
Quiz1.QuestionsAndAnswer[7, 3] = "3: Interoperate Language";
Quiz1.QuestionsAndAnswer[7, 4] = "4: Intermediate Local";
Quiz1.QuestionsAndAnswer[7, 5] = "1";


//Question 9
Quiz1.QuestionsAndAnswer[8, 0] = "Quel outil est utilisé pour voir le code IL?";
Quiz1.QuestionsAndAnswer[8, 1] = "1: Util.exe";
Quiz1.QuestionsAndAnswer[8, 2] = "2: IL.exe";
Quiz1.QuestionsAndAnswer[8, 3] = "3: GACUtil.exe";
Quiz1.QuestionsAndAnswer[8, 4] = "4: IDASM.EXE";
Quiz1.QuestionsAndAnswer[8, 5] = "4";


//Question 10
Quiz1.QuestionsAndAnswer[9, 0] = "Question 10: Que signifie le terme « boxing » en .net?";
Quiz1.QuestionsAndAnswer[9, 1] = "1: Convertit le type de valeur en objet";
Quiz1.QuestionsAndAnswer[9, 2] = "2: Convertit le type de référence en type de valeur";
Quiz1.QuestionsAndAnswer[9, 3] = "3: Convertit le type primitif en type valeur";
Quiz1.QuestionsAndAnswer[9, 4] = "4: Aucune de ces réponses n’est vraie.";
Quiz1.QuestionsAndAnswer[9, 5] = "1";


Console.WriteLine("press U to login as a user or A to login as an admin!");
string PressedKey = Console.ReadLine().ToLower();

if (PressedKey == "a")
{
    Console.WriteLine("Enter your password to login. ");
    string? entredPassword = Console.ReadLine();
   if (user1.Login(entredPassword))
    {
        Quiz1.UpdateQuestion();

    }


}
else if (PressedKey == "u")
{

    Quiz1.StartQuiz(user1);
    Quiz1.DisplayQuizResult(user1);

}

