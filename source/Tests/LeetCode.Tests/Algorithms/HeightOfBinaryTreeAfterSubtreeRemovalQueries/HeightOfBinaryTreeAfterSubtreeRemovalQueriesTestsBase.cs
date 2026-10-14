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

using LeetCode.Algorithms.HeightOfBinaryTreeAfterSubtreeRemovalQueries;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.HeightOfBinaryTreeAfterSubtreeRemovalQueries;

public abstract class HeightOfBinaryTreeAfterSubtreeRemovalQueriesTestsBase<T> where T : IHeightOfBinaryTreeAfterSubtreeRemovalQueries, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void TreeQueries_WithSubtreeRemovedAtGivenNode_ReturnsHeightOfTreeAfterRemoval(int?[] rootArray, int[] queries, int[] expectedResult)
    {
        // Arrange
        var root = TreeNode.ToTreeNodeOrThrow(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.TreeQueries(root, queries);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new int?[] { 1, 3, 4, 2, null, 6, 5, null, null, null, null, null, 7 }, new[] { 4 }, new[] { 2 }];

        yield return [new int?[] { 5, 8, 9, 2, 1, 3, 7, 4, 6 }, new[] { 3, 2, 4, 8 }, new[] { 3, 2, 3, 2 }];

        yield return [new int?[] { 1, null, 5, 3, null, 2, 4 }, new[] { 3, 5, 4, 2, 4 }, new[] { 1, 0, 3, 3, 3 }];

        yield return [new int?[] { 1, null, 2 }, new[] { 2 }, new[] { 0 }];

        yield return [new int?[] { 2, 1, null, 3 }, new[] { 3, 1 }, new[] { 1, 0 }];

        yield return [new int?[] { 1, null, 2, null, 3 }, new[] { 3, 2 }, new[] { 1, 0 }];

        yield return [new int?[] { 3, 2, null, null, 1 }, new[] { 1, 2 }, new[] { 1, 0 }];

        yield return [new int?[] { 2, 4, 3, null, 1 }, new[] { 1, 4, 3 }, new[] { 1, 1, 2 }];

        yield return [new int?[] { 1, 4, null, 3, null, 2, null, 5 }, new[] { 3, 2, 4, 5 }, new[] { 1, 2, 0, 3 }];

        yield return [new int?[] { 5, null, 1, null, 2, null, 3, null, 4 }, new[] { 4, 1, 2, 3 }, new[] { 3, 0, 1, 2 }];

        yield return [new int?[] { 2, 6, 5, 3, 4, null, null, null, null, 1 }, new[] { 4, 6, 3, 5, 1 }, new[] { 2, 1, 3, 3, 2 }];

        yield return [new int?[] { 4, 7, 1, null, null, 2, 3, null, null, 6, null, 5 }, new[] { 6, 2, 1, 7, 5, 3 }, new[] { 2, 4, 1, 4, 3, 2 }];

        yield return [new int?[] { 2, 7, 8, null, 5, null, 6, 3, null, 1, null, 4 }, new[] { 4, 7, 1, 6, 8, 5, 3 }, new[] { 3, 3, 4, 4, 4, 3, 3 }];

        yield return [new int?[] { 9, 5, 2, 4, 1, null, null, 3, null, null, 7, null, null, 8, null, 6 }, new[] { 1, 3, 8, 2, 5, 6, 4, 7 }, new[] { 3, 5, 3, 5, 1, 4, 5, 3 }];

        yield return [new int?[] { 6, 2, 7, null, null, 9, 8, 5, 3, null, null, 1, null, 10, 4 }, new[] { 5, 10, 1, 9, 7, 2, 4, 3, 8 }, new[] { 4, 4, 4, 2, 1, 4, 4, 4, 4 }];

        yield return [new int?[] { 6, 10, null, null, 3, 9, 12, null, null, 1, 5, 11, 7, 4, null, null, null, 8, null, null, 2 }, new[] { 9, 10, 4, 5, 3, 8, 2, 12, 1, 7, 11 }, new[] { 6, 0, 6, 6, 1, 6, 6, 3, 6, 6, 6 }];

        yield return [new int?[] { 5, 15, 13, null, 1, 10, 7, 4, null, null, null, 9, 2, null, null, null, 14, 8, 11, null, null, null, null, 12, null, 3, 6 }, new[] { 7, 2, 6, 12, 11, 9, 1, 8, 3, 15, 4, 10, 14, 13 }, new[] { 3, 4, 6, 4, 4, 6, 6, 6, 6, 6, 6, 6, 6, 3 }];

        yield return [new int?[] { 6, 5, 8, 1, 15, 11, null, 9, 2, 7, 3, 13, 16, null, null, null, null, null, null, 10, null, null, null, 14, null, null, 4, null, null, 12 }, new[] { 8, 9, 7, 11, 16, 5, 13, 1, 3, 2, 10, 12, 15, 14, 4 }, new[] { 6, 6, 6, 6, 6, 4, 6, 6, 4, 6, 4, 5, 4, 6, 4 }];

        yield return [new int?[] { 10, 20, 6, 4, null, 1, 11, null, null, 5, 14, null, null, 12, 7, null, 19, 13, null, 9, 18, 8, 17, null, null, 15, null, null, null, null, 3, null, null, null, null, 2, null, 16 }, new[] { 2, 6, 5, 15, 7, 11, 16, 17, 18, 19, 9, 4, 12, 8, 3, 14, 13, 1, 20 }, new[] { 6, 2, 8, 8, 8, 8, 7, 8, 8, 6, 8, 8, 8, 6, 6, 6, 8, 2, 8 }];

        yield return [new int?[] { 24, 12, 8, 13, 15, 9, 10, null, 18, 11, 6, 4, 7, 1, 22, null, null, null, 21, null, null, 17, null, null, 5, 2, 3, null, null, null, null, null, 25, null, null, 14, null, 16, null, null, null, 19, 23, null, null, 20 }, new[] { 20, 25, 4, 2, 5, 10, 11, 1, 12, 16, 13, 15, 22, 8, 9, 23, 18, 14, 21, 19, 7, 3, 6, 17 }, new[] { 6, 7, 7, 5, 7, 5, 7, 5, 7, 7, 7, 7, 7, 4, 7, 7, 7, 5, 7, 6, 7, 7, 7, 7 }];
    }
}