using LeetCode.Algorithms.PlusOneTask;

namespace LeetCode.Tests.Algorithms;

[TestClass]
public class PlusOneTests
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3 }, new[] { 1, 2, 4 })]
    [DataRow(new[] { 4, 3, 2, 1 }, new[] { 4, 3, 2, 2 })]
    [DataRow(new[] { 9 }, new[] { 1, 0 })]
    [DataRow(new[] { 9, 9 }, new[] { 1, 0, 0 })]
    [DataRow(new[] { 8, 9, 9, 9 }, new[] { 9, 0, 0, 0 })]
    [DataRow(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }, new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 1 })]
    [DataRow(
        new[]
        {
            7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7, 9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1, 1, 7, 4,
            0, 0, 6
        },
        new[]
        {
            7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7, 9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1, 1, 7, 4,
            0, 0, 7
        })]
    public void PlusOne_GetResult_ShouldIncrementAndMatchExpectedResult(int[] digits, int[] expectedResult)
    {
        // Act
        var actualResult = PlusOne.GetResult(digits);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}