public class Team
{
    public Coach Coach { get; set; }
    public FootballPlayer[] FootballPlayers { get; set; }
    public double AverageAgeOfPlayers { get; set; }

    public Team() { }

    public Team(Coach coach, FootballPlayer[] footballPlayers, double averageAgeOfPlayers)
    {
        Coach = coach;
        FootballPlayers = footballPlayers;
        AverageAgeOfPlayers = averageAgeOfPlayers;
    }
}
