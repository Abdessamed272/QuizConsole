namespace QuizApp.DeserializeQCMJson;

public class QCM
{
    public string Question { get; set; }
    public List<string> Answers { get; set; }
    public int GoodAnswer { get; set; }
}