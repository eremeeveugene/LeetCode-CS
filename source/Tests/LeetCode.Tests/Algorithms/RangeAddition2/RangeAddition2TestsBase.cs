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

using LeetCode.Algorithms.RangeAddition2;

namespace LeetCode.Tests.Algorithms.RangeAddition2;

public abstract class RangeAddition2TestsBase<T> where T : IRangeAddition2, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MaxCount_WithMatrixDimensionsAndOperations_ReturnsCountOfMaximumIntegers(int m, int n, int[][] ops,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxCount(m, n, ops);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [3, 3, new int[][] { new[] { 2, 2 }, new[] { 3, 3 } }, 4];

        yield return [3, 3, new int[][] { new[] { 2, 2 }, new[] { 3, 3 }, new[] { 3, 3 }, new[] { 3, 3 }, new[] { 2, 2 }, new[] { 3, 3 }, new[] { 3, 3 }, new[] { 3, 3 }, new[] { 2, 2 }, new[] { 3, 3 }, new[] { 3, 3 }, new[] { 3, 3 } }, 4];

        yield return [3, 3, Array.Empty<int[]>(), 9];
    }
}
