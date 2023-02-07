// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello");
//Console.Clear();

Team FireBirds = new Team("FireBirds");
Team WaterMammals = new Team("WaterMammals");
Player John = new Player("John Henderson", 11);
Player tim = new Player("Tim Nun", 13);
Player Jimmy = new Player("Jimmy John Smith", 15);
Player Tom = new Player("Tom Smart", 7);
Match FirstMatch = new Match(FireBirds , WaterMammals);
FirstMatch.DecideWin();
FireBirds.AddPlayer(John);
FireBirds.AddPlayer(tim);
WaterMammals.AddPlayer(Jimmy);
WaterMammals.AddPlayer(Tom);
FireBirds.Display_Roster();
WaterMammals.Display_Roster();