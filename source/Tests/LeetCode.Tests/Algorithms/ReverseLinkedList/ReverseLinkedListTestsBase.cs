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

using LeetCode.Algorithms.ReverseLinkedList;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.ReverseLinkedList;

public abstract class ReverseLinkedListTestsBase<T> where T : IReverseLinkedList, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, new[] { 5, 4, 3, 2, 1 })]
    [DataRow(new[] { 1, 2 }, new[] { 2, 1 })]
    [DataRow(new int[] { }, new int[] { })]
    public void ReverseList_WithVariousHeadArrays_ReturnsExpectedReversedList(int[] headArray,
        int[] expectedResultArray)
    {
        // Arrange
        var head = ListNode.ToListNode(headArray);

        var expectedResult = ListNode.ToListNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.ReverseList(head);

        // Assert
        ListNodeAssert.AreEqual(expectedResult, actualResult);
    }
}