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
    [DynamicData(nameof(TestData))]
    public void ZigzagTraversal_With2DGrid_ReturnsElementsInZigzagOrder(int[][] grid, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ZigzagTraversal(grid).ToArray();

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 } }, new[] { 1, 4 }];

        yield return [new[] { new[] { 2, 1 }, new[] { 2, 1 }, new[] { 2, 1 } }, new[] { 2, 1, 2 }];

        yield return [new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } }, new[] { 1, 3, 5, 7, 9 }];

        yield return [new[] { new[] { 42 } }, new[] { 42 }];

        yield return [new[] { new[] { 1, 2, 3, 4, 5 } }, new[] { 1, 3, 5 }];

        yield return [new[] { new[] { 1 }, new[] { 2 }, new[] { 3 }, new[] { 4 } }, new[] { 1, 3 }];

        yield return [new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 } }, new[] { 1, 3, 5 }];

        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 }, new[] { 5, 6 } }, new[] { 1, 4, 5 }];

        yield return [new[] { new[] { -1, -2 }, new[] { -3, -4 } }, new[] { -1, -4 }];

        yield return [new[] { new[] { 0, 0, 0 }, new[] { 0, 0, 0 } }, new[] { 0, 0, 0 }];

        yield return [new[] { new[] { 1, 2, 3, 4 }, new[] { 5, 6, 7, 8 }, new[] { 9, 10, 11, 12 }, new[] { 13, 14, 15, 16 } }, new[] { 1, 3, 8, 6, 9, 11, 16, 14 }];

        yield return [new[] { new[] { 10, 20, 30 }, new[] { 40, 50, 60 } }, new[] { 10, 30, 50 }];

        yield return [new[] { new[] { 1, 2, 3, 4, 5, 6 } }, new[] { 1, 3, 5 }];

        yield return [new[] { new[] { 1, 2, 3, 4, 5, 6 }, new[] { 7, 8, 9, 10, 11, 12 } }, new[] { 1, 3, 5, 12, 10, 8 }];

        yield return [new[] { new[] { 1, 2, 3, 4, 5 }, new[] { 6, 7, 8, 9, 10 } }, new[] { 1, 3, 5, 9, 7 }];
    }
}