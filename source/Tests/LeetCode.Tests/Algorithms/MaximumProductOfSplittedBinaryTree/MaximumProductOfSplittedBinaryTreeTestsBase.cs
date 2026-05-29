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

using LeetCode.Algorithms.MaximumProductOfSplittedBinaryTree;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.MaximumProductOfSplittedBinaryTree;

public abstract class MaximumProductOfSplittedBinaryTreeTestsBase<T>
    where T : IMaximumProductOfSplittedBinaryTree, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MaxProduct_WithBinaryTree_ReturnsMaximumProductOfSubtreeSums(int?[] rootArray,
        int expectedResult)
    {
        // Arrange
        var root = TreeNode.ToTreeNodeOrThrow(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.MaxProduct(root);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new int?[] { 1, 2, 3, 4, 5, 6 }, 110];

        yield return [new int?[] { 1, null, 2, 3, 4, null, null, 5, 6 }, 90];
    }
}