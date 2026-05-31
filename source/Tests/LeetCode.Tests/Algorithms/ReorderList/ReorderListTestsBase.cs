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

using LeetCode.Algorithms.ReorderList;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.ReorderList;

public abstract class ReorderListTestsBase<T> where T : IReorderList, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4 }, new[] { 1, 4, 2, 3 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 5, 2, 4, 3 })]
    [DataRow(new[] { 1 }, new[] { 1 })]
    [DataRow(new[] { 1, 2 }, new[] { 1, 2 })]
    [DataRow(new[] { 1, 2, 3 }, new[] { 1, 3, 2 })]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, new[] { 1, 6, 2, 5, 3, 4 })]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7 }, new[] { 1, 7, 2, 6, 3, 5, 4 })]
    [DataRow(new[] { 10, 20 }, new[] { 10, 20 })]
    [DataRow(new[] { 5, 5, 5, 5 }, new[] { 5, 5, 5, 5 })]
    [DataRow(new[] { 1, 1, 1 }, new[] { 1, 1, 1 })]
    [DataRow(new[] { 100, 200, 300 }, new[] { 100, 300, 200 })]
    [DataRow(new[] { -1, -2, -3, -4 }, new[] { -1, -4, -2, -3 })]
    [DataRow(new[] { 0, 1, 2, 3, 4 }, new[] { 0, 4, 1, 3, 2 })]
    [DataRow(new[] { 1, 3, 5, 7, 9, 11 }, new[] { 1, 11, 3, 9, 5, 7 })]
    [DataRow(new[] { 7, 7, 7, 7, 7, 7, 7, 7 }, new[] { 7, 7, 7, 7, 7, 7, 7, 7 })]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new[] { 1, 8, 2, 7, 3, 6, 4, 5 })]
    [DataRow(new[] { 0, 0 }, new[] { 0, 0 })]
    [DataRow(new[] { -5, 0, 5 }, new[] { -5, 5, 0 })]
    public void ReorderList_GivenHeadArray_ResultsInExpectedOrder(int[] headArray, int[] expectedResultArray)
    {
        // Arrange
        var head = ListNode.ToListNode(headArray);
        var expectedResult = ListNode.ToListNode(expectedResultArray);

        var solution = new T();

        // Act
        solution.ReorderList(head);

        // Assert
        ListNodeAssert.AreEqual(expectedResult, head);
    }
}