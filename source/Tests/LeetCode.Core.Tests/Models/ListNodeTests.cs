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
public class ListNodeTests
{
    [TestMethod]
    [DataRow(0)]
    [DataRow(10)]
    [DataRow(100)]
    public void ListNodeConstructor_WithVal_SetsValAndNextIsNull(int expectedVal)
    {
        // Act
        ListNode node = new(expectedVal);

        var actualVal = node.val;

        // Assert
        Assert.AreEqual(expectedVal, actualVal);
        Assert.IsNull(node.next);
    }

    [TestMethod]
    [DataRow(0)]
    [DataRow(10)]
    [DataRow(100)]
    public void ListNodeConstructor_WithValAndNext_SetsValAndNextCorrectly(int expectedVal)
    {
        // Arrange
        ListNode expectedNext = new(10);

        // Act
        ListNode node = new(expectedVal, expectedNext);

        var actualVal = node.val;
        var actualNext = node.next;

        // Assert
        Assert.AreEqual(expectedVal, actualVal);
        Assert.AreEqual(expectedNext, actualNext);
    }

    [TestMethod]
    public void ListNodeDefaultConstructor_SetsValToZeroAndNextToNull()
    {
        // Assert
        const int expectedVal = 0;

        // Act
        ListNode node = new();

        var actualVal = node.val;

        // Assert
        Assert.AreEqual(expectedVal, actualVal);
        Assert.IsNull(node.next);
    }
}