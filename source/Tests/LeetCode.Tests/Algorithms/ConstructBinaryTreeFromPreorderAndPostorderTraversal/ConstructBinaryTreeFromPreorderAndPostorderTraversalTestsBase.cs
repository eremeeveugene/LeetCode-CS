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

using LeetCode.Algorithms.ConstructBinaryTreeFromPreorderAndPostorderTraversal;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.ConstructBinaryTreeFromPreorderAndPostorderTraversal;

public abstract class ConstructBinaryTreeFromPreorderAndPostorderTraversalTestsBase<T> where T : IConstructBinaryTreeFromPreorderAndPostorderTraversal, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void ConstructFromPrePost_WithPreorderAndPostorder_ReturnsBinaryTree(int[] preorder, int[] postorder, int?[] expectedResultArray)
    {
        // Arrange
        var expectedResult = TreeNode.ToTreeNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.ConstructFromPrePost(preorder, postorder);

        // Assert
        TreeNodeAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { 1 }, new[] { 1 }, new int?[] { 1 }];

        yield return [new[] { 1, 2, 4, 5, 3, 6, 7 }, new[] { 4, 5, 2, 6, 7, 3, 1 }, new int?[] { 1, 2, 3, 4, 5, 6, 7 }];
    }
}