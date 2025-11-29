public class ReflectingActivity : Activity
{
    private Random _ran = new Random();
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = 
        [
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        ];
        _questions =
        [
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
        ];
    }
    public void RunReflectingActivity()
    {
        RenderStartMessage();
        DisplayAPrompt();
        DisplayQuestions();
        RenderEndMessage();
    }
    public string GetRandomPrompt()
    {
        int randomNumber = _ran.Next(0, _prompts.Count);
        return _prompts[randomNumber];
    }
    public string GetRandomQuestion()
    {
        int randomNumber = _ran.Next(0, _questions.Count);
        return _questions[randomNumber];
    }
    public void DisplayAPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();

        string given = "- - -";
        DisplayStringsAsCharacters(given);

        Console.Write($" {GetRandomPrompt()} ");

        given = "- - -";
        DisplayStringsAsCharacters(given);
        Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        string input = Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        PauseWithSpinner(1);
        Console.Write($"You may begin in: ");
        PauseWithTimer(5);
        Console.Clear();
    }
    public void DisplayQuestions()
    {
        List<string> questions = new List<string>();
        string question;

        DateTime starTime = DateTime.Now;
        DateTime futureTime = starTime.AddSeconds(GetDuration());

        while (DateTime.Now < futureTime)
        {
            question = GetRandomQuestion();
            questions.Add(question);
            _questions.Remove(question);
            Console.Write($"> {question} ");
            PauseWithSpinner(9);
            Console.WriteLine();
            if (_questions.Count == 0)
            {
                foreach (string q in questions)
                {
                    _questions.Add(q);
                }
            }
        }
        foreach (string q in questions)
        {
            _questions.Add(q);
        }
        Console.WriteLine();
    }
}