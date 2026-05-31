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

using LeetCode.Algorithms.FindTheMinimumAreaToCoverAllOnes2;

namespace LeetCode.Tests.Algorithms.FindTheMinimumAreaToCoverAllOnes2;

public abstract class FindTheMinimumAreaToCoverAllOnes2TestsBase<T> where T : IFindTheMinimumAreaToCoverAllOnes2, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MinimumSum_WithBinaryGrid_ReturnsMinimumSumOfRectanglesArea(int[][] grid, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimumSum(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 0, 1 }, new[] { 1, 1, 1 } }, 5];

        yield return [new[] { new[] { 1, 0, 1, 0 }, new[] { 0, 1, 0, 1 } }, 5];

        // Single 1 in entire grid
        yield return [new[] { new[] { 1 } }, 1];

        // Single row with separated 1s
        yield return [new[] { new[] { 1, 0, 0, 1 } }, 1];

        // 3x3 grid: three 1s in corners
        yield return [new[] { new[] { 1, 0, 1 }, new[] { 0, 0, 0 }, new[] { 1, 0, 0 } }, 3];

        // 3x3 grid: all 1s (single rectangle)
        yield return [new[] { new[] { 1, 1, 1 }, new[] { 1, 1, 1 }, new[] { 1, 1, 1 } }, 9];

        // 4x4: three clusters separated by rows
        yield return [new[] { new[] { 1, 0, 0, 0 }, new[] { 0, 0, 0, 0 }, new[] { 0, 0, 0, 1 }, new[] { 0, 0, 0, 0 } }, 2];

        // Tall grid: 1s in top row, middle row, bottom row
        yield return [new[] { new[] { 1, 0 }, new[] { 0, 0 }, new[] { 0, 1 }, new[] { 0, 0 }, new[] { 1, 0 } }, 3];

        // 2x4: two separate columns of 1s
        yield return [new[] { new[] { 1, 0, 0, 1 }, new[] { 1, 0, 0, 1 } }, 4];

        // 3x4: diagonal-like 1s
        yield return [new[] { new[] { 1, 0, 0, 0 }, new[] { 0, 1, 0, 0 }, new[] { 0, 0, 1, 0 } }, 3];

        // 2x3: two 1s sharing a column
        yield return [new[] { new[] { 1, 0, 0 }, new[] { 1, 0, 0 } }, 2];

        // 3x3: L-shaped 1s
        yield return [new[] { new[] { 1, 0, 0 }, new[] { 1, 0, 0 }, new[] { 1, 1, 1 } }, 6];

        // 4x4: 1s in each quadrant
        yield return [new[] { new[] { 1, 0, 1, 0 }, new[] { 0, 0, 0, 0 }, new[] { 1, 0, 1, 0 }, new[] { 0, 0, 0, 0 } }, 4];

        // 3x6: three groups in different columns
        yield return [new[] { new[] { 1, 0, 1, 0, 1, 0 }, new[] { 0, 0, 0, 0, 0, 0 }, new[] { 0, 0, 0, 0, 0, 0 } }, 3];

        // 4x3: vertical splits
        yield return [new[] { new[] { 1, 0, 1 }, new[] { 0, 0, 0 }, new[] { 0, 0, 0 }, new[] { 1, 0, 0 } }, 3];

        // 2x2: single 1 in corner
        yield return [new[] { new[] { 1, 0 }, new[] { 0, 0 } }, 1];

        // 3x3: two 1s same row ends
        yield return [new[] { new[] { 1, 0, 1 }, new[] { 0, 0, 0 }, new[] { 0, 0, 0 } }, 1];

        // 4x4: 1s in three corners
        yield return [new[] { new[] { 1, 0, 0, 1 }, new[] { 0, 0, 0, 0 }, new[] { 0, 0, 0, 0 }, new[] { 1, 0, 0, 0 } }, 5];

        // 3x4: two adjacent 1s in two separate rows
        yield return [new[] { new[] { 1, 1, 0, 0 }, new[] { 0, 0, 0, 0 }, new[] { 0, 0, 1, 1 } }, 4];

        // 5x5: 1s at corners
        yield return [new[] { new[] { 1, 0, 0, 0, 1 }, new[] { 0, 0, 0, 0, 0 }, new[] { 0, 0, 0, 0, 0 }, new[] { 0, 0, 0, 0, 0 }, new[] { 1, 0, 0, 0, 1 } }, 12];
    }
}