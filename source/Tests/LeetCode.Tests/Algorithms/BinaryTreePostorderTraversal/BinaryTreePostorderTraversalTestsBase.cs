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

using LeetCode.Algorithms.BinaryTreePostorderTraversal;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.BinaryTreePostorderTraversal;

public abstract class BinaryTreePostorderTraversalTestsBase<T> where T : IBinaryTreePostorderTraversal, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void PostorderTraversal_WithBinaryTree_ReturnsListOfValuesInPostorder(int?[] rootArray, int?[] expectedResult)
    {
        // Arrange
        var root = TreeNode.ToTreeNode(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.PostorderTraversal(root).ToArray();

        // Assert
        Assert.IsNotNull(actualResult);
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new int?[] { 1, null, 2, 3 }, new int?[] { 3, 2, 1 }];

        yield return [Array.Empty<int?>(), Array.Empty<int?>()];

        yield return [new int?[] { 1 }, new int?[] { 1 }];
    }
}