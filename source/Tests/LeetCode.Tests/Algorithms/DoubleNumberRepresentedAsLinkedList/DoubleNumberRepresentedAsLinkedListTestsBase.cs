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

using LeetCode.Algorithms.DoubleNumberRepresentedAsLinkedList;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.DoubleNumberRepresentedAsLinkedList;

public abstract class DoubleNumberRepresentedAsLinkedListTestsBase<T>
    where T : IDoubleNumberRepresentedAsLinkedList, new()
{
    [TestMethod]
    [DataRow("[1, 8, 9]", "[3, 7, 8]")]
    [DataRow("[9, 9, 9]", "[1, 9, 9, 8]")]
    public void ListNode_DoubleIt_GivenListNode_ReturnsDoubledValuesListNode(string headJsonArray,
        string expectedResultJsonArray)
    {
        // Arrange
        var headArray = JsonHelper<int>.DeserializeToArray(headJsonArray);
        var head = ListNode.ToListNode(headArray);

        var expectedResultArray = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);
        var expectedResult = ListNode.ToListNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.DoubleIt(head);

        // Assert
        ListNodeAssert.AreEqual(expectedResult, actualResult);
    }
}