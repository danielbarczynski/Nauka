namespace SportsTeam2;

public class SportsTeam2
{
    public string Sport { get; set; }
    public string TeamName { get; set; }

    public SportsTeam2(string sport, string teamName)
    {
        Sport = sport;
        TeamName = teamName;
    }

    public void PrintTeamInfo()
    {
        System.Console.WriteLine(Sport + " - " + TeamName);
    }

    public void UpdateTeam()
    {
        System.Console.Write("Enter new team name --> ");
        var newName = Console.ReadLine();
        TeamName = newName;
    }
}