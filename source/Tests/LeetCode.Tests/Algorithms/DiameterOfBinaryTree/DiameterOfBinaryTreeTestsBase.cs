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
    public void DiameterOfBinaryTree_WithBinaryTreeInput_ReturnsLengthOfLongestPathBetweenNodes(int?[] arrayRoot, int expectedResult)
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

        yield return [new int?[] { 3, 9, 20, null, null, 15, 7, null, null, null, 16 }, 4];

        yield return [new int?[] { 1 }, 0];

        yield return [new int?[] { 1, 2, 3 }, 2];

        yield return [new int?[] { 1, 2, null, 3 }, 2];

        yield return [new int?[] { 1, null, 2, null, 3 }, 2];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7 }, 4];

        yield return [new int?[] { 1, 2, 3, 4, null, null, 5 }, 4];

        yield return [new int?[] { 1, 2, null, 3, null, 4 }, 3];

        yield return [new int?[] { 1, 2, 3, 4, 5, null, null, 6, null, null, 7 }, 4];

        yield return [new int?[] { 1, null, 2, null, 3, null, 4, null, 5 }, 4];

        yield return [new int?[] { 1, 2, 2, 3, 3, null, null, 4, 4 }, 4];

        yield return [new int?[] { 1, 2, 3, null, 4, 5, null, null, 6 }, 5];

        yield return [new int?[] { 5, 4, 8, 11, null, 13, 4, 7, 2, null, null, null, 1 }, 6];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }, 6];

        yield return [new int?[] { 1, 2, null, 3, 4, null, null, 5, null, null, 6 }, 4];

        yield return [new int?[] { -1, -2, -3 }, 2];

        yield return [new int?[] { 0, 0, 0, 0, null, null, 0, 0 }, 5];
    }
}