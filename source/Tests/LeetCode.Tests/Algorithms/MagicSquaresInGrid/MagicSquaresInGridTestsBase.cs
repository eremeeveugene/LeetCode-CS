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

using LeetCode.Algorithms.MagicSquaresInGrid;

namespace LeetCode.Tests.Algorithms.MagicSquaresInGrid;

public abstract class MagicSquaresInGridTestsBase<T> where T : IMagicSquaresInGrid, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void NumMagicSquaresInside_WithGridInput_ReturnsCountOfMagicSquareSubgrids(int[][] grid, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumMagicSquaresInside(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 8 } }, 0];

        yield return [new[] { new[] { 1, 1, 1 }, new[] { 1, 1, 1 }, new[] { 1, 1, 1 } }, 0];

        yield return [new[] { new[] { 5, 5, 5 }, new[] { 5, 5, 5 }, new[] { 5, 5, 5 } }, 0];

        yield return [new[] { new[] { 7, 0, 5 }, new[] { 2, 4, 6 }, new[] { 3, 8, 1 } }, 0];

        yield return [new[] { new[] { 4, 3, 8, 4 }, new[] { 9, 5, 1, 9 }, new[] { 2, 7, 6, 2 } }, 1];

        yield return [new[] { new[] { 4, 3, 8, 4 }, new[] { 9, 5, 1, 9 }, new[] { 2, 7, 6, 2 }, new[] { 4, 3, 8, 1 }, new[] { 1, 6, 7, 5 } }, 1];

        yield return [new[] { new[] { 9, 9, 5, 1, 9, 5, 5, 7, 2, 5 }, new[] { 9, 1, 8, 3, 4, 6, 7, 2, 8, 9 }, new[] { 4, 1, 1, 5, 9, 1, 5, 9, 6, 4 }, new[] { 5, 5, 6, 7, 2, 8, 3, 4, 0, 6 }, new[] { 1, 9, 1, 8, 3, 1, 4, 2, 9, 4 }, new[] { 2, 8, 6, 4, 2, 7, 3, 2, 7, 6 }, new[] { 9, 2, 5, 0, 7, 8, 2, 9, 5, 1 }, new[] { 2, 1, 4, 4, 7, 6, 2, 4, 3, 8 }, new[] { 1, 2, 5, 3, 0, 5, 10, 8, 5, 2 }, new[] { 6, 9, 6, 8, 8, 4, 3, 6, 0, 9 } }, 3];

        // Center not 5
        yield return [new[] { new[] { 4, 9, 2 }, new[] { 3, 1, 7 }, new[] { 8, 5, 6 } }, 0];

        // Lo Shu rotated 90 degrees: 4,3,8 / 9,5,1 / 2,7,6 - same as row 0 but as 3x3
        yield return [new[] { new[] { 4, 3, 8 }, new[] { 9, 5, 1 }, new[] { 2, 7, 6 } }, 1];

        // Lo Shu reflected
        yield return [new[] { new[] { 2, 7, 6 }, new[] { 9, 5, 1 }, new[] { 4, 3, 8 } }, 1];

        // Center equals top-middle (fail line 47)
        yield return [new[] { new[] { 2, 5, 6 }, new[] { 9, 5, 1 }, new[] { 4, 3, 8 } }, 0];

        // Center equals left-middle (fail line 47)
        yield return [new[] { new[] { 2, 7, 6 }, new[] { 5, 5, 1 }, new[] { 4, 3, 8 } }, 0];

        // Value > 9
        yield return [new[] { new[] { 2, 7, 6 }, new[] { 9, 5, 10 }, new[] { 4, 3, 8 } }, 0];

        // Duplicate value (8 twice)
        yield return [new[] { new[] { 8, 7, 6 }, new[] { 9, 5, 1 }, new[] { 4, 3, 8 } }, 0];

        // Row sum wrong - 2,7,7 = 16
        yield return [new[] { new[] { 2, 7, 7 }, new[] { 9, 5, 1 }, new[] { 4, 3, 8 } }, 0];

        // 4x4 with magic at top-left
        yield return [new[] { new[] { 4, 3, 8, 0 }, new[] { 9, 5, 1, 0 }, new[] { 2, 7, 6, 0 }, new[] { 0, 0, 0, 0 } }, 1];

        // Grid with no rotation valid - 5x5
        yield return [new[] { new[] { 1, 2, 3, 4, 5 }, new[] { 6, 7, 8, 9, 0 }, new[] { 1, 2, 3, 4, 5 }, new[] { 6, 7, 8, 9, 0 }, new[] { 1, 2, 3, 4, 5 } }, 0];

        // 2x2 - too small, no 3x3 inside
        yield return [new[] { new[] { 4, 3 }, new[] { 9, 5 } }, 0];

        // 3x2 - too small
        yield return [new[] { new[] { 4, 3 }, new[] { 9, 5 }, new[] { 2, 7 } }, 0];

        // 2x3 - too small
        yield return [new[] { new[] { 4, 3, 8 }, new[] { 9, 5, 1 } }, 0];

        // Value = 0 (invalid)
        yield return [new[] { new[] { 4, 3, 8 }, new[] { 9, 5, 1 }, new[] { 0, 7, 6 } }, 0];

        // 3x6 grid with two magic squares side by side
        yield return [new[] { new[] { 4, 3, 8, 4, 3, 8 }, new[] { 9, 5, 1, 9, 5, 1 }, new[] { 2, 7, 6, 2, 7, 6 } }, 2];

        // 5x3 grid with one magic
        yield return [new[] { new[] { 4, 3, 8 }, new[] { 9, 5, 1 }, new[] { 2, 7, 6 }, new[] { 9, 5, 1 }, new[] { 2, 7, 6 } }, 1];

        // All center 5 but invalid
        yield return [new[] { new[] { 1, 1, 1 }, new[] { 1, 5, 1 }, new[] { 1, 1, 1 } }, 0];
    }
}