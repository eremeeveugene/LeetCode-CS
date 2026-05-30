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

using LeetCode.Algorithms.MaximumLevelSumOfBinaryTree;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.MaximumLevelSumOfBinaryTree;

public abstract class MaximumLevelSumOfBinaryTreeTestsBase<T> where T : IMaximumLevelSumOfBinaryTree, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MaxLevelSum_WithBinaryTreeContainingMultipleLevels_ReturnsLevelWithMaximumNodeSum(int?[] rootArray, int expectedResult)
    {
        // Arrange
        var root = TreeNode.ToTreeNodeOrThrow(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.MaxLevelSum(root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new int?[] { 1 }, 1];

        yield return [new int?[] { 1, 7, 0, 7, -8, null, null }, 2];

        yield return [new int?[] { 989, null, 10250, 98693, -89388, null, null, null, -32127 }, 2];

        yield return [new int?[] { -100, -200, -300, -20, -5, -10, null }, 3];
    }
}