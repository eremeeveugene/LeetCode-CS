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

using LeetCode.Algorithms.BinaryTreeInorderTraversal;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.BinaryTreeInorderTraversal;

public abstract class BinaryTreeInorderTraversalTestsBase<T> where T : IBinaryTreeInorderTraversal, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void InorderTraversal_WithBinaryTreeFromJson_ReturnsInorderTraversalList(int?[] inputArray, int?[] expectedResult)
    {
        // Arrange
        var inputNode = TreeNode.ToTreeNode(inputArray);

        var solution = new T();

        // Act
        var actualResult = solution.InorderTraversal(inputNode).ToArray();

        // Assert
        Assert.IsNotNull(actualResult);
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new int?[] { 1, null, 2, 3 }, new int?[] { 1, 3, 2 }];

        yield return [new int?[] { 1 }, new int?[] { 1 }];

        yield return [Array.Empty<int?>(), new int?[] { 0 }];
    }
}