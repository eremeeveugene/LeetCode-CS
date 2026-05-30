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

using LeetCode.Algorithms.BinaryTreePreorderTraversal;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.BinaryTreePreorderTraversal;

public abstract class BinaryTreePreorderTraversalTestsBase<T> where T : IBinaryTreePreorderTraversal, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void PreorderTraversal_WithSerializedBinaryTree_ReturnsNodeValuesInPreorder(int?[] rootArray, int?[] expectedResult)
    {
        // Arrange
        var root = TreeNode.ToTreeNode(rootArray);

        var solution = new T();

        // Act
        var actualResult = solution.PreorderTraversal(root).ToArray();

        // Assert
        Assert.IsNotNull(actualResult);
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [Array.Empty<int?>(), Array.Empty<int?>()];

        yield return [new int?[] { 1 }, new int?[] { 1 }];

        yield return [new int?[] { 1, null, 2, 3 }, new int?[] { 1, 2, 3 }];

        yield return [new int?[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new int?[] { 1, 2, 4, 8, 9, 5, 3, 6, 7 }];
    }
}