public class Game
{
    public Team Team1 { get; set; }
    public Team Team2 { get; set; }
    public Referee Referee { get; set; }
    public Referee[] AssistantReferees { get; set; } = new Referee[2];
    public Goal Goals { get; set; }
    public string Result { get; set; }
    public Team Winner { get; set; }

    public Game() { }

    public Game(Team team1, Team team2, Referee referee, Referee[] assistantReferees, Goal goals, string result, Team winner)
    {
        Team1 = team1;
        Team2 = team2;
        Referee = referee;
        AssistantReferees = assistantReferees;
        Goals = goals;
        Result = result;
        Winner = winner;
    }
}
