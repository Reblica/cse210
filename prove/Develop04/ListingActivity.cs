public class ListingActivity : Activity
{
    private Random ran = new Random();
    private List<string> _prompts = new List<string>();
    private List<string> _userList = new List<string>();

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = 
        [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        ];
    }
    public void RunListingActivity()
    {
        RenderStartMessage();
        DisplayPrompt();
        GetUserResponse();
        RenderEndMessage();
    }
    public string GetRandomPrompt()
    {
        int randomNumber = ran.Next(0, _prompts.Count);
        return _prompts[randomNumber];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine();

        string given = "- - -";
        DisplayStringsAsCharacters(given);
        Console.Write($" {GetRandomPrompt()} ");
        given = "- - -";
        DisplayStringsAsCharacters(given);

        Console.WriteLine();
        Console.WriteLine();
        Console.Write($"You may begin in: ");
        PauseWithTimer(5);
        Console.WriteLine();
    }
    public void GetUserResponse()
    {
        DateTime starTime = DateTime.Now;
        DateTime futureTime = starTime.AddSeconds(GetDuration());

        while (DateTime.Now < futureTime)
        {
            Console.Write("> ");
            string answer = Console.ReadLine();
            Console.WriteLine();
            _userList.Add(answer);
        }
        Console.WriteLine();
        Console.WriteLine($"You listed {_userList.Count} items!");
        Console.WriteLine();
    }
}