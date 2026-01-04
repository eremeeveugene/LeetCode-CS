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

using LeetCode.Algorithms.ReverseLinkedList;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.ReverseLinkedList;

public abstract class ReverseLinkedListTestsBase<T> where T : IReverseLinkedList, new()
{
    [TestMethod]
    [DataRow("[]", "[]")]
    [DataRow("[1,2]", "[2,1]")]
    [DataRow("[1,2,3,4,5]", "[5,4,3,2,1]")]
    public void ReverseList_WithSinglyLinkedList_ReturnsListInReversedOrder(string headJson,
        string expectedResultJson)
    {
        // Arrange
        var headArray = JsonHelper<int[]>.Parse(headJson);
        var head = ListNode.ToListNode(headArray);
        var expectedResultArray = JsonHelper<int[]>.Parse(expectedResultJson);
        var expectedResult = ListNode.ToListNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.ReverseList(head);

        // Assert
        ListNodeAssert.AreEqual(expectedResult, actualResult);
    }
}