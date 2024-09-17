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
    public void RemoveZeroSumSublists_WithVariousLists_ReturnsExpectedResult(string headJsonArray,
        string expectedResultJsonArray)
    {
        // Arrange
        var headArray = JsonHelper<int>.DeserializeToArray(headJsonArray);
        var head = ListNode.ToListNode(headArray);
        var expectedResultArray = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);
        var expectedResult = ListNode.ToListNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.RemoveZeroSumSublists(head);

        // Assert
        ListNodeAssert.AreEqual(expectedResult, actualResult);
    }
}