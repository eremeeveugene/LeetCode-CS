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

using LeetCode.Algorithms.CreateGridWithExactlyOnePath;

namespace LeetCode.Tests.Algorithms.CreateGridWithExactlyOnePath;

public abstract class CreateGridWithExactlyOnePathTestsBase<T> where T : ICreateGridWithExactlyOnePath, new()
{
    [TestMethod]
    [DataRow(1, 1)]
    [DataRow(1, 2)]
    [DataRow(2, 1)]
    [DataRow(2, 2)]
    [DataRow(2, 3)]
    [DataRow(3, 2)]
    [DataRow(3, 3)]
    [DataRow(1, 4)]
    [DataRow(4, 1)]
    [DataRow(4, 6)]
    [DataRow(6, 4)]
    [DataRow(5, 5)]
    [DataRow(3, 7)]
    [DataRow(7, 3)]
    [DataRow(1, 25)]
    [DataRow(25, 1)]
    [DataRow(2, 25)]
    [DataRow(25, 2)]
    [DataRow(13, 17)]
    [DataRow(20, 20)]
    [DataRow(24, 25)]
    [DataRow(25, 24)]
    [DataRow(25, 25)]
    public void CreateGrid_WithDimensions_ReturnsGridWithExactlyOnePath(int m, int n)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CreateGrid(m, n);

        // Assert
        Assert.HasCount(m, actualResult);

        foreach (var row in actualResult)
        {
            Assert.AreEqual(n, row.Length);
        }

        Assert.AreEqual('.', actualResult[0][0]);
        Assert.AreEqual('.', actualResult[m - 1][n - 1]);
        Assert.AreEqual(1, CountValidPaths(actualResult, m, n));
    }

    private static int CountValidPaths(string[] grid, int m, int n)
    {
        var pathCounts = new int[m, n];

        pathCounts[0, 0] = grid[0][0] == '.' ? 1 : 0;

        for (var row = 0; row < m; row++)
        {
            for (var column = 0; column < n; column++)
            {
                if (grid[row][column] == '#' || (row == 0 && column == 0))
                {
                    continue;
                }

                var fromTop = row > 0 ? pathCounts[row - 1, column] : 0;
                var fromLeft = column > 0 ? pathCounts[row, column - 1] : 0;

                pathCounts[row, column] = Math.Min(fromTop + fromLeft, 2);
            }
        }

        return pathCounts[m - 1, n - 1];
    }
}