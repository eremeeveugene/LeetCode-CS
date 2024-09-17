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

using LeetCode.Algorithms.RemoveNodesFromLinkedList;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.RemoveNodesFromLinkedList;

public abstract class RemoveNodesFromLinkedListTestsBase<T> where T : IRemoveNodesFromLinkedList, new()
{
    [TestMethod]
    [DataRow("[1]", "[1]")]
    [DataRow("[1,1,1,1]", "[1,1,1,1]")]
    [DataRow("[5,2,13,3,8]", "[13,8]")]
    [DataRow("[1,2,3,4,5,6,7,8,9]", "[9]")]
    [DataRow("[9,8,7,6,5,4,3,2,1]", "[9,8,7,6,5,4,3,2,1]")]
    [DataRow("[1,2,3,1,2,3,1,2,3]", "[3,3,3]")]
    [DataRow("[3,2,1,3,2,1,3,2,1]", "[3,3,3,2,1]")]
    public void RemoveNodes_WithVariousLists_RemovesExpectedNodes(string headJsonArray, string expectedResultJsonArray)
    {
        // Arrange
        var headArray = JsonHelper<int>.DeserializeToArray(headJsonArray);
        var head = ListNode.ToListNode(headArray);
        var expectedResultArray = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);
        var expectedResult = ListNode.ToListNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.RemoveNodes(head);

        // Assert
        ListNodeAssert.AreEqual(expectedResult, actualResult);
    }
}