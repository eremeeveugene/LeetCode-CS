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
        // Single node
        yield return [new[] { 1 }, new[] { 1 }, new int?[] { 1 }];

        // Full 3-level binary tree
        yield return [new[] { 1, 2, 4, 5, 3, 6, 7 }, new[] { 4, 5, 2, 6, 7, 3, 1 }, new int?[] { 1, 2, 3, 4, 5, 6, 7 }];

        // Two nodes: root with left child only
        yield return [new[] { 1, 2 }, new[] { 2, 1 }, new int?[] { 1, 2 }];

        // Three nodes forming a full binary tree (both children)
        yield return [new[] { 1, 2, 3 }, new[] { 2, 3, 1 }, new int?[] { 1, 2, 3 }];

        // Four nodes: right child has two children
        yield return [new[] { 1, 2, 3, 4 }, new[] { 3, 4, 2, 1 }, new int?[] { 1, 2, null, 3, 4 }];

        // Three nodes: root, left child, left child's right child
        yield return [new[] { 3, 1, 2 }, new[] { 1, 2, 3 }, new int?[] { 3, 1, 2 }];

        // Symmetric full tree with 7 nodes
        yield return [new[] { 4, 2, 1, 3, 6, 5, 7 }, new[] { 1, 3, 2, 5, 7, 6, 4 }, new int?[] { 4, 2, 6, 1, 3, 5, 7 }];

        // Four nodes left skewed subtree
        yield return [new[] { 5, 3, 2, 4 }, new[] { 2, 4, 3, 5 }, new int?[] { 5, 3, null, 2, 4 }];

        // Six nodes full left + right has two children
        yield return [new[] { 1, 2, 4, 3, 5, 6 }, new[] { 4, 2, 5, 6, 3, 1 }, new int?[] { 1, 2, 3, 4, null, 5, 6 }];

        // Full tree with larger values
        yield return [new[] { 10, 5, 3, 8, 20, 15, 30 }, new[] { 3, 8, 5, 15, 30, 20, 10 }, new int?[] { 10, 5, 20, 3, 8, 15, 30 }];

        // Symmetric full tree 7 nodes different values
        yield return [new[] { 7, 3, 1, 2, 5, 4, 6 }, new[] { 1, 2, 3, 4, 6, 5, 7 }, new int?[] { 7, 3, 5, 1, 2, 4, 6 }];

        // Symmetric full tree 7 nodes another case
        yield return [new[] { 9, 4, 2, 7, 14, 11, 20 }, new[] { 2, 7, 4, 11, 20, 14, 9 }, new int?[] { 9, 4, 14, 2, 7, 11, 20 }];

        // Eight nodes: left subtree has 4 nodes with left-left grandchild
        yield return [new[] { 1, 2, 4, 8, 5, 3, 6, 7 }, new[] { 8, 4, 5, 2, 6, 7, 3, 1 }, new int?[] { 1, 2, 3, 4, 5, 6, 7, 8 }];

        // Six node full tree: root has full right subtree and two-node left
        yield return [new[] { 1, 2, 3, 4, 5, 6 }, new[] { 3, 2, 5, 6, 4, 1 }, new int?[] { 1, 2, 4, 3, null, 5, 6 }];

        // Root with two leaves only
        yield return [new[] { 100, 50, 200 }, new[] { 50, 200, 100 }, new int?[] { 100, 50, 200 }];

        // Left child has right child, right child has left child
        yield return [new[] { 10, 5, 7, 15, 12 }, new[] { 7, 5, 12, 15, 10 }, new int?[] { 10, 5, 15, 7, null, 12 }];

        // Five node complete binary tree
        yield return [new[] { 1, 2, 4, 5, 3 }, new[] { 4, 5, 2, 3, 1 }, new int?[] { 1, 2, 3, 4, 5 }];

        // Repeated-style with right-heavy subtrees
        yield return [new[] { 8, 4, 2, 6, 12, 10, 14 }, new[] { 2, 6, 4, 10, 14, 12, 8 }, new int?[] { 8, 4, 12, 2, 6, 10, 14 }];
    }
}