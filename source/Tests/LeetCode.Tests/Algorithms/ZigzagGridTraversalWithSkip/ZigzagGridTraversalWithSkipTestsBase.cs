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

using LeetCode.Algorithms.ZigzagGridTraversalWithSkip;

namespace LeetCode.Tests.Algorithms.ZigzagGridTraversalWithSkip;

public abstract class ZigzagGridTraversalWithSkipTestsBase<T> where T : IZigzagGridTraversalWithSkip, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void ZigzagTraversal_With2DGrid_ReturnsElementsInZigzagOrder(int[][] grid, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ZigzagTraversal(grid).ToArray();

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        // Row 0 (even, L→R skip): [1] | Row 1 (odd, R→L skip): [4] | Row 2 (even): [5] | Row 3 (odd): [8]
        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 }, new[] { 5, 6 }, new[] { 7, 8 } }, new[] { 1, 4, 5, 8 }];

        // Row 0: [1,3] | Row 1 (odd, len=3 odd → start=1): [5] | Row 2: [7,9]
        yield return [new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } }, new[] { 1, 3, 5, 7, 9 }];

        // Single element grid
        yield return [new[] { new[] { 1 } }, new[] { 1 }];

        // Single row, even length: j=0,2 → [1,3]
        yield return [new[] { new[] { 1, 2, 3, 4 } }, new[] { 1, 3 }];

        // Single row, odd length: j=0,2,4 → [1,3,5]
        yield return [new[] { new[] { 1, 2, 3, 4, 5 } }, new[] { 1, 3, 5 }];

        // Single row, length 2: j=0 → [1]
        yield return [new[] { new[] { 1, 2 } }, new[] { 1 }];

        // 4×4 grid: row0→[1,3] | row1→[8,6] | row2→[9,11] | row3→[16,14]
        yield return [new[] { new[] { 1, 2, 3, 4 }, new[] { 5, 6, 7, 8 }, new[] { 9, 10, 11, 12 }, new[] { 13, 14, 15, 16 } }, new[] { 1, 3, 8, 6, 9, 11, 16, 14 }];

        // Two rows, odd-length: row0→[1,3,5] | row1 (len=5 odd, start=3): [9,7]
        yield return [new[] { new[] { 1, 2, 3, 4, 5 }, new[] { 6, 7, 8, 9, 10 } }, new[] { 1, 3, 5, 9, 7 }];

        // Single-element rows: odd row (len=1, start=0 → start-- = -1) is skipped entirely → [4, 6]
        yield return [new[] { new[] { 4 }, new[] { 5 }, new[] { 6 } }, new[] { 4, 6 }];

        // All zeros
        yield return [new[] { new[] { 0, 0, 0 }, new[] { 0, 0, 0 } }, new[] { 0, 0, 0 }];
    }
}