class Journal
{
    List<Entry> Entries = new List<Entry>{};
    public Journal()
    {
        this.Menu();
    }
    public void Menu()
    {
        Console.WriteLine("Options: \n1- New Entry\n2- Display Journal\n3- Save Journal\n4- Load Journal\n5- Exit Journal");
        int Choice = int.Parse(Console.ReadLine());
        if( Choice == 1)
        {
            Entries.Add(new Entry());
            this.Menu();
        }else if(Choice == 2){
            this.DisplayJournal();
            this.Menu();
        }else if(Choice == 3){
            this.SaveJournal();
        }else if(Choice == 4){
            this.LoadJournal();
        }
    }
    public void DisplayJournal()
    {
        foreach( Entry entry in Entries)
        {
            entry.Display();    
        }
    }
    public void SaveJournal()
    {
        Console.Write("Type name to save as:");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach(Entry entry in Entries)
            {
                outputFile.WriteLine($"{entry._Date}\n{entry._Promt}\n{entry._UserText}");
            }
            
        }
        this.Menu();
    }
    public void LoadJournal()
    {
        Console.Write("Type name of file:");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        for(int i = 0; i < lines.Count(); i+=3)
        {   
            int N = this.Entries.Count;
            this.Entries.Add(new Entry(true));
            this.Entries[N]._Date = lines[i];
            this.Entries[N]._Promt = lines[i+1];
            this.Entries[N]._UserText = lines[i+2];
        }
        this.Menu();
    }
}