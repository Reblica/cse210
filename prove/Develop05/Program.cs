class Program
{
    static void Main(string[] args)
    {
        SelectionMenu _selectionMenu = new SelectionMenu();
        List<Goal> _goals = new List<Goal>();
        LoadOrSaveFile _loadOrSaveFile = new LoadOrSaveFile();
        string choice = "";
        Console.Clear();

        while (choice != "6") // Repeats the main menu until user inputs '6'
        {
            int totalPoints = 0;
            foreach (Goal goal in _goals)
            {
                totalPoints += goal.GetPoints();
            }
            Console.WriteLine($"You have {totalPoints} points!");
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");

            Console.Write("Please select one of the choices above: ");
            choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1") // Gives the option for the user to create one of three goals or return to main menu
            {
                _goals.Add(_selectionMenu.CreateAGoal());
                Console.Clear();
            }
            else if (choice == "2") // Displays the current goal(s)
            {
                _selectionMenu.ListGoals(_goals);
            }
            else if (choice == "3" || choice == "4")
            {
                Console.Write("Please enter the filename for the goal file: ");
                string filename = Console.ReadLine();

                if (choice == "3") // Saves goals into a file
                {
                    _loadOrSaveFile.SaveToFile(filename, _goals);
                }
                else if (choice == "4") // Loads goals from a file
                {
                    string[] lines = _loadOrSaveFile.LoadToFile(filename);
                    _goals.Clear();

                    foreach (string line in lines)
                    {
                        string goalType = line.Split("…")[0];
                        string fileGoal = line.Remove(0, goalType.Length+1);

                        if (goalType == "SimpleGoal")
                        {
                            _goals.Add(new SimpleGoal(fileGoal));
                        }
                        else if (goalType == "EternalGoal")
                        {
                            _goals.Add(new EternalGoal(fileGoal));
                        }
                        else if (goalType == "ChecklistGoal")
                        {
                            _goals.Add(new ChecklistGoal(fileGoal));
                        }
                    }
                }
            }
            else if (choice == "5") // Completes a goal specified by the user
            {
                int goalType = _selectionMenu.CheckOffGoal(_goals);
                _goals[goalType - 1].RecordEvent();

                Console.Clear();
            }
        }
    }
}