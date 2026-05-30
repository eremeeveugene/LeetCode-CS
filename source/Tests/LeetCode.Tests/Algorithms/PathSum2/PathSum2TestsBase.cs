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
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.PathSum2;

public abstract class PathSum2TestsBase<T> where T : IPathSum2, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void PathSum_WithBinaryTreeAndTargetSum_ReturnsAllRootToLeafPathsThatSumToTarget(int?[] rootArray, int targetSum, IList<IList<int>> expectedResult)
    {
        // Arrange
        var root = TreeNode.ToTreeNode(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.PathSum(root, targetSum);

        // Assert
        NestedCollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new int?[] { 5, 4, 8, 11, null, 13, 4, 7, 2, null, null, 5, 1 }, 22, new IList<int>[] { new[] { 5, 4, 11, 2 }, new[] { 5, 8, 4, 5 } }];

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
    }
}