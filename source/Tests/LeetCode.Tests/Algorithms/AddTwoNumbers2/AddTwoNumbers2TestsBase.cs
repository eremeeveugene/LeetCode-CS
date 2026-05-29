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

using LeetCode.Algorithms.AddTwoNumbers2;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.AddTwoNumbers2;

public abstract class AddTwoNumbers2TestsBase<T> where T : IAddTwoNumbers2, new()
{
    [TestMethod]
    [DataRow(new[] { 0 }, new[] { 0 }, new[] { 0 })]
    [DataRow(new[] { 7, 2, 4, 3 }, new[] { 5, 6, 4 }, new[] { 7, 8, 0, 7 })]
    [DataRow(new[] { 2, 4, 3 }, new[] { 5, 6, 4 }, new[] { 8, 0, 7 })]
    public void AddTwoNumbers_WithTwoLinkedLists_ReturnsSumAsLinkedList(int[] l1Array, int[] l2Array,
        int[] expectedResultArray)
    {
        // Arrange
        var l1 = ListNode.ToListNodeOrThrow(l1Array);
        var l2 = ListNode.ToListNodeOrThrow(l2Array);
        var expectedResult = ListNode.ToListNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.AddTwoNumbers(l1, l2);

        // Assert
        ListNodeAssert.AreEqual(expectedResult, actualResult);
    }
}