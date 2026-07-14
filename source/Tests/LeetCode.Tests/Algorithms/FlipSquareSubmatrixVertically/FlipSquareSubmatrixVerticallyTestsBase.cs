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

using LeetCode.Algorithms.FlipSquareSubmatrixVertically;

namespace LeetCode.Tests.Algorithms.FlipSquareSubmatrixVertically;

public abstract class FlipSquareSubmatrixVerticallyTestsBase<T> where T : IFlipSquareSubmatrixVertically, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void ReverseSubmatrix_WithInputSubmatrix_ReversesSubmatrixRowsVerticallyAndReturnsUpdatedMatrix(
        int[][] grid,
        int x,
        int y,
        int k,
        int[][] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ReverseSubmatrix(grid, x, y, k);

        // Assert
        Assert.AreEquivalent(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return
        [
            new[] { new[] { 1, 2, 3, 4 }, new[] { 5, 6, 7, 8 }, new[] { 9, 10, 11, 12 }, new[] { 13, 14, 15, 16 } },
            1,
            0,
            3,
            new[] { new[] { 1, 2, 3, 4 }, new[] { 13, 14, 15, 8 }, new[] { 9, 10, 11, 12 }, new[] { 5, 6, 7, 16 } }
        ];

        yield return [new[] { new[] { 3, 4, 2, 3 }, new[] { 2, 3, 4, 2 } }, 0, 2, 2, new[] { new[] { 3, 4, 4, 2 }, new[] { 2, 3, 2, 3 } }];

        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 } }, 0, 0, 1, new[] { new[] { 1, 2 }, new[] { 3, 4 } }];

        yield return
        [
            new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } },
            0,
            0,
            3,
            new[] { new[] { 7, 8, 9 }, new[] { 4, 5, 6 }, new[] { 1, 2, 3 } }
        ];

        yield return
        [
            new[] { new[] { 1, 2, 3, 4 }, new[] { 5, 6, 7, 8 }, new[] { 9, 10, 11, 12 } },
            0,
            1,
            2,
            new[] { new[] { 1, 6, 7, 4 }, new[] { 5, 2, 3, 8 }, new[] { 9, 10, 11, 12 } }
        ];
    }
}