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

using LeetCode.Algorithms.BalancedBinaryTree;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.BalancedBinaryTree;

public abstract class BalancedBinaryTreeTestsBase<T> where T : IBalancedBinaryTree, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void IsBalanced_WithBinaryTreeRoot_ReturnsTrueIfHeightBalanced(int?[] rootArray, bool expectedResult)
    {
        // Arrange
        var root = TreeNode.ToTreeNode(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.IsBalanced(root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [Array.Empty<int?>(), true];

        yield return [new int?[] { 1 }, true];

        yield return [new int?[] { 3, 9, 20, null, null, 15, 7 }, true];

        yield return [new int?[] { 1, 2, 2, 3, 3, null, null, 4, 4 }, false];

        yield return [new int?[] { 1, 2, 2, 3, null, null, 3, 4, null, null, 4 }, false];

        yield return [new int?[] { 1, 2, 2, null, null, 3, 3, 4, 4 }, false];

        yield return [new int?[] { 1, 2, 2, 3, 3, 3, 3 }, true];
    }
}