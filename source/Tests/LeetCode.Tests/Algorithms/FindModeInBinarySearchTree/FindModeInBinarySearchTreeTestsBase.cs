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

using LeetCode.Algorithms.FindModeInBinarySearchTree;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.FindModeInBinarySearchTree;

public abstract class FindModeInBinarySearchTreeTestsBase<T> where T : IFindModeInBinarySearchTree, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void FindMode_WithBinaryTree_ReturnsModeValues(int?[] rootArray,
        int[] expectedResult)
    {
        // Arrange
        var root = TreeNode.ToTreeNode(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.FindMode(root);

        // Assert
        CollectionAssert.AreEquivalent(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [Array.Empty<int?>(), Array.Empty<int>()];

        yield return [new int?[] { 0 }, new[] { 0 }];

        yield return [new int?[] { 1, null, 2, 2 }, new[] { 2 }];
    }
}