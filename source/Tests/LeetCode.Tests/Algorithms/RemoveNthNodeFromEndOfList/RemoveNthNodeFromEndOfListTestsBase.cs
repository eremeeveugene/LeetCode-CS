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

using LeetCode.Algorithms.RemoveNthNodeFromEndOfList;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.RemoveNthNodeFromEndOfList;

public abstract class RemoveNthNodeFromEndOfListTestsBase<T> where T : IRemoveNthNodeFromEndOfList, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 2, new[] { 1, 2, 3, 5 })]
    [DataRow(new[] { 1 }, 1, new int[] { })]
    [DataRow(new[] { 1, 2 }, 1, new[] { 1 })]
    [DataRow(new[] { 1, 2 }, 2, new[] { 2 })]
    [DataRow(new int[] { }, 1, new int[] { })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 1, new[] { 1, 2, 3, 4 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 3, new[] { 1, 2, 4, 5 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 4, new[] { 1, 3, 4, 5 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 5, new[] { 2, 3, 4, 5 })]
    [DataRow(new[] { 1, 2, 3 }, 1, new[] { 1, 2 })]
    [DataRow(new[] { 1, 2, 3 }, 2, new[] { 1, 3 })]
    [DataRow(new[] { 1, 2, 3 }, 3, new[] { 2, 3 })]
    [DataRow(new[] { 7 }, 1, new int[] { })]
    [DataRow(new[] { 1, 2, 3, 4 }, 1, new[] { 1, 2, 3 })]
    [DataRow(new[] { 1, 2, 3, 4 }, 2, new[] { 1, 2, 4 })]
    [DataRow(new[] { 1, 2, 3, 4 }, 4, new[] { 2, 3, 4 })]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, 3, new[] { 5, 4, 2, 1 })]
    [DataRow(new[] { -1, -2, -3 }, 2, new[] { -1, -3 })]
    [DataRow(new[] { -5, -10, -15, -20 }, 1, new[] { -5, -10, -15 })]
    [DataRow(new[] { 0, 0, 0 }, 2, new[] { 0, 0 })]
    [DataRow(new[] { 10, 20, 30, 40, 50, 60 }, 6, new[] { 20, 30, 40, 50, 60 })]
    [DataRow(new[] { 10, 20, 30, 40, 50, 60 }, 1, new[] { 10, 20, 30, 40, 50 })]
    [DataRow(new[] { 100 }, 1, new int[] { })]
    public void RemoveNthFromEnd_WithListAndPosition_RemovesNthNodeFromEndAndReturnsUpdatedList(int[] headArray, int n, int[] expectedResultArray)
    {
        // Arrange
        var head = ListNode.ToListNode(headArray);
        var expectedResult = ListNode.ToListNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.RemoveNthFromEnd(head, n);

        // Assert
        ListNodeAssert.AreEqual(expectedResult, actualResult);
    }
}