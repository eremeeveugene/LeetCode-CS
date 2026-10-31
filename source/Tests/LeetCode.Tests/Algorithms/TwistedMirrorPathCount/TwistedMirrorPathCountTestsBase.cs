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

using LeetCode.Algorithms.TwistedMirrorPathCount;

namespace LeetCode.Tests.Algorithms.TwistedMirrorPathCount;

public abstract class TwistedMirrorPathCountTestsBase<T> where T : ITwistedMirrorPathCount, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void UniquePaths_WithGrid_ReturnsNumberOfValidPaths(int[][] grid, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.UniquePaths(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 0, 1, 0 }, new[] { 0, 0, 1 }, new[] { 1, 0, 0 } }, 5];

        yield return [new[] { new[] { 0, 0 }, new[] { 0, 0 } }, 2];

        yield return [new[] { new[] { 0, 1, 1 }, new[] { 1, 1, 0 } }, 1];

        yield return [new[] { new[] { 0, 1 }, new[] { 0, 0 } }, 2];

        yield return [new[] { new[] { 0, 0 }, new[] { 1, 0 } }, 2];

        yield return [new[] { new[] { 0, 1 }, new[] { 1, 0 } }, 2];

        yield return [new[] { new[] { 0, 0, 0 }, new[] { 0, 0, 0 } }, 3];

        yield return [new[] { new[] { 0, 0 }, new[] { 0, 0 }, new[] { 0, 0 } }, 3];

        yield return [new[] { new[] { 0, 0, 0 }, new[] { 0, 0, 0 }, new[] { 0, 0, 0 } }, 6];

        yield return [new[] { new[] { 0, 1, 0 }, new[] { 0, 1, 0 } }, 1];

        yield return [new[] { new[] { 0, 0, 0 }, new[] { 1, 1, 0 } }, 2];

        yield return [new[] { new[] { 0, 0, 1 }, new[] { 0, 0, 0 } }, 3];

        yield return [new[] { new[] { 0, 0, 0 }, new[] { 0, 0, 1 }, new[] { 0, 0, 0 } }, 5];

        yield return [new[] { new[] { 0, 1, 0 }, new[] { 1, 0, 1 }, new[] { 0, 1, 0 } }, 4];

        yield return [new[] { new[] { 0, 0, 1 }, new[] { 1, 0, 0 }, new[] { 0, 1, 0 } }, 5];

        yield return [new[] { new[] { 0, 1 }, new[] { 1, 1 }, new[] { 1, 0 } }, 1];

        yield return [new[] { new[] { 0, 0 }, new[] { 1, 1 }, new[] { 0, 0 } }, 1];

        yield return [new[] { new[] { 0, 1, 1 }, new[] { 0, 1, 1 }, new[] { 0, 0, 0 } }, 3];

        yield return [new[] { new[] { 0, 1, 1, 1 }, new[] { 1, 1, 1, 1 }, new[] { 1, 1, 1, 0 } }, 1];

        yield return [new[] { new[] { 0, 0, 0, 0 }, new[] { 0, 1, 1, 0 }, new[] { 0, 1, 1, 0 }, new[] { 0, 0, 0, 0 } }, 6];

        yield return [new[] { new[] { 0, 1, 0, 0 }, new[] { 0, 0, 1, 0 }, new[] { 1, 0, 0, 1 }, new[] { 0, 1, 0, 0 } }, 13];

        yield return [new[] { new[] { 0, 0, 0, 1 }, new[] { 1, 0, 0, 0 }, new[] { 0, 0, 1, 0 }, new[] { 0, 1, 0, 0 } }, 11];

        yield return [new[] { new[] { 0, 1, 0, 1, 0 }, new[] { 1, 0, 1, 0, 1 }, new[] { 0, 1, 0, 1, 0 } }, 0];

        yield return
        [
            new[] { new[] { 0, 0, 0, 0, 0 }, new[] { 0, 0, 0, 0, 0 }, new[] { 0, 0, 0, 0, 0 }, new[] { 0, 0, 0, 0, 0 }, new[] { 0, 0, 0, 0, 0 } },
            70
        ];

        yield return [CreateEmptyGrid(2, 500), 500];

        yield return [CreateEmptyGrid(500, 2), 500];

        yield return [CreateEmptyGrid(20, 20), 345263555];

        yield return [CreateEmptyGrid(500, 500), 264223182];
    }

    private static int[][] CreateEmptyGrid(int m, int n)
    {
        var grid = new int[m][];

        for (var i = 0; i < m; i++)
        {
            grid[i] = new int[n];
        }

        return grid;
    }
}