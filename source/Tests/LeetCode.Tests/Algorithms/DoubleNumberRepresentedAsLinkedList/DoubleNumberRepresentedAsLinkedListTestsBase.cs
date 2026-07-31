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

using LeetCode.Algorithms.DoubleNumberRepresentedAsLinkedList;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.DoubleNumberRepresentedAsLinkedList;

public abstract class DoubleNumberRepresentedAsLinkedListTestsBase<T> where T : IDoubleNumberRepresentedAsLinkedList, new()
{
    [TestMethod]
    [DataRow(new int[] { }, new int[] { })]
    [DataRow(new[] { 1, 8, 9 }, new[] { 3, 7, 8 })]
    [DataRow(new[] { 9, 9, 9 }, new[] { 1, 9, 9, 8 })]
    [DataRow(new[] { 0 }, new[] { 0 })]
    [DataRow(new[] { 1 }, new[] { 2 })]
    [DataRow(new[] { 5 }, new[] { 1, 0 })]
    [DataRow(new[] { 9 }, new[] { 1, 8 })]
    [DataRow(new[] { 1, 0 }, new[] { 2, 0 })]
    [DataRow(new[] { 2, 5 }, new[] { 5, 0 })]
    [DataRow(new[] { 4, 9 }, new[] { 9, 8 })]
    [DataRow(new[] { 5, 0 }, new[] { 1, 0, 0 })]
    [DataRow(new[] { 1, 2, 3 }, new[] { 2, 4, 6 })]
    [DataRow(new[] { 9, 9 }, new[] { 1, 9, 8 })]
    [DataRow(new[] { 1, 0, 0 }, new[] { 2, 0, 0 })]
    [DataRow(new[] { 4, 5, 6 }, new[] { 9, 1, 2 })]
    [DataRow(new[] { 7, 8, 9 }, new[] { 1, 5, 7, 8 })]
    [DataRow(new[] { 9, 9, 9, 9 }, new[] { 1, 9, 9, 9, 8 })]
    [DataRow(new[] { 1, 1, 1 }, new[] { 2, 2, 2 })]
    [DataRow(new[] { 5, 5, 5 }, new[] { 1, 1, 1, 0 })]
    [DataRow(new[] { 2, 0, 0 }, new[] { 4, 0, 0 })]
    [DataRow(new[] { 3, 4 }, new[] { 6, 8 })]
    [DataRow(new[] { 6, 3, 2, 1 }, new[] { 1, 2, 6, 4, 2 })]
    [DataRow(new[] { 8, 0, 0, 0 }, new[] { 1, 6, 0, 0, 0 })]
    [DataRow(new[] { 1, 9, 9, 9 }, new[] { 3, 9, 9, 8 })]
    [DataRow(new[] { 4, 9, 9, 9 }, new[] { 9, 9, 9, 8 })]
    [DataRow(new[] { 3 }, new[] { 6 })]
    [DataRow(new[] { 9, 0 }, new[] { 1, 8, 0 })]
    public void ListNode_DoubleIt_GivenListNode_ReturnsDoubledValuesListNode(int[] headArray, int[] expectedResultArray)
    {
        // Arrange
        var head = ListNode.ToListNode(headArray);

        var expectedResult = ListNode.ToListNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.DoubleIt(head);

        // Assert
        ListNodeAssert.AreEqual(expectedResult, actualResult);
    }
}