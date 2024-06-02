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
public class NodeTests
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
        Assert.AreEqual(children, result.children);
    }
}