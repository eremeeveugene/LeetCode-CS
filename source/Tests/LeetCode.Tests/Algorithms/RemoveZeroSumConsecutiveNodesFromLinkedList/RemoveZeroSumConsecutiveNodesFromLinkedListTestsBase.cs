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

using LeetCode.Algorithms.RemoveZeroSumConsecutiveNodesFromLinkedList;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.RemoveZeroSumConsecutiveNodesFromLinkedList;

public abstract class RemoveZeroSumConsecutiveNodesFromLinkedListTestsBase<T>
    where T : IRemoveZeroSumConsecutiveNodesFromLinkedList, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, -3, 3, 1 }, new[] { 3, 1 })]
    [DataRow(new[] { 1, 2, 3, -3, 4 }, new[] { 1, 2, 4 })]
    [DataRow(new[] { 1, 2, 3, -3, -2 }, new[] { 1 })]
    public void RemoveZeroSumSublists_WithListContainingZeroSumSequences_ReturnsListWithZeroSumSublistsRemoved(
        int[] headArray, int[] expectedResultArray)
    {
        // Arrange
        var head = ListNode.ToListNode(headArray);
        var expectedResult = ListNode.ToListNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.RemoveZeroSumSublists(head);

        // Assert
        ListNodeAssert.AreEqual(expectedResult, actualResult);
    }
}