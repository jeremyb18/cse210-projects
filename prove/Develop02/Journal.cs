class Journal
{
    List<Entry> Entries = new List<Entry>{};
    string _Name;
    public Journal(string Name = "")
    {   
        this._Name = Name;
        if(_Name == "")
        {
            Console.WriteLine("What would you like to name your Journal?");
            this._Name = Console.ReadLine();
        }else{
            this.LoadJournal();
        }
        this.Menu();
    }
    public void Menu()
    {
        Console.WriteLine("Options: \n1- New Entry\n2- Display Journal\n3- Save Journal\n4- Save and Exit Journal");
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
            this.Menu();
        }else if(Choice == 4){
            this.SaveJournal();
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
        string fileName = this._Name;
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach(Entry entry in Entries)
            {
                outputFile.WriteLine($"{entry._Date}\n{entry._Promt}\n{entry._UserText}");
            }
            
        }
        Console.WriteLine($"Files Save as {this._Name}");
        
    }
    public void LoadJournal()
    {
        string filename = this._Name;
        string[] lines = System.IO.File.ReadAllLines(filename);
        for(int i = 0; i < lines.Count(); i+=3)
        {   
            int N = this.Entries.Count;
            this.Entries.Add(new Entry(true));
            this.Entries[N]._Date = lines[i];
            this.Entries[N]._Promt = lines[i+1];
            this.Entries[N]._UserText = lines[i+2];
        }
    }
}