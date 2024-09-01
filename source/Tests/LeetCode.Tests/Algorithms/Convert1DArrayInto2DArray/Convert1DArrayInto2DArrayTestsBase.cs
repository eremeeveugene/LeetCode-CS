using LeetCode.Algorithms.Convert1DArrayInto2DArray;
using LeetCode.Core.Helpers;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.Convert1DArrayInto2DArray;

public abstract class Convert1DArrayInto2DArrayTestsBase<T> where T : IConvert1DArrayInto2DArray, new()
{
    [TestMethod]
    [DataRow(new[] { 3 }, 1, 2, "[]")]
    [DataRow(new[] { 1, 2 }, 1, 1, "[]")]
    [DataRow(new[] { 1, 2, 3 }, 1, 3, "[[1,2,3]]")]
    [DataRow(new[] { 1, 2, 3, 4 }, 2, 2, "[[1,2],[3,4]]")]
    public void Construct2DArray_GivenOriginalArrayAndDimensions_ReturnsExpected2DArray(int[] original, int m, int n,
        string expectedResultJsonArray)
    {
        // Arrange
        var expectedResult = JsonHelper<int>.JsonArrayToJaggedArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.Construct2DArray(original, m, n);

        // Assert
        JaggedArrayAssert.AreEqual(expectedResult, actualResult);
    }
}