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

using LeetCode.Algorithms.DeleteTheMiddleNodeOfALinkedList;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.DeleteTheMiddleNodeOfALinkedList;

public abstract class DeleteTheMiddleNodeOfALinkedListTestsBase<T> where T : IDeleteTheMiddleNodeOfALinkedList, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 3, 4, 7, 1, 2, 6 }, new[] { 1, 3, 4, 1, 2, 6 })]
    [DataRow(new[] { 1, 2, 3, 4 }, new[] { 1, 2, 4 })]
    [DataRow(new[] { 2, 1 }, new[] { 2 })]
    [DataRow(new[] { 1 }, new int[] { })]
    [DataRow(new[] { 1, 2, 3 }, new[] { 1, 3 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 4, 5 })]
    [DataRow(new[] { 10, 20 }, new[] { 10 })]
    [DataRow(new[] { 5, 5, 5, 5 }, new[] { 5, 5, 5 })]
    [DataRow(new[] { 100000 }, new int[] { })]
    [DataRow(new[] { 1, 100000 }, new[] { 1 })]
    [DataRow(new[] { 7, 3, 5, 9, 1, 2 }, new[] { 7, 3, 5, 1, 2 })]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7 }, new[] { 1, 2, 3, 5, 6, 7 })]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new[] { 1, 2, 3, 4, 6, 7, 8 })]
    [DataRow(new[] { 9, 8, 7, 6, 5 }, new[] { 9, 8, 6, 5 })]
    [DataRow(new[] { 2, 4, 6, 8, 10, 12 }, new[] { 2, 4, 6, 10, 12 })]
    [DataRow(new[] { 1, 1, 1 }, new[] { 1, 1 })]
    [DataRow(new[] { 42, 17 }, new[] { 42 })]
    [DataRow(new[] { 3, 1, 4, 1, 5, 9, 2 }, new[] { 3, 1, 4, 5, 9, 2 })]
    [DataRow(new[] { 50, 60, 70, 80, 90, 100 }, new[] { 50, 60, 70, 90, 100 })]
    [DataRow(new[] { 11, 22, 33, 44, 55, 66, 77, 88, 99 }, new[] { 11, 22, 33, 44, 66, 77, 88, 99 })]
    [DataRow(new[] { 4, 3, 2, 1 }, new[] { 4, 3, 1 })]
    [DataRow(new[] { 99999, 1, 99999 }, new[] { 99999, 99999 })]
    public void DeleteMiddle_GivenHeadArray_ReturnsListWithMiddleNodeRemoved(int[] headArray, int[] expectedResultArray)
    {
        // Arrange
        var head = ListNode.ToListNodeOrThrow(headArray);
        var expectedResult = ListNode.ToListNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.DeleteMiddle(head);

        // Assert
        ListNodeAssert.AreEqual(expectedResult, actualResult);
    }
}