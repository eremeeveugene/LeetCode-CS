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

using LeetCode.Algorithms.MinimumOperationsToMakeUniValueGrid;

namespace LeetCode.Tests.Algorithms.MinimumOperationsToMakeUniValueGrid;

public abstract class MinimumOperationsToMakeUniValueGridTestsBase<T> where T : IMinimumOperationsToMakeUniValueGrid, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MinOperations_WithGridAndOperationValue_ReturnsMinimumOperationsToMakeUniValueGrid(int[][] grid, int x, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinOperations(grid, x);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new int[][] { [2, 4], [6, 8] }, 2, 4];
        yield return [new int[][] { [1, 5], [2, 3] }, 1, 5];
        yield return [new int[][] { [1, 2], [3, 4] }, 2, -1];
        yield return [new int[][] { [1] }, 1, 0];
        yield return [new int[][] { [10] }, 5, 0];
        yield return [new int[][] { [5, 5], [5, 5] }, 3, 0];
        yield return [new int[][] { [1, 3, 5] }, 2, 2];
        yield return [new int[][] { [1], [3], [5] }, 2, 2];
        yield return [new int[][] { [1, 7, 13] }, 6, 2];
        yield return [new int[][] { [3, 9, 15, 21] }, 6, 4];
        yield return [new int[][] { [10, 4], [16, 22] }, 6, 4];
        yield return [new int[][] { [4, 10], [16, 22] }, 6, 4];
        yield return [new int[][] { [2, 6], [10, 14] }, 4, 4];
        yield return [new int[][] { [1, 4], [7, 10] }, 3, 4];
        yield return [new int[][] { [1, 4], [7, 11] }, 3, -1];
        yield return [new int[][] { [10000, 9998], [9996, 9994] }, 2, 4];
        yield return [new int[][] { [1, 10001] }, 10000, 1];
        yield return [new int[][] { [1, 10000] }, 10000, -1];
        yield return [new int[][] { [1, 11, 21], [31, 41, 51] }, 10, 9];
        yield return [new int[][] { [8, 12, 16], [20, 24, 28] }, 4, 9];
        yield return [new int[][] { [1, 2, 3] }, 1, 2];
        yield return [new int[][] { [1, 2, 3, 4] }, 1, 4];
        yield return [new int[][] { [7, 3, 11], [15, 19, 23] }, 4, 9];
    }
}