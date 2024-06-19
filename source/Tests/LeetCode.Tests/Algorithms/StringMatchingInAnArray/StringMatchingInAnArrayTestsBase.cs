using LeetCode.Algorithms.StringMatchingInAnArray;

namespace LeetCode.Tests.Algorithms.StringMatchingInAnArray;

public abstract class StringMatchingInAnArrayTestsBase<T> where T : IStringMatchingInAnArray, new()
{
    [TestMethod]
    [DataRow(new[] { "mass", "as", "hero", "superhero" }, new[] { "as", "hero" })]
    [DataRow(new[] { "leetcode", "et", "code" }, new[] { "et", "code" })]
    [DataRow(new[] { "blue", "green", "bu" }, new string[] { })]
    public void StringMatching_WithArrayOfWords_ReturnsMatchingSubstrings(string[] words, string[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.StringMatching(words);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult.ToArray());
    }
}