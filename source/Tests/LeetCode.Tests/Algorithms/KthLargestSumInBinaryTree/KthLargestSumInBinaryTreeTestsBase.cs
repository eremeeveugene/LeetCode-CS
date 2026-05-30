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

using LeetCode.Algorithms.KthLargestSumInBinaryTree;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.KthLargestSumInBinaryTree;

public abstract class KthLargestSumInBinaryTreeTestsBase<T> where T : IKthLargestSumInBinaryTree, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void KthLargestLevelSum_WithTreeAndK_ReturnsKthLargestLevelSum(int?[] rootArray, int k, long expectedResult)
    {
        // Arrange
        var root = TreeNode.ToTreeNodeOrThrow(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.KthLargestLevelSum(root, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new int?[] { 5, 8, 9, 2, 1, 3, 7, 4, 6 }, 2, 13L];

        yield return [new int?[] { 1, 2, null, 3 }, 1, 3L];
    }
}