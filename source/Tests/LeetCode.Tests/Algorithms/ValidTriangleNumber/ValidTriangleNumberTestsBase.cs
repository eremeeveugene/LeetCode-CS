using LeetCode.Algorithms.ValidTriangleNumber;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.ValidTriangleNumber;

public abstract class ValidTriangleNumberTestsBase<T> where T : IValidTriangleNumber, new()
{
    [TestMethod]
    [DataRow("[2,2,3,4]", 3)]
    [DataRow("[4,2,3,4]", 4)]
    public void TriangleNumber_WithSideLengths_ReturnsCountOfValidTriangles(string numsJson, int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.TriangleNumber(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}