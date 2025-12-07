public class SelectionMenu
{
    public Goal CreateAGoal()
    {
        Console.Clear();
        Console.WriteLine("Select one of the follow to create:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Select the goal you want to create: ");
        string choice = Console.ReadLine();
        Console.WriteLine();
        Console.Clear();

        if (choice == "1") // Creates a new simple goal
        {
            return SimpleGoal.CreateGoal();
        }
        else if (choice == "2") // Creates a new eternal goal
        {
            return EternalGoal.CreateGoal();
        }
        else // Creates a new checklist goal
        {
            return ChecklistGoal.CreateGoal();
        }
    }
    public void ListGoals(List<Goal> goals)
    {
        int i = 0;
        foreach (Goal goal in goals)
        {
            i++;
            Console.Write($"{i}. ");
            goal.DisplayGoal();
        }
    }
    public int CheckOffGoal(List<Goal> goals)
    {
        Console.Clear();
        int i = 0;
        Console.WriteLine("The goals are:");
        foreach (Goal goal in goals)
        {
            i++;
            Console.WriteLine($"{i} {goal.GetName()}");
        }
        Console.Write("Which goal did you complete? ");
        int goalType = int.Parse(Console.ReadLine());
        
        return goalType;
    }
}