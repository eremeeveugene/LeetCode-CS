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

using LeetCode.Algorithms.DiameterOfBinaryTree;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.DiameterOfBinaryTree;

public abstract class DiameterOfBinaryTreeTestsBase<T> where T : IDiameterOfBinaryTree, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void DiameterOfBinaryTree_WithBinaryTreeInput_ReturnsLengthOfLongestPathBetweenNodes(int?[] arrayRoot,
        int expectedResult)
    {
        // Arrange
        var root = TreeNode.ToTreeNode(arrayRoot);

        var solution = new T();

        // Act
        var actualResult = solution.DiameterOfBinaryTree(root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [Array.Empty<int?>(), 0];

        yield return [new int?[] { 1, 2, 3, 4, 5 }, 3];

        yield return [new int?[] { 1, 2 }, 1];
    }
}