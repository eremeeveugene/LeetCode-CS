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
    }
}