// --------------------------------------------------------------------------------
// Copyright (C) 2026 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.Convert1DArrayInto2DArray;

namespace LeetCode.Tests.Algorithms.Convert1DArrayInto2DArray;

public abstract class Convert1DArrayInto2DArrayTestsBase<T> where T : IConvert1DArrayInto2DArray, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void Construct2DArray_WithOriginalArrayAndDimensions_ReturnsReshapedMatrixOrEmptyArray(
        int[] original,
        int m,
        int n,
        int[][] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.Construct2DArray(original, m, n);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { 3 }, 1, 2, Array.Empty<int[]>()];

        yield return [new[] { 1, 2 }, 1, 1, Array.Empty<int[]>()];

        yield return [new[] { 1, 2, 3 }, 1, 3, new[] { new[] { 1, 2, 3 } }];

        yield return [new[] { 1, 2, 3, 4 }, 2, 2, new[] { new[] { 1, 2 }, new[] { 3, 4 } }];
    }
}