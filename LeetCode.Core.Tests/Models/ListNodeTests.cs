// --------------------------------------------------------------------------------
// Copyright (C) 2023 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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
    public void Constructor_ShouldSetVal_WhenOnlyValProvided(int expectedVal)
    {
        // Act
        var node = new ListNode(expectedVal);

        var actualVal = node.val;

        // Assert
        Assert.AreEqual(expectedVal, actualVal);
        Assert.IsNull(node.next);
    }

    [TestMethod]
    [DataRow(0)]
    [DataRow(10)]
    [DataRow(100)]
    public void Constructor_ShouldSetValAndNext_WhenBothProvided(int expectedVal)
    {
        // Arrange
        var expectedNext = new ListNode(10);

        // Act
        var node = new ListNode(expectedVal, expectedNext);

        var actualVal = node.val;
        var actualNext = node.next;

        // Assert
        Assert.AreEqual(expectedVal, actualVal);
        Assert.AreEqual(expectedNext, actualNext);
    }

    [TestMethod]
    public void Constructor_ShouldSetValToZeroAndNextToNull_WhenNoParametersProvided()
    {
        // Assert
        const int expectedVal = 0;

        // Act
        var node = new ListNode();

        var actualVal = node.val;

        // Assert
        Assert.AreEqual(expectedVal, actualVal);
        Assert.IsNull(node.next);
    }
}