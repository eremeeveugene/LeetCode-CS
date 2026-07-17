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

using LeetCode.Core.Exceptions;
using LeetCode.Core.Models;

namespace LeetCode.Core.Tests.Models;

[TestClass]
public sealed class TreeNodeTests
{
    [TestMethod]
    public void TreeNode_DefaultConstructor_SetsValToZero()
    {
        // Act
        var result = new TreeNode();

        // Assert
        Assert.AreEqual(0, result.val);
        Assert.IsNull(result.left);
        Assert.IsNull(result.right);
    }

    [TestMethod]
    public void TreeNode_ParameterizedConstructor_SetsProperties()
    {
        // Act
        var leftNode = new TreeNode(1);
        var rightNode = new TreeNode(2);
        var result = new TreeNode(3, leftNode, rightNode);

        // Assert
        Assert.AreEqual(3, result.val);
        Assert.AreEqual(leftNode, result.left);
        Assert.AreEqual(rightNode, result.right);
    }

    [TestMethod]
    public void ToTreeNode_WithEmptyValues_ReturnsNull()
    {
        // Act
        var result = TreeNode.ToTreeNode([]);

        // Assert
        Assert.IsNull(result);
    }

    [TestMethod]
    public void ToTreeNode_WithNullRoot_ReturnsNull()
    {
        // Act
        var result = TreeNode.ToTreeNode([null]);

        // Assert
        Assert.IsNull(result);
    }

    [TestMethod]
    public void ToTreeNode_WithSingleValue_ReturnsRootWithoutChildren()
    {
        // Act
        var result = TreeNode.ToTreeNode([1]);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(1, result.val);
        Assert.IsNull(result.left);
        Assert.IsNull(result.right);
    }

    [TestMethod]
    public void ToTreeNode_WithLeftChildOnly_SetsLeftAndLeavesRightNull()
    {
        // Act
        var result = TreeNode.ToTreeNode([1, 2]);

        // Assert
        Assert.IsNotNull(result);
        Assert.IsNotNull(result.left);
        Assert.AreEqual(2, result.left.val);
        Assert.IsNull(result.right);
    }

    [TestMethod]
    public void ToTreeNode_WithNullLeftChild_SetsRightOnly()
    {
        // Act
        var result = TreeNode.ToTreeNode([1, null, 3]);

        // Assert
        Assert.IsNotNull(result);
        Assert.IsNull(result.left);
        Assert.IsNotNull(result.right);
        Assert.AreEqual(3, result.right.val);
    }

    [TestMethod]
    public void ToTreeNode_WithNullRightChild_ContinuesWithNextLevel()
    {
        // Act
        var result = TreeNode.ToTreeNode([1, 2, null, 4]);

        // Assert
        Assert.IsNotNull(result);
        Assert.IsNotNull(result.left);
        Assert.AreEqual(2, result.left.val);
        Assert.IsNull(result.right);
        Assert.IsNotNull(result.left.left);
        Assert.AreEqual(4, result.left.left.val);
    }

    [TestMethod]
    public void ToTreeNode_WithFullLevel_SetsBothChildren()
    {
        // Act
        var result = TreeNode.ToTreeNode([1, 2, 3]);

        // Assert
        Assert.IsNotNull(result);
        Assert.IsNotNull(result.left);
        Assert.AreEqual(2, result.left.val);
        Assert.IsNotNull(result.right);
        Assert.AreEqual(3, result.right.val);
    }

    [TestMethod]
    public void ToTreeNodeOrThrow_WithValues_ReturnsRoot()
    {
        // Act
        var result = TreeNode.ToTreeNodeOrThrow([1]);

        // Assert
        Assert.AreEqual(1, result.val);
    }

    [TestMethod]
    public void ToTreeNodeOrThrow_WithEmptyValues_ThrowsTreeNodeBuildException()
    {
        // Act & Assert
        Assert.ThrowsExactly<TreeNodeBuildException>(() => TreeNode.ToTreeNodeOrThrow([]));
    }
}