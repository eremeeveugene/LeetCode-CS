using LeetCode.Algorithms.RomanToIntegerTask;

namespace LeetCode.Tests.Algorithms;

[TestClass]
public class RomanToIntegerTests
{
    [TestMethod]
    [DataRow("III", 3)]
    [DataRow("LVIII", 58)]
    [DataRow("MCMXCIV", 1994)]
    public void RomanToInteger_GetResult_ReturnsExpectedIndicesForGivenTarget(string romanString, int expectedResult)
    {
        // Act
        var actualResult = RomanToInteger.GetResult(romanString);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}