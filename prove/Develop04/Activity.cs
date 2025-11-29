public class Activity
{
    private string _activityName;
    private string _activityDescription;
    private int _duration;
    public Activity()
    {
        _activityName = "Test Activity";
        _activityDescription = "This is a test for the functions within the base class.";
    }
    public Activity(string activityName, string activityDescription)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
        _duration = 0;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void RenderStartMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName}.");
        Console.WriteLine();
        Console.WriteLine(_activityDescription);
        Console.WriteLine();
        Console.Write("How long, in seconds, do you want your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        RunActivity();
    }
    public void RunActivity()
    {
        Console.Write("Get ready");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(".");
            Thread.Sleep(500);
        }
        Console.WriteLine();
        PauseWithSpinner(3);
        Console.WriteLine();
    }
    public void PauseWithSpinner(int spins)
    {
        for (int i = 0; i < spins; i++)
        {
            Console.Write("|");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(300);
            Console.Write("\b \b");
        }
    }
    public void PauseWithTimer(int time)
    {
        for (int i = 0; i < time; time--)
        {
            Console.Write(time);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void DisplayStringsAsCharacters(string given)
    {
        foreach (char a in given)
        {
            Console.Write(a);
            Thread.Sleep(700);
        }
    }
    public void RenderEndMessage()
    {
        Console.WriteLine("Well done!!");
        PauseWithSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName}.");
        PauseWithSpinner(3);
        Console.Clear();
    }
}