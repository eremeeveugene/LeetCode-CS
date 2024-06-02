// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Core.Models;

namespace LeetCode.Core.Tests.Models;

[TestClass]
public class TreeNodeTests
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
}