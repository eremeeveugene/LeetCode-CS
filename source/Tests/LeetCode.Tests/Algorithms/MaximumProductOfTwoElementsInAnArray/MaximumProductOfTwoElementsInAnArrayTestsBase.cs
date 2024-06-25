using LeetCode.Algorithms.MaximumProductOfTwoElementsInAnArray;

namespace LeetCode.Tests.Algorithms.MaximumProductOfTwoElementsInAnArray;

public abstract class MaximumProductOfTwoElementsInAnArrayTestsBase<T>
    where T : IMaximumProductOfTwoElementsInAnArray, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 7 }, 12)]
    [DataRow(new[] { 3, 4, 5, 2 }, 12)]
    [DataRow(new[] { 1, 5, 4, 5 }, 16)]
    public void MaxProduct_WithVariousInputs_ReturnsMaximumProduct(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxProduct(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}