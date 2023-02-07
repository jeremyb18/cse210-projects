class Match
{
    private Team _Team1;
    private Team _Team2;
    public Match(Team team1, Team team2)
    {
        _Team1 = team1;
        _Team2 = team2;
    }
    public void DecideWin()
    {
        Console.WriteLine("Which Team won?");
        Console.WriteLine($"1) {_Team1.GetTeamName()}");
        Console.WriteLine($"2) {_Team2.GetTeamName()}");
        string winner = Console.ReadLine();
        if(winner == "1")
        {
            _Team1.AddWin();
            _Team2.AddLoss();
        }
        if(winner == "2")
        {
            _Team2.AddWin();
            _Team1.AddLoss();
        }
    }
}