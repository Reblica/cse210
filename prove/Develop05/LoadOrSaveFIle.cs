public class LoadOrSaveFile
{
    public void SaveToFile(string filename, List<Goal> goals)
    {
        StreamWriter writeToFile = new StreamWriter(filename);
        
        foreach(Goal goal in goals)
        {
            writeToFile.WriteLine($"{goal.ToString()}…{goal.SaveGoal()}");
        }
        writeToFile.Close();
    }

    public string[] LoadToFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        return lines;
    }
}