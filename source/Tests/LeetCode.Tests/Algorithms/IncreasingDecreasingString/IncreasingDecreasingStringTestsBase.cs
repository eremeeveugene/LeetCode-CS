using LeetCode.Algorithms.IncreasingDecreasingString;

namespace LeetCode.Tests.Algorithms.IncreasingDecreasingString;

public abstract class IncreasingDecreasingStringTestsBase<T> where T : IIncreasingDecreasingString, new()
{
    [TestMethod]
    [DataRow("aaaabbbbcccc", "abccbaabccba")]
    [DataRow("rat", "art")]
    public void SortString_WithUnsortedString_ReturnsSortedString(string s, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SortString(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}