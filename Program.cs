


using QuizApp;

User user1 = new User();
Quiz Quiz1 = new Quiz();

// Question 1


Quiz1.QuestionsAndAnswer.Insert(0, new List<string> {
    "Question1: CLR signifie",
        "1: Common Local Runtime",
        "2: Common Language Runtime",
        "3: Common Language Realtime",
        "4: Common Local Realtime",
        "2" });



//Question 2
Quiz1.QuestionsAndAnswer.Insert(1, new List<string>
{
    "CLR est responsable de __________ ?",
    "Garbage-collector",
"Sécurité d’accès au code",
"Vérification du code",
"Tout les réponses sont vrais",
"4",
});



//Question 3
Quiz1.QuestionsAndAnswer.Insert(2, new List<string>
{
    "GAC signifie __________ ?",
"1: Global Assembly Cache",
"2: Global Assembly Store",
"3: Garbage Assemble Cache",
"4: Global Advanced Cache",
    "1"

});

//Question 4
Quiz1.QuestionsAndAnswer.Insert(3, new List<string>

    {
"Question 4: Que fait GAC ?",
"1: Stocke les « assembly » .net partagés entre plusieurs applications.",
"2: Stocke les dll globales.",
"3: Mettre en cache les données d’application.",
"4: Aucune de ces réponses",
"1"
});

//Question 5
Quiz1.QuestionsAndAnswer.Insert(4, new List<string>
    {
"Question 5: Quels sont les types de JIT?",
"1: Pre-JIT",
"2: Econo-JT",
"3: Normal-JIT",
"4: Tout les réponses sont vrais",
"4"
});



//Question 6
Quiz1.QuestionsAndAnswer.Insert(5, new List<string>
{
"Question 6: Garbage collector(GC) comprend _______ générations.",
"1: Un",
"2: Deux",
"3: Trois",
"4: Cinq",
"3"
});



//Question 7
Quiz1.QuestionsAndAnswer.Insert(6, new List<string>
{

"Comment forcer le garbage-collector à s’exécuter?",
"1: Utilisation de la méthode GC.Run()",
 "2: Utilisation de la méthode GC.Collect()",
"3: Utilisation de la méthode GC.Collection()",
"4: Utilisation de la méthode GC.Finalize()",
"2",
});


//Question 8
Quiz1.QuestionsAndAnswer.Insert(7, new List<string>

{
    "IL en.Net signifie ________?",
    "1: Intermediate Language",
    "2: International Language",
    "3: Interoperate Language",
    "4: Intermediate Local",
    "1"
});

//Question 9
Quiz1.QuestionsAndAnswer.Insert(8, new List<string>
{
 "Quel outil est utilisé pour voir le code IL?",
"1: Util.exe",
"2: IL.exe",
"3: GACUtil.exe",
"4: IDASM.EXE",
"4"
});

//Question 10
Quiz1.QuestionsAndAnswer.Insert(9, new List<string>
{
"Question 10: Que signifie le terme « boxing » en .net?",
"1: Convertit le type de valeur en objet",
"2: Convertit le type de référence en type de valeur",
"3: Convertit le type primitif en type valeur",
"4: Aucune de ces réponses n’est vraie.",
    "1"
});

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

