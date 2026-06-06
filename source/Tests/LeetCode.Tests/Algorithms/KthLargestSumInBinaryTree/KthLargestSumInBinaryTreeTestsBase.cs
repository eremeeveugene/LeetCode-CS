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

        yield return [new int?[] { 1, 2, null, 3 }, 2, 2L];

        yield return [new int?[] { 1, 2, null, 3 }, 3, 1L];

        yield return [new int?[] { 1 }, 1, 1L];

        yield return [new int?[] { 1 }, 2, -1L];

        yield return [new int?[] { 1, 2, 3 }, 1, 5L];

        yield return [new int?[] { 1, 2, 3 }, 2, 1L];

        yield return [new int?[] { 1, 2, 3 }, 3, -1L];

        yield return [new int?[] { 5, 8, 9, 2, 1, 3, 7, 4, 6 }, 1, 17L];

        yield return [new int?[] { 5, 8, 9, 2, 1, 3, 7, 4, 6 }, 3, 10L];

        yield return [new int?[] { 5, 8, 9, 2, 1, 3, 7, 4, 6 }, 4, 5L];

        yield return [new int?[] { 5, 8, 9, 2, 1, 3, 7, 4, 6 }, 5, -1L];

        yield return [new int?[] { 10, 20, 30 }, 1, 50L];

        yield return [new int?[] { 10, 20, 30 }, 2, 10L];

        yield return [new int?[] { 100 }, 1, 100L];

        yield return [new int?[] { -1, -2, -3 }, 1, -1L];

        yield return [new int?[] { -1, -2, -3 }, 2, -5L];

        yield return [new int?[] { 0, 0, 0, 0, 0, 0, 0 }, 1, 0L];

        yield return [new int?[] { 0, 0, 0, 0, 0, 0, 0 }, 3, 0L];

        yield return [new int?[] { 1, null, 2, null, 3, null, 4 }, 4, 1L];

        yield return [new int?[] { 1, null, 2, null, 3, null, 4 }, 5, -1L];
    }
}