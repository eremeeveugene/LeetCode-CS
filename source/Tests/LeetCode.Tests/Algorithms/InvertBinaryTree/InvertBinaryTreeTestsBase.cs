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

using LeetCode.Algorithms.InvertBinaryTree;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.InvertBinaryTree;

public abstract class InvertBinaryTreeTestsBase<T> where T : IInvertBinaryTree, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void InvertTree_GivenBinaryTree_ReturnsInvertedTree(int?[] rootArray, int?[] expectedResultArray)
    {
        // Arrange
        var root = TreeNode.ToTreeNode(rootArray);
        var expectedResult = TreeNode.ToTreeNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.InvertTree(root);

        // Assert
        TreeNodeAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [Array.Empty<int?>(), Array.Empty<int?>()];

        yield return [new int?[] { 1 }, new int?[] { 1 }];

        yield return [new int?[] { 1, 2 }, new int?[] { 1, null, 2 }];

        yield return [new int?[] { 1, null, 2 }, new int?[] { 1, 2 }];

        yield return [new int?[] { 4, 2, 7, 1, 3, 6, 9 }, new int?[] { 4, 7, 2, 9, 6, 3, 1 }];

        yield return [new int?[] { 4, 2, 7, 1, 3, null, 9 }, new int?[] { 4, 7, 2, 9, null, 3, 1 }];

        yield return [new int?[] { 4, 2, 7, 1, 3, 6 }, new int?[] { 4, 7, 2, null, 6, 3, 1 }];
    }
}