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
        ListNode node = new(expectedVal);

        int actualVal = node.val;

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
        ListNode expectedNext = new(10);

        // Act
        ListNode node = new(expectedVal, expectedNext);

        int actualVal = node.val;
        ListNode? actualNext = node.next;

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
        ListNode node = new();

        int actualVal = node.val;

        // Assert
        Assert.AreEqual(expectedVal, actualVal);
        Assert.IsNull(node.next);
    }
}