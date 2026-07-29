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

using LeetCode.Algorithms.CheckIfThereIsValidPathInGrid;

namespace LeetCode.Tests.Algorithms.CheckIfThereIsValidPathInGrid;

public abstract class CheckIfThereIsValidPathInGridTestsBase<T> where T : ICheckIfThereIsValidPathInGrid, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void HasValidPath_WithGivenGrid_ReturnsTrueWhenValidPathExists(int[][] grid, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.HasValidPath(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new int[][] { [2, 4, 3], [6, 5, 2] }, true];
        yield return [new int[][] { [1, 2, 1], [1, 2, 1] }, false];
        yield return [new int[][] { [1, 1, 2] }, false];
        yield return [new int[][] { [1, 1, 1, 1, 1, 1, 3] }, true];
        yield return [new int[][] { [2], [2], [2], [2], [2], [2], [5] }, true];
        yield return [new int[][] { [1] }, true];
        yield return [new int[][] { [4, 1], [6, 1] }, true];
        yield return [new int[][] { [1, 1], [1, 1] }, false];
        yield return [new int[][] { [2] }, true];
        yield return [new int[][] { [3] }, true];
        yield return [new int[][] { [4] }, true];
        yield return [new int[][] { [5] }, true];
        yield return [new int[][] { [6] }, true];
        yield return [new int[][] { [1, 1] }, true];
        yield return [new int[][] { [4, 1] }, true];
        yield return [new int[][] { [4, 3] }, true];
        yield return [new int[][] { [1, 2] }, false];
        yield return [new int[][] { [2, 1] }, false];
        yield return [new int[][] { [2], [2] }, true];
        yield return [new int[][] { [4], [2] }, true];
        yield return [new int[][] { [4], [5] }, true];
        yield return [new int[][] { [1], [2] }, false];
        yield return [new int[][] { [2], [1] }, false];
        yield return [new int[][] { [4, 3], [5, 6] }, true];
        yield return [new int[][] { [4, 3], [2, 1] }, false];
        yield return [new int[][] { [4, 1], [2, 5] }, false];
        yield return [new int[][] { [2, 2], [2, 2] }, false];
        yield return [new int[][] { [3, 3], [3, 3] }, false];
        yield return [new int[][] { [4, 1, 3], [2, 6, 2], [6, 1, 5] }, true];
        yield return [new int[][] { [4, 3, 3], [6, 5, 2], [3, 1, 5] }, false];
        yield return [new int[][] { [4, 1, 1], [2, 1, 1], [6, 1, 5] }, true];
        yield return [new int[][] { [4, 1, 1, 1, 1, 1, 3] }, true];
        yield return [new int[][] { [2], [2], [2], [2], [4], [1], [5] }, false];
        yield return [new int[][] { [4], [2], [2], [2], [2], [2], [5] }, true];
        yield return [new int[][] { [4, 3] }, true];
        yield return [new int[][] { [2], [5] }, true];
        yield return [new int[][] { [1, 1, 1], [2, 2, 2], [1, 1, 1] }, false];
        yield return [new int[][] { [4, 3], [5, 6], [4, 3] }, false];
        yield return [new int[][] { [4, 1, 1, 1, 3], [2, 0, 0, 0, 2], [6, 1, 1, 1, 5] }, true];
        yield return [new int[][] { [4, 3, 0], [6, 5, 0] }, false];
        yield return [new int[][] { [4, 0, 3], [6, 0, 5] }, false];
        yield return [new int[][] { [0, 0], [0, 0] }, false];
        yield return [new int[][] { [6, 5, 2], [4, 1, 3], [3, 2, 6] }, false];
        yield return [new int[][] { [1, 1, 1, 1, 1, 1], [2, 2, 2, 2, 2, 2], [1, 1, 1, 1, 1, 1] }, false];
        yield return [new int[][] { [4, 1, 1], [2, 5, 1], [6, 1, 3] }, true];
        yield return [new int[][] { [1] }, true];
        yield return [new int[][] { [2, 1, 1, 1, 1, 5] }, false];
        yield return [new int[][] { [1, 2, 1, 2, 1], [2, 2, 2, 2, 2], [1, 2, 1, 2, 1] }, false];
        yield return [new int[][] { [4, 1], [2, 3] }, false];
        yield return [new int[][] { [4, 1], [4, 2] }, false];
        yield return [new int[][] { [4, 1], [6, 2] }, false];
        yield return [new int[][] { [6, 1, 1, 1, 5] }, true];
        yield return [new int[][] { [4, 3], [6, 2] }, true];
        yield return [new int[][] { [1, 1, 3], [1, 4, 5], [1, 6, 1] }, true];
    }
}