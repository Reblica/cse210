public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }
    public void RunBreathingActivity()
    {
        RenderStartMessage();
        DisplayBreathing();
        RenderEndMessage();
    }
    public void DisplayBreathing()
    {
        Console.Write("Breathe in...");
        PauseWithTimer(2);
        Console.WriteLine();
        Console.Write("Breathe out...");
        PauseWithTimer(3);
        Console.WriteLine();
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < futureTime)
        {
            Console.Write("Breathe in...");
            PauseWithTimer(4);
            Console.WriteLine();
            Console.Write("Breathe out...");
            PauseWithTimer(6);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}