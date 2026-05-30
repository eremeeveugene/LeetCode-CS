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
    }
}