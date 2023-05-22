public class Goal
{
    public int Minute { get; set; }
    public FootballPlayer Player { get; set; }

    public Goal() { }

    public Goal(int minute, FootballPlayer player)
    {
        Minute = minute;
        Player = player;
    }
}

