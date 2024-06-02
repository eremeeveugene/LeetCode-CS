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
    public void RemoveNthFromEnd_WhenCalled_RemovesNthNodeFromEndAndReturnsCorrectList(int[] headArray, int n,
        int[] expectedResultArray)
    {
        // Arrange
        var head = ListNode.ToListNode(headArray);

        var expectedResult = ListNode.ToListNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.RemoveNthFromEnd(head, n);

        // Assert
        AssertExtensions.AreListNodesEqual(expectedResult, actualResult);
    }
}