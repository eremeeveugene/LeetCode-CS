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

using LeetCode.Algorithms.MaximumDepthOfBinaryTree;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.MaximumDepthOfBinaryTree;

public abstract class MaximumDepthOfBinaryTreeTestsBase<T> where T : IMaximumDepthOfBinaryTree, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MaxDepth_WithBinaryTreeInput_ReturnsMaximumDepthOfTree(int?[] rootArray, int expectedResult)
    {
        // Arrange
        var solution = new T();

        var root = TreeNode.ToTreeNode(rootArray);

        // Act
        var actualResult = solution.MaxDepth(root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [Array.Empty<int?>(), 0];

        yield return [new int?[] { 3, 9, 20, null, null, 15, 7 }, 3];

        yield return [new int?[] { 1, null, 2 }, 2];

        yield return [new int?[] { 2, 1 }, 2];

        yield return [new int?[] { 1 }, 1];

        yield return [new int?[] { 42 }, 1];

        yield return [new int?[] { -1 }, 1];

        yield return [new int?[] { 1, 2 }, 2];

        yield return [new int?[] { 5, null, 10 }, 2];

        yield return [new int?[] { 7, 3, 9 }, 2];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7 }, 3];

        yield return [new int?[] { 1, 2, 3, 4 }, 3];

        yield return [new int?[] { 1, 2, 3, null, null, null, 6 }, 3];

        yield return [new int?[] { 5, 3, 8, 1, 4, 7, 9 }, 3];

        yield return [new int?[] { 1, 2, null, 3, null, 4 }, 4];

        yield return [new int?[] { 1, null, 2, null, 3, null, 4 }, 4];

        yield return [new int?[] { 10, 5, 15, 2, 7, 12, 20, 1 }, 4];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 4];

        yield return [new int?[] { 1, 2, null, 3, null, 4, null, 5 }, 5];

        yield return [new int?[] { 1, null, 2, null, 3, null, 4, null, 5 }, 5];

        yield return [new int?[] { 1, 2, null, 3, null, 4, null, 5, null, 6 }, 6];

        yield return [new int?[] { 1, null, 2, null, 3, null, 4, null, 5, null, 6 }, 6];

        yield return [new int?[] { 3, 1, 4, 1, 5 }, 3];

        yield return [new int?[] { 100, 50, 150, 25, 75, 125, 175, 10 }, 4];
    }
}