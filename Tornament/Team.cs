class Team
{
    private string _name;
    private List<Player> _Players = new List<Player>{};
    private int _Wins = 0;
    private int _Losses = 0;
    public Team(string name)
    {
        _name = name;
    }
    public void AddPlayer(Player player)
    {
        bool RepeatPlayer = false;
        foreach(Player p in _Players)
        {
            if(player == p)
            {
                RepeatPlayer = true;
                Console.WriteLine("You have repeated a player");
            }
        }
        if(RepeatPlayer == false){
            _Players.Add(player);
        }
        
    }
    public void Display_Roster(){
        Console.WriteLine($"{_name}");
        Console.WriteLine($"Wins: {_Wins}");
        Console.WriteLine($"Losses: {_Losses}");
        Console.WriteLine($"-----------------------------");
        foreach(Player p in _Players)
        {
            p.Display();
        }
        Console.WriteLine($"-----------------------------");
        
    }
    public void AddWin()
    {
        _Wins += 1;
    }
    public void AddLoss()
    {
        _Losses += 1;
    }
    public string GetTeamName()
    {
        return _name;
    }
}