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

using LeetCode.Algorithms.RemoveNthNodeFromEndOfList;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.RemoveNthNodeFromEndOfList;

public abstract class RemoveNthNodeFromEndOfListTestsBase<T> where T : IRemoveNthNodeFromEndOfList, new()
{
    [TestMethod]
    [DataRow("[1,2,3,4,5]", 2, "[1,2,3,5]")]
    [DataRow("[1]", 1, "[]")]
    [DataRow("[1,2]", 1, "[1]")]
    [DataRow("[1,2]", 2, "[2]")]
    public void RemoveNthFromEnd_WithListAndPosition_RemovesNthNodeFromEndAndReturnsUpdatedList(string headJson, int n,
        string expectedResultJson)
    {
        // Arrange
        var headArray = JsonHelper<int[]>.Parse(headJson);
        var head = ListNode.ToListNode(headArray);
        var expectedResultArray = JsonHelper<int[]>.Parse(expectedResultJson);
        var expectedResult = ListNode.ToListNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.RemoveNthFromEnd(head, n);

        // Assert
        ListNodeAssert.AreEqual(expectedResult, actualResult);
    }
}