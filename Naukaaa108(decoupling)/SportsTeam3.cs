// So far, we’ve completely decoupled SportsTeam from System.Console, which means that SportsTeam no longer makes any calls directly to System.Console, but instead makes calls to an object whose functionality we define. The usefulness of this decoupling will be evident in our unit tests.
public class SportsTeam3
{
    public string Sport { get; set; }
    public string TeamName { get; set; }

    private IConsole Console { get; }

    public SportsTeam3(string sport, string teamName, IConsole console)
    {
        if (console == null)
            throw new ArgumentNullException(nameof(console));

        Sport = sport;
        TeamName = teamName;
        Console = console;
    }

    public void PrintTeamInfo()
    {
        Console.WriteLine(Sport + " - " + TeamName);
    }

    public void UpdateTeam()
    {
        Console.Write("Enter new team name --> ");
        var newName = Console.ReadLine();
        TeamName = newName;
    }
}