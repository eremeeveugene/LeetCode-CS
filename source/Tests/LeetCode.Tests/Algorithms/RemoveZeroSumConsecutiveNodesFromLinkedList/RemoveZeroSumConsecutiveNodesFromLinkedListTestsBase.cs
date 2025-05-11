// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.RemoveZeroSumConsecutiveNodesFromLinkedList;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.RemoveZeroSumConsecutiveNodesFromLinkedList;

public abstract class RemoveZeroSumConsecutiveNodesFromLinkedListTestsBase<T>
    where T : IRemoveZeroSumConsecutiveNodesFromLinkedList, new()
{
    [TestMethod]
    [DataRow("[1,2,-3,3,1]", "[3,1]")]
    [DataRow("[1,2,3,-3,4]", "[1,2,4]")]
    [DataRow("[1,2,3,-3,-2]", "[1]")]
    public void RemoveZeroSumSublists_WithListContainingZeroSumSequences_ReturnsListWithZeroSumSublistsRemoved(
        string headJson, string expectedResultJson)
    {
        // Arrange
        var headArray = JsonHelper<int>.DeserializeToArray(headJson);
        var head = ListNode.ToListNode(headArray);
        var expectedResultArray = JsonHelper<int>.DeserializeToArray(expectedResultJson);
        var expectedResult = ListNode.ToListNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.RemoveZeroSumSublists(head);

        // Assert
        ListNodeAssert.AreEqual(expectedResult, actualResult);
    }
}