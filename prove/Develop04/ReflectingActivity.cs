using System;
using System.Diagnostics;

public class ReflectingActivity : Activity
{
    private List<string> _promptList = new List<string>
    {
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."
    };
    private List<string> _questionList = new List<string>
    {
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"
    };
    private List<string> _useQuestionsList = new List<string>();
    
    private string _prompt;
    private string _question;
    private string _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    
    public ReflectingActivity(string activityName, int activityTime) : base(activityName, activityTime)
    {

    }
    public void GetActivityDescription()
    {
        Console.WriteLine(_description);
    }
    private string GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_promptList.Count);
        return _promptList[index];
    }
    private string GetRandomQuestion()
    {
        var random = new Random();
        int index = random.Next(_useQuestionsList.Count);
        return _useQuestionsList[index];
    }
    public void ShowPrompt(int seconds)
    {
        Console.WriteLine();
        var prompt = GetRandomPrompt();
        Console.WriteLine("\nRead the next message:");
        Console.WriteLine($"\n{prompt}");
        Console.WriteLine($"\nWhen you think of something, press enter to continue.");

        var input = Console.ReadKey();
        if (input.Key == ConsoleKey.Enter)
        {
            ShowQuestion(seconds);
        }
    }
    public void ShowQuestion(int seconds)
    {
        _useQuestionsList.AddRange(_questionList);
        Spinner spinner = new Spinner();
        Console.WriteLine($"\nNow meditate on each of the following questions related to this experience.");
        CountDown(8);
        Console.Clear();
        Stopwatch timer = new Stopwatch();
        timer.Start();
        while (timer.Elapsed.TotalSeconds < seconds)
        {
            if (_useQuestionsList.Count != 0)
            {
                var question = GetRandomQuestion();
                Console.Write($"\n>> {question}  ");
                _useQuestionsList.Remove(question);
            }
            spinner.ShowSpinner();
        }
        timer.Stop();
    }

}