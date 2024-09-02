using LeetCode.Algorithms.FindTheStudentThatWillReplaceTheChalk;

namespace LeetCode.Tests.Algorithms.FindTheStudentThatWillReplaceTheChalk;

public abstract class FindTheStudentThatWillReplaceTheChalkTestsBase<T>
    where T : IFindTheStudentThatWillReplaceTheChalk, new()
{
    [TestMethod]
    [DataRow(new[] { 5, 1, 5 }, 22, 0)]
    [DataRow(new[] { 3, 4, 1, 2 }, 25, 1)]
    [DataRow(new[] { 7, 7, 3, 9, 2 }, 14, 2)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 45, 0)]
    [DataRow(new[] { 1 }, 1000000000, 0)]
    [DataRow(new[] { 100000, 1, 100000, 1, 100000, 1, 100000, 1, 100000, 1 }, 500000, 8)]
    [DataRow(
        new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
        10, 10)]
    [DataRow(new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 1000000000, 0)]
    public void ChalkReplacer_GivenChalkArrayAndKValue_ReturnsCorrectStudentIndex(int[] chalk, int k,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ChalkReplacer(chalk, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}