using LeetCode.Algorithms.RelativeSortArray;

namespace LeetCode.Tests.Algorithms.RelativeSortArray;

public abstract class RelativeSortArrayTestsBase<T> where T : IRelativeSortArray, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 3, 1, 3, 2, 4, 6, 7, 9, 2, 19 }, new[] { 2, 1, 4, 3, 9, 6 }, new[] { 2, 2, 2, 1, 4, 3, 3, 9, 6, 7, 19 })]
    [DataRow(new[] { 28, 6, 22, 8, 44, 17 }, new[] { 22, 28, 8, 6 }, new[] { 22, 28, 8, 6, 17, 44 })]
    public void RelativeSortArray_WithGivenArrays_ReturnsCorrectlySortedArray(int[] arr1, int[] arr2,
        int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RelativeSortArray(arr1, arr2);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}