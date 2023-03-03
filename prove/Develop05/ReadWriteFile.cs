using System.IO;
static class ReadWriteFile
{
    static public List<Goal> Read()
    {
        string filename = "myGoals.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        List<Goal> Goals = new List<Goal>();
        Goal.Totalpoints = int.Parse(lines[0]);
        for(int i = 1; i < lines.Length;i++)
        {
            
            string[] parts = lines[i].Split(":");
            
            string[] attributes = parts[1].Split(",");
            switch(parts[0])
            {
                case "SimpleGoal":
                    Goals.Add(new SimpleGoal(attributes));
                    break;
                case "EternalGoal":
                    Goals.Add(new EternalGoal(attributes));
                    break;
                case "ChecklistGoal":
                    Goals.Add(new ChecklistGoal(attributes));
                    break;
            }
        }
        return Goals;
    }
    static public void Write(List<Goal> Goals)
    {
        string fileName = "myGoals.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(Goal.Totalpoints);
            foreach(Goal g in Goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }
            
        }
    }
}