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

using LeetCode.Algorithms.PathSum2;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.PathSum2;

public abstract class PathSum2TestsBase<T> where T : IPathSum2, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void PathSum_WithBinaryTreeAndTargetSum_ReturnsAllRootToLeafPathsThatSumToTarget(
        int?[] rootArray,
        int targetSum,
        IList<IList<int>> expectedResult)
    {
        // Arrange
        var root = TreeNode.ToTreeNode(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.PathSum(root, targetSum);

        // Assert
        Assert.AreEquivalent(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [Array.Empty<int?>(), 0, Array.Empty<IList<int>>()];

        yield return
        [
            new int?[] { 5, 4, 8, 11, null, 13, 4, 7, 2, null, null, 5, 1 }, 22, new IList<int>[] { new[] { 5, 4, 11, 2 }, new[] { 5, 8, 4, 5 } }
        ];

        yield return [new int?[] { 1, 2, 3 }, 5, Array.Empty<IList<int>>()];

        yield return [new int?[] { 1, 2 }, 0, Array.Empty<IList<int>>()];

        yield return [new int?[] { 1, 2, 3 }, 3, new IList<int>[] { new[] { 1, 2 } }];

        yield return [new int?[] { 1, -2, -3, 1, 3, -2, null, -1 }, -1, new IList<int>[] { new[] { 1, -2, 1, -1 } }];

        yield return [new int?[] { 1 }, 1, new IList<int>[] { new[] { 1 } }];

        yield return [new int?[] { 1, 2 }, 1, Array.Empty<IList<int>>()];

        yield return [new int?[] { 1, 2, null, 3 }, 6, new IList<int>[] { new[] { 1, 2, 3 } }];

        yield return [new int?[] { 1, 2, null, 3, 4 }, 7, new IList<int>[] { new[] { 1, 2, 4 } }];

        yield return [new int?[] { 5, 4, 8, 11, null, 13, 4, 7, 2, null, null, 5, 1, 6, 9 }, 30, Array.Empty<IList<int>>()];

        yield return [new int?[] { 5, 4, 8, 11, null, 13, 4, 7, 2, null, null, 5, 1 }, 26, new IList<int>[] { new[] { 5, 8, 13 } }];

        yield return [new int?[] { 10, 5, -3, 3, 2, 11, 3, -2, 1 }, 18, new IList<int>[] { new[] { 10, -3, 11 } }];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7 }, 7, new IList<int>[] { new[] { 1, 2, 4 } }];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7 }, 11, new IList<int>[] { new[] { 1, 3, 7 } }];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7 }, 100, Array.Empty<IList<int>>()];

        yield return [new int?[] { 1, 2, 3 }, 4, new IList<int>[] { new[] { 1, 3 } }];

        yield return [new int?[] { 5, 1, 2 }, 6, new IList<int>[] { new[] { 5, 1 } }];

        yield return [new int?[] { 5, 1, 2 }, 7, new IList<int>[] { new[] { 5, 2 } }];

        yield return [new int?[] { 5, 1, 2 }, 100, Array.Empty<IList<int>>()];

        yield return [new int?[] { 3, 9, 20, null, null, 15, 7 }, 12, new IList<int>[] { new[] { 3, 9 } }];

        yield return [new int?[] { 3, 9, 20, null, null, 15, 7 }, 38, new IList<int>[] { new[] { 3, 20, 15 } }];

        yield return [new int?[] { 3, 9, 20, null, null, 15, 7 }, 30, new IList<int>[] { new[] { 3, 20, 7 } }];

        yield return [new int?[] { 1, -2, 3 }, -1, new IList<int>[] { new[] { 1, -2 } }];

        yield return [new int?[] { 1, -2, 3 }, 4, new IList<int>[] { new[] { 1, 3 } }];

        yield return [new int?[] { 2, 3, 4, 5, null, null, 6 }, 10, new IList<int>[] { new[] { 2, 3, 5 } }];

        yield return [new int?[] { 2, 3, 4, 5, null, null, 6 }, 12, new IList<int>[] { new[] { 2, 4, 6 } }];

        yield return [new int?[] { 1, 2 }, 3, new IList<int>[] { new[] { 1, 2 } }];

        yield return [new int?[] { 1, null, 2 }, 3, new IList<int>[] { new[] { 1, 2 } }];

        yield return [new int?[] { 7, 3, 15, null, null, 9, 20 }, 31, new IList<int>[] { new[] { 7, 15, 9 } }];

        yield return [new int?[] { 7, 3, 15, null, null, 9, 20 }, 42, new IList<int>[] { new[] { 7, 15, 20 } }];

        yield return [new int?[] { 7, 3, 15, null, null, 9, 20 }, 10, new IList<int>[] { new[] { 7, 3 } }];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 15, new IList<int>[] { new[] { 1, 2, 4, 8 } }];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 8, new IList<int>[] { new[] { 1, 2, 5 } }];

        yield return [new int?[] { 0, 1, 2 }, 1, new IList<int>[] { new[] { 0, 1 } }];

        yield return [new int?[] { 0, 1, 2 }, 2, new IList<int>[] { new[] { 0, 2 } }];
    }
}