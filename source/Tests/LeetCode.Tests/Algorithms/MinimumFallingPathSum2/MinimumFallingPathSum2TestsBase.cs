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

using LeetCode.Algorithms.MinimumFallingPathSum2;

namespace LeetCode.Tests.Algorithms.MinimumFallingPathSum2;

public abstract class MinimumFallingPathSum2TestsBase<T> where T : IMinimumFallingPathSum2, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MinFallingPathSum_WithGridJson_ReturnsMinimumFallingPathSum(int[][] grid, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinFallingPathSum(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } }, 13];

        yield return [new[] { new[] { 7 } }, 7];

        yield return [new[] { new[] { -99 } }, -99];

        yield return [new[] { new[] { 99 } }, 99];

        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 } }, 5];

        yield return [new[] { new[] { -5, 5 }, new[] { 5, -5 } }, -10];

        yield return [new[] { new[] { 0, 0 }, new[] { 0, 0 } }, 0];

        yield return [new[] { new[] { 1, 1, 1 }, new[] { 1, 1, 1 }, new[] { 1, 1, 1 } }, 3];

        yield return [new[] { new[] { -1, -2, -3 }, new[] { -4, -5, -6 }, new[] { -7, -8, -9 } }, -17];

        yield return [new[] { new[] { 99, -99 }, new[] { -99, 99 } }, -198];

        yield return [new[] { new[] { -47, -3, 25 }, new[] { -46, 14, 31 }, new[] { -98, 16, -33 } }, -131];

        yield return [new[] { new[] { 2, 10, 67, 64 }, new[] { 50, 77, -87, 82 }, new[] { 96, 96, 15, 35 }, new[] { -84, 95, 0, 90 } }, -134];

        yield return [new[] { new[] { 39, 5, 83, 16 }, new[] { 20, 53, -81, -32 }, new[] { -24, -57, 94, -91 }, new[] { -9, 73, 91, -22 } }, -176];

        yield return [new[] { new[] { -72, 73, 44, 93, 24 }, new[] { -53, -90, 32, -31, 96 }, new[] { -42, -56, -85, 46, -17 }, new[] { 42, -75, 1, 16, -73 }, new[] { 55, -48, 3, 31, -22 } }, -368];

        yield return [new[] { new[] { -96, 71, 87, 89, 94 }, new[] { -95, -5, 61, -38, -62 }, new[] { -74, 26, 76, 4, 34 }, new[] { -43, -65, 78, -5, -49 }, new[] { -97, -41, 91, 46, 7 } }, -394];

        yield return [new[] { new[] { 26, -22, -81, -42, -80, 19 }, new[] { -31, -72, -74, -41, -22, -47 }, new[] { 55, -10, 39, -35, -40, -58 }, new[] { 37, 33, -68, -38, -66, -94 }, new[] { 44, -34, -19, 85, 88, 35 }, new[] { 92, 2, 28, -67, -97, -93 } }, -419];

        yield return [new[] { new[] { -57, 3, -65, -26, -23, 88, -76 }, new[] { -4, 19, -94, 17, 67, 44, 9 }, new[] { -1, 29, -62, -15, -86, 80, 67 }, new[] { 99, -47, -68, -50, 19, -50, -77 }, new[] { 79, -71, 78, -61, -77, -80, 64 }, new[] { -41, -3, 52, -54, -26, -80, 65 }, new[] { -66, 99, -97, 41, -38, 45, 31 } }, -587];

        yield return [new[] { new[] { 9, 1, 9, 9 }, new[] { 9, 9, 1, 9 }, new[] { 1, 9, 9, 9 }, new[] { 9, 9, 9, 1 } }, 4];

        yield return [CreateGrid(200, 99), 19800];

        yield return [CreateGrid(200, -99), -19800];
    }

    private static int[][] CreateGrid(int size, int value)
    {
        var grid = new int[size][];

        for (var i = 0; i < size; i++)
        {
            grid[i] = new int[size];

            for (var j = 0; j < size; j++)
            {
                grid[i][j] = value;
            }
        }

        return grid;
    }
}