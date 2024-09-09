using LeetCode.Algorithms.SpiralMatrix4;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.SpiralMatrix4;

public abstract class SpiralMatrix4TestsBase<T> where T : ISpiralMatrix4, new()
{
    [TestMethod]
    [DataRow(3, 5, new[] { 3, 0, 2, 6, 8, 1, 7, 9, 4, 2, 5, 5, 0 }, "[[3,0,2,6,8],[5,0,-1,-1,1],[5,2,4,9,7]]")]
    [DataRow(1, 4, new[] { 0, 1, 2 }, "[[0,1,2,-1]]")]
    [DataRow(4, 4, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 },
        "[[1,2,3,4],[12,13,14,5],[11,16,15,6],[10,9,8,7]]")]
    public void SpiralMatrix_WithDimensionsAndHeadArray_ReturnsCorrectMatrix(int m, int n, int[] headArray,
        string expectedResultJsonArray)
    {
        // Arrange
        var head = ListNode.ToListNode(headArray) ??
                   throw new InvalidOperationException(
                       $"Conversion of headArray to ListNode failed for test input {string.Join(",", headArray)}.");
        var expectedResult = JsonHelper<int>.JsonArrayToJaggedArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.SpiralMatrix(m, n, head);

        // Assert
        JaggedArrayAssert.AreEqual(expectedResult, actualResult);
    }
}