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

using LeetCode.Algorithms.MinimumDepthOfBinaryTree;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.MinimumDepthOfBinaryTree;

public abstract class MinimumDepthOfBinaryTreeTestsBase<T> where T : IMinimumDepthOfBinaryTree, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MinDepth_GivenBinaryTreeAsJson_ReturnsMinimumDepth(int?[] rootArray, int expectedResult)
    {
        // Arrange
        var root = TreeNode.ToTreeNode(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.MinDepth(root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [Array.Empty<int?>(), 0];

        yield return [new int?[] { 3, 9, 20, null, null, 15, 7 }, 2];

        yield return [new int?[] { 2, null, 3, null, 4, null, 5, null, 6 }, 5];

        yield return [new int?[] { 1, 2 }, 2];

        yield return [new int?[] { 1 }, 1];

        yield return [new int?[] { 5, 10 }, 2];

        yield return [new int?[] { 1, null, 2 }, 2];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7 }, 3];

        yield return [new int?[] { 1, 2, 3, 4 }, 2];

        yield return [new int?[] { 1, 2, null, 3 }, 3];

        yield return [new int?[] { 1, null, 2, null, 3 }, 3];

        yield return [new int?[] { 5, 3, 8, 1, 4, 7, 9 }, 3];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 3];

        yield return [new int?[] { 1, 2, 3, null, null, 4, 5 }, 2];

        yield return [new int?[] { 1, 2, 3, 4, 5 }, 2];

        yield return [new int?[] { 2, 1 }, 2];

        yield return [new int?[] { 2, null, 1 }, 2];

        yield return [new int?[] { 1, 2, 3, 4, null, null, 5 }, 3];

        yield return [new int?[] { 0 }, 1];

        yield return [new int?[] { -5 }, 1];

        yield return [new int?[] { 1, -2, -3 }, 2];

        yield return [new int?[] { 10, 5, 15, 2, 7 }, 2];

        yield return [new int?[] { 10, 5, 15, 2, 7, 12, 20 }, 3];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }, 4];
    }
}