using NUnit.Framework;
using MarsRoverApplication;

namespace MarsRoverTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    // [TestCase("0:0:N")]
    // [TestCase("2:1:W")]
    // public void GivenRoverInitialState_WhenOnExecution_ThenShouldMatch(string initialState)
    // {
    //     var marsRover = new MarsRoverApplication.MarsRover(initialState);
    //
    //     var result = marsRover.Execute("");
    //
    //     Assert.AreEqual(result, initialState);
    // }
    [TestCase("0:0:N", "","0:0:N")]
    [TestCase("2:1:W", "","2:1:W")]
    [TestCase("0:0:N", "M","0:1:N")]
    [TestCase("1:1:N", "M","1:2:N")]
    [TestCase("1:1:W", "M","0:1:W")]
    [TestCase("1:1:E", "M","2:1:E")]
    [TestCase("1:1:S", "M","1:0:S")]
    [TestCase("1:1:S", "R","1:1:W")]
    [TestCase("1:1:W", "R","1:1:N")]
    [TestCase("1:1:N", "R","1:1:E")]
    [TestCase("1:1:E", "R","1:1:S")]
    [TestCase("1:1:S", "L","1:1:E")]
    [TestCase("1:1:E", "L","1:1:N")]
    [TestCase("1:1:N", "L","1:1:W")]
    [TestCase("1:1:W", "L","1:1:S")]
    [TestCase("1:1:W", "LL","1:1:E")]
    public void GivenRoverInitialState_WhenMoveForwardCommand_ThenShouldMatch(string initialState, string commands, string expectedFinalState)
    {
        var marsRover = new MarsRoverApplication.MarsRover(initialState);

        var result = marsRover.Execute(commands);

        Assert.AreEqual(result, expectedFinalState);
    }
}
