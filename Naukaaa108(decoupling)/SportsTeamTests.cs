using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class SportsTeamTests
{
    [TestMethod]
    public void PrintTeamInfo_PrintsCorrectInformation()
    {
        var testConsole = new TestableConsole();
        var myTeam = new SportsTeam3("Hockey", "Bruins", testConsole);

        myTeam.PrintTeamInfo();

        Assert.AreEqual("Hockey - Bruins", testConsole.WrittenLines[0]);
        // pr just (..., myTeam.PrintTeamInfo())
    }

    [TestMethod]
    public void UpdateTeam_TeamIsUpdated()
    {
        var testConsole = new TestableConsole();
        var myTeam = new SportsTeam3("Hockey", "Bruins", testConsole);

        testConsole.LineToRead = "Rangers";

        myTeam.UpdateTeam();

        Assert.AreEqual("Rangers", myTeam.TeamName);
        Assert.AreEqual("Enter new team name --> ",
            testConsole.WrittenLines[0]);
    }
}