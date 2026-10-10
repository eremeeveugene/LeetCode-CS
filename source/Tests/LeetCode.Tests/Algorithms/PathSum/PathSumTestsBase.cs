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

using LeetCode.Algorithms.PathSum;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.PathSum;

public abstract class PathSumTestsBase<T> where T : IPathSum, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void HasPathSum_WithBinaryTreeAndTargetSum_ReturnsTrueIfAnyRootToLeafPathEqualsTarget(int?[] rootArray, int targetSum, bool expectedResult)
    {
        // Arrange
        var root = TreeNode.ToTreeNode(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.HasPathSum(root, targetSum);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new int?[] { 5, 4, 8, 11, null, 13, 4, 7, 2, null, null, null, 1 }, 22, true];

        yield return [new int?[] { 1, 2, 3 }, 5, false];

        yield return [Array.Empty<int?>(), 0, false];

        yield return [new int?[] { 1 }, 1, true];

        yield return [new int?[] { 1, 2 }, 1, false];

        yield return [new int?[] { 1, 2, null, 3, null, 4, null, 5 }, 6, false];

        yield return [new int?[] { 1, -2, -3, 1, 3, -2, null, -1 }, -1, true];

        yield return [new int?[] { 0, 6, -9, 9, -9, 1, -6, null, null, -2, -4 }, -8, true];

        yield return [new int?[] { 2, 0, 0, null, -5, -5, null, null, -8, null, -1, -6, -4, null, null, null, null, -3, -3 }, 14, false];

        yield return [new int?[] { 4, 7, -5, null, 3, -4, null, null, -7, null, null, -7, 0 }, 0, true];

        yield return [new int?[] { -4 }, -15, false];

        yield return [new int?[] { 5, -9, -4, -4, null, null, 6 }, 7, true];

        yield return [new int?[] { 4, -9, -6, 9, null, null, null, null, -9 }, 18, false];

        yield return [new int?[] { 5, 4, -1, -9, -9, -6, null, null, null, 3, null, -1, 3, null, null, -1, -9, 9 }, 3, true];

        yield return [new int?[] { 3, null, -5, 7, 9, 6, -9, null, 7, null, 0, null, null, -3, 8 }, 16, false];

        yield return [new int?[] { 7, -1, 6, 3, 0, 1, null, null, null, -4, 8, null, -5, 3, null, -5, null, null, null, -7 }, 9, true];

        yield return [new int?[] { 6, 8 }, 17, false];

        yield return [new int?[] { 1, 2, -8, null, 6, null, 3, 4, 0, null, null, null, null, null, -7, null, 1 }, 3, true];

        yield return [new int?[] { 5, -4, null, -4, null, 4 }, -2, false];

        yield return [new int?[] { -3, 6, -8, 2, null, null, null, -8, 6, null, null, null, -3 }, -3, true];
    }
}