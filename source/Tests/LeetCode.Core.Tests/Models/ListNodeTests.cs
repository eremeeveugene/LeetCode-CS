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
public sealed class ListNodeTests
{
    [TestMethod]
    [DataRow(0)]
    [DataRow(10)]
    [DataRow(100)]
    public void ListNodeConstructor_WithVal_SetsValAndNextIsNull(int expectedResult)
    {
        // Act
        ListNode node = new(expectedResult);

        var actualResult = node.val;

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
        Assert.IsNull(node.next);
    }

    [TestMethod]
    [DataRow(0)]
    [DataRow(10)]
    [DataRow(100)]
    public void ListNodeConstructor_WithValAndNext_SetsValAndNextCorrectly(int expectedResult)
    {
        // Arrange
        ListNode expectedNext = new(10);

        // Act
        ListNode node = new(expectedResult, expectedNext);

        var actualResult = node.val;
        var actualNext = node.next;

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
        Assert.AreEqual(expectedNext, actualNext);
    }

    [TestMethod]
    public void ListNodeDefaultConstructor_SetsValToZeroAndNextToNull()
    {
        // Assert
        const int expectedResult = 0;

        // Act
        ListNode node = new();

        var actualResult = node.val;

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
        Assert.IsNull(node.next);
    }

    [TestMethod]
    public void ToListNode_WithEmptyArray_ReturnsNull()
    {
        // Act
        var result = ListNode.ToListNode([]);

        // Assert
        Assert.IsNull(result);
    }

    [TestMethod]
    public void ToListNode_WithValues_BuildsListInOrder()
    {
        // Act
        var result = ListNode.ToListNode([1, 2, 3]);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(1, result.val);
        Assert.IsNotNull(result.next);
        Assert.AreEqual(2, result.next.val);
        Assert.IsNotNull(result.next.next);
        Assert.AreEqual(3, result.next.next.val);
        Assert.IsNull(result.next.next.next);
    }

    [TestMethod]
    public void ToListNodeOrThrow_WithValues_ReturnsHead()
    {
        // Act
        var result = ListNode.ToListNodeOrThrow([1, 2]);

        // Assert
        Assert.AreEqual(1, result.val);
        Assert.IsNotNull(result.next);
        Assert.AreEqual(2, result.next.val);
    }

    [TestMethod]
    public void ToListNodeOrThrow_WithEmptyArray_ThrowsListNodeBuildException()
    {
        // Act & Assert
        Assert.ThrowsExactly<ListNodeBuildException>(() => ListNode.ToListNodeOrThrow([]));
    }

    [TestMethod]
    public void ToCycledListNode_WithEmptyArray_ReturnsNull()
    {
        // Act
        var result = ListNode.ToCycledListNode([], 0);

        // Assert
        Assert.IsNull(result);
    }

    [TestMethod]
    public void ToCycledListNode_WithNegativeCyclePosition_ReturnsListWithoutCycle()
    {
        // Act
        var result = ListNode.ToCycledListNode([1, 2, 3], -1);

        // Assert
        Assert.IsNotNull(result);
        Assert.IsNotNull(result.next);
        Assert.IsNotNull(result.next.next);
        Assert.IsNull(result.next.next.next);
    }

    [TestMethod]
    public void ToCycledListNode_WithCyclePositionOutOfRange_ReturnsListWithoutCycle()
    {
        // Act
        var result = ListNode.ToCycledListNode([1, 2, 3], 5);

        // Assert
        Assert.IsNotNull(result);
        Assert.IsNotNull(result.next);
        Assert.IsNotNull(result.next.next);
        Assert.IsNull(result.next.next.next);
    }

    [TestMethod]
    public void ToCycledListNode_WithCycleAtHead_LinksLastNodeToHead()
    {
        // Act
        var result = ListNode.ToCycledListNode([1, 2, 3], 0);

        // Assert
        Assert.IsNotNull(result);
        Assert.IsNotNull(result.next);
        Assert.IsNotNull(result.next.next);

        var lastNode = result.next.next;

        Assert.AreEqual(3, lastNode.val);
        Assert.AreSame(result, lastNode.next);
    }

    [TestMethod]
    public void ToCycledListNode_WithCycleInMiddle_LinksLastNodeToMiddleNode()
    {
        // Act
        var result = ListNode.ToCycledListNode([1, 2, 3], 1);

        // Assert
        Assert.IsNotNull(result);
        Assert.IsNotNull(result.next);

        var middleNode = result.next;

        Assert.IsNotNull(middleNode.next);

        var lastNode = middleNode.next;

        Assert.AreSame(middleNode, lastNode.next);
    }

    [TestMethod]
    public void ToCycledListNode_WithCycleAtLastPosition_LinksLastNodeToItself()
    {
        // Act
        var result = ListNode.ToCycledListNode([1, 2, 3], 2);

        // Assert
        Assert.IsNotNull(result);
        Assert.IsNotNull(result.next);
        Assert.IsNotNull(result.next.next);

        var lastNode = result.next.next;

        Assert.AreSame(lastNode, lastNode.next);
    }

    [TestMethod]
    public void ToCycledListNode_WithSingleElementAndCycleAtZero_LinksHeadToItself()
    {
        // Act
        var result = ListNode.ToCycledListNode([1], 0);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreSame(result, result.next);
    }
}