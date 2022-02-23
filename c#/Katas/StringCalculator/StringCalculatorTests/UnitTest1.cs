using System;
using NUnit.Framework;
using StringCalculatorMethods;

namespace StringCalculatorTests;

[TestFixture]
public class StringCalculatorTests
{
    private StringCalculator _stringCalculator = null!;
    
    [SetUp]
    public void Setup()
    {
        _stringCalculator = new StringCalculator();
    }

    [Test]
    public void GivenCalculator_WhenPassedEmptyString_ThenReturn0()
    {
        Assert.AreEqual(_stringCalculator.Add(""), 0);
    }

    [TestCase("1", 1)]
    [TestCase("2", 2)]
    public void GivenCalculator_WhenPassedStringWithSingleValue_ThenReturnIntValue(string input, int expectedValue)
    {
        Assert.AreEqual(_stringCalculator.Add(input), expectedValue);
    }

    [TestCase("1,2", 3)]
    public void GivenCalculator_WhenPassedStringWithTwoValues_ThenReturnSum(string input, int expectedValue)
    {
        Assert.AreEqual(_stringCalculator.Add(input), expectedValue);
    }
    
    [TestCase("1\n2,3", 6)]
    public void GivenCalculator_WhenPassedStringWithTwoValuesAndNewLine_ThenReturnSum(string input, int expectedValue)
    {
        Assert.AreEqual(_stringCalculator.Add(input), expectedValue);
    }
    
    [TestCase("//;\n1;2", 3)]
    public void GivenCalculator_WhenPassedStringWithTwoValuesAndMultipleDelimiters_ThenReturnSum(string input, int expectedValue)
    {
        Assert.AreEqual(_stringCalculator.Add(input), expectedValue);
    }
    
    [TestCase("-1")]
    public void GivenCalculator_WhenPassedSingleNegativeValue_ThenThrowException(string input)
    {
        var ex = Assert.Throws<Exception>(() => _stringCalculator.Add(input));
        Assert.AreEqual(ex.Message, $"negative values not allowed: {input}");
    }
    
    [TestCase("-1,-2")]
    public void GivenCalculator_WhenPassedMultipleNegativeValue_ThenThrowException(string input)
    {
        var removeSeparator = input.Replace(",", " ");
        var ex = Assert.Throws<Exception>(() => _stringCalculator.Add(input));
        Assert.AreEqual(ex.Message, $"negative values not allowed: {removeSeparator}");
    }
}    