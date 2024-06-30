using LeetCode.Algorithms.IntersectionOfTwoArrays2;

namespace LeetCode.Tests.Algorithms.IntersectionOfTwoArrays2;

public abstract class IntersectionOfTwoArrays2TestsBase<T> where T : IIntersectionOfTwoArrays2, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 2, 1 }, new[] { 2, 2 }, new[] { 2, 2 })]
    [DataRow(new[] { 4, 9, 5 }, new[] { 9, 4, 9, 8, 4 }, new[] { 4, 9 })]
    public void Intersect_WithTwoArrays_ReturnsCommonElements(int[] nums1, int[] nums2, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.Intersect(nums1, nums2);

        // Assert
        CollectionAssert.AreEquivalent(expectedResult, actualResult);
    }
}