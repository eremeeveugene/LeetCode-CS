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

using LeetCode.Core.Models;

namespace LeetCode.Core.Tests.Models;

[TestClass]
public sealed class NodeTests
{
    [TestMethod]
    public void Node_DefaultConstructor_SetsValToZero()
    {
        // Act
        var result = new Node();

        // Assert
        Assert.AreEqual(0, result.val);
        Assert.IsNull(result.children);
    }

    [TestMethod]
    public void Node_ParameterizedConstructor_SetsProperties()
    {
        // Act
        var children = new List<Node> { new(1), new(2) };
        var result = new Node(3, children);

        // Assert
        Assert.AreEqual(3, result.val);
        Assert.AreSame(children, result.children);
    }

    [TestMethod]
    public void Node_ParameterizedConstructorWithNullValue_SetsValToZero()
    {
        // Act
        var result = new Node(null);

        // Assert
        Assert.AreEqual(0, result.val);
        Assert.IsNull(result.children);
    }

    [TestMethod]
    public void ToNode_WithEmptyArray_ReturnsNull()
    {
        // Act
        var result = Node.ToNode([]);

        // Assert
        Assert.IsNull(result);
    }

    [TestMethod]
    public void ToNode_WithNullRoot_ReturnsNull()
    {
        // Act
        var result = Node.ToNode([null]);

        // Assert
        Assert.IsNull(result);
    }

    [TestMethod]
    public void ToNode_WithSingleValue_ReturnsRootWithoutChildren()
    {
        // Act
        var result = Node.ToNode([1]);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(1, result.val);
        Assert.IsNull(result.children);
    }

    [TestMethod]
    public void ToNode_WithMultipleLevels_BuildsTree()
    {
        // Act
        var result = Node.ToNode([1, null, 3, 2, 4, null, 5, 6]);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(1, result.val);
        Assert.IsNotNull(result.children);
        Assert.HasCount(3, result.children);
        Assert.AreEqual(3, result.children[0].val);
        Assert.AreEqual(2, result.children[1].val);
        Assert.AreEqual(4, result.children[2].val);

        var firstChild = result.children[0];

        Assert.IsNotNull(firstChild.children);
        Assert.HasCount(2, firstChild.children);
        Assert.AreEqual(5, firstChild.children[0].val);
        Assert.AreEqual(6, firstChild.children[1].val);
    }

    [TestMethod]
    public void ToNode_WithTrailingNullValues_ReturnsRootWithEmptyChildren()
    {
        // Act
        var result = Node.ToNode([1, null, null, null]);

        // Assert
        Assert.IsNotNull(result);
        Assert.IsNotNull(result.children);
        Assert.IsEmpty(result.children);
    }

    [TestMethod]
    public void ToNode_WithValuesEndingAtChildren_BuildsChildrenUntilEnd()
    {
        // Act
        var result = Node.ToNode([1, null, 2, 3]);

        // Assert
        Assert.IsNotNull(result);
        Assert.IsNotNull(result.children);
        Assert.HasCount(2, result.children);
        Assert.AreEqual(2, result.children[0].val);
        Assert.AreEqual(3, result.children[1].val);
    }
}