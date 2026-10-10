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
        var actualList = solution.ZigzagTraversal(grid);

        var actualResult = new int[actualList.Count];

        actualList.CopyTo(actualResult, 0);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 }, new[] { 5, 6 }, new[] { 7, 8 } }, new[] { 1, 4, 5, 8 }];
        yield return [new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } }, new[] { 1, 3, 5, 7, 9 }];
        yield return [new[] { new[] { 1 } }, new[] { 1 }];
        yield return [new[] { new[] { 1, 2, 3, 4 } }, new[] { 1, 3 }];
        yield return [new[] { new[] { 1, 2, 3, 4, 5 } }, new[] { 1, 3, 5 }];
        yield return [new[] { new[] { 1, 2 } }, new[] { 1 }];
        yield return
        [
            new[] { new[] { 1, 2, 3, 4 }, new[] { 5, 6, 7, 8 }, new[] { 9, 10, 11, 12 }, new[] { 13, 14, 15, 16 } },
            new[] { 1, 3, 8, 6, 9, 11, 16, 14 }
        ];
        yield return [new[] { new[] { 1, 2, 3, 4, 5 }, new[] { 6, 7, 8, 9, 10 } }, new[] { 1, 3, 5, 9, 7 }];
        yield return [new[] { new[] { 4 }, new[] { 5 }, new[] { 6 } }, new[] { 4, 6 }];
        yield return [new[] { new[] { 0, 0, 0 }, new[] { 0, 0, 0 } }, new[] { 0, 0, 0 }];
        yield return [new[] { new[] { 7, 8, 9, 10 } }, new[] { 7, 9 }];
        yield return [new[] { new[] { 1 }, new[] { 2 } }, new[] { 1 }];
        yield return [new[] { new[] { 1 }, new[] { 2 }, new[] { 3 }, new[] { 4 } }, new[] { 1, 3 }];
        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 } }, new[] { 1, 4 }];
        yield return [new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 } }, new[] { 1, 3, 5 }];
        yield return [new[] { new[] { 1, 2, 3, 4 }, new[] { 5, 6, 7, 8 } }, new[] { 1, 3, 8, 6 }];
        yield return [new[] { new[] { 1, 2, 3, 4, 5 }, new[] { 6, 7, 8, 9, 10 }, new[] { 11, 12, 13, 14, 15 } }, new[] { 1, 3, 5, 9, 7, 11, 13, 15 }];
        yield return [new[] { new[] { 9, 8 }, new[] { 7, 6 }, new[] { 5, 4 } }, new[] { 9, 6, 5 }];
        yield return [new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 }, new[] { 10, 11, 12 } }, new[] { 1, 3, 5, 7, 9, 11 }];
        yield return [new[] { new[] { 1, 2, 3, 4, 5, 6 }, new[] { 7, 8, 9, 10, 11, 12 } }, new[] { 1, 3, 5, 12, 10, 8 }];
        yield return [new[] { new[] { 100, 200 }, new[] { 300, 400 }, new[] { 500, 600 } }, new[] { 100, 400, 500 }];
        yield return [new[] { new[] { 1, 2, 3, 4 }, new[] { 5, 6, 7, 8 }, new[] { 9, 10, 11, 12 } }, new[] { 1, 3, 8, 6, 9, 11 }];
        yield return [new[] { new[] { 1, 2, 3, 4, 5, 6, 7 }, new[] { 8, 9, 10, 11, 12, 13, 14 }, new[] { 15, 16, 17, 18, 19, 20, 21 }, new[] { 22, 23, 24, 25, 26, 27, 28 }, new[] { 29, 30, 31, 32, 33, 34, 35 } }, new[] { 1, 3, 5, 7, 13, 11, 9, 15, 17, 19, 21, 27, 25, 23, 29, 31, 33, 35 }];
    }
}