using System.IO;
class ReadWriteFile
{
    public void Read()
    {
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(":");

            string firstName = parts[0];
            string lastName = parts[1];
        }
    }
    public void Write()
    {
        string fileName = "myGoals.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine("This will be the first line in the file.");
            
            // You can use the $ and include variables just like with Console.WriteLine
            string color = "Blue";
            outputFile.WriteLine($"My favorite color is {color}");
        }
    }
    public void GetString()
    {
        Goal I = new EternalGoal();
        I.GetStringRepresentation();
    }
}