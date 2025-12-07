public class TrophyRoom
{
    private string[][] _trophies;
    private int _rewardsOwned;
    private int _pointsNeeded;

    public TrophyRoom()
    {
        _trophies = 
        [["Invisible Ball", 
        "This glowing ball seems to be coated with an unknown element. Scientist say the resource is rare, but have yet to further instate its properties."], 
        ["Gold Brick", "This gold brick sounds normal at first, but has a super cool logo on it...with your name on its side too!"], 
        ["Globe", "Be careful. Tilting it even a little bit will send the planet of its axis."], 
        ["Virtual Macbook", "Want to use it?...Uh, well, it seems useless, but bragging rights are immense."]];
        _rewardsOwned = 0;
        _pointsNeeded = 50;
    }
    public void DisplayTrophies()
    {
        Console.WriteLine("Currently unlocked trophies:");
        for (int i = 0; i < _rewardsOwned; i++)
        {
            Console.WriteLine($"  {i + 1}. {_trophies[i][0]}");
        }
        Console.Write("Select one to read the description: ");
        int trophy = int.Parse(Console.ReadLine());
        Console.Clear();

        if (trophy <= _rewardsOwned && trophy > 0)
        {
            Console.WriteLine($"{_trophies[trophy-1][0]}:");
            Console.WriteLine();
            Console.WriteLine(_trophies[trophy-1][1]);
            Console.WriteLine();
            Console.WriteLine("Please press enter to continue back to the main menu.");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Sorry. It looks you haven't unlocked that one, or you already one all unlockables.");
        }
    }
    public void HasReachedNextReward(int points)
    {
        if (_rewardsOwned >= _trophies.Length)
        {
            Console.WriteLine("You have unlocked all items! There are no more to unlock");
        }
        else
        {
            while (points >= _pointsNeeded)
            {
                Console.WriteLine($"Congratulations! You have unlocked {_trophies[_rewardsOwned][0]}!");
                _rewardsOwned++;
                _pointsNeeded += _pointsNeeded + 150;
            }
            Console.WriteLine($"You have {points} out of {_pointsNeeded} until the next reward.");
        }
    }
}