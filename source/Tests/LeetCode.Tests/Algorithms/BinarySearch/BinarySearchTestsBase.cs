using LeetCode.Algorithms.BinarySearch;

namespace LeetCode.Tests.Algorithms.BinarySearch;

public abstract class BinarySearchTestsBase<T> where T : IBinarySearch, new()
{
    [TestMethod]
    [DataRow(new[] { 0 }, 0, 0)]
    [DataRow(new[] { -1, 0, 3, 5, 9, 12 }, 9, 4)]
    [DataRow(new[] { -1, 0, 3, 5, 9, 12 }, 2, -1)]
    public void Search_WithTargetInArray_ReturnsCorrectIndexOrMinusOne(int[] nums, int target, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.Search(nums, target);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}