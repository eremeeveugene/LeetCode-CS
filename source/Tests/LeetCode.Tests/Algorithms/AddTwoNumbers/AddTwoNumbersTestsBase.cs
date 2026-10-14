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

using LeetCode.Algorithms.AddTwoNumbers;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.AddTwoNumbers;

public abstract class AddTwoNumbersTestsBase<T> where T : IAddTwoNumbers, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 4, 3 }, new[] { 5, 6, 4 }, new[] { 7, 0, 8 })]
    [DataRow(new[] { 0 }, new[] { 0 }, new[] { 0 })]
    [DataRow(new[] { 9, 9, 9, 9, 9, 9, 9 }, new[] { 9, 9, 9, 9 }, new[] { 8, 9, 9, 9, 0, 0, 0, 1 })]
    [DataRow(new[] { 9 }, new[] { 1, 9, 9, 9, 9, 9, 9, 9, 9, 9 }, new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 })]
    [DataRow(new[] { 1 }, new[] { 1 }, new[] { 2 })]
    [DataRow(new[] { 5 }, new[] { 5 }, new[] { 0, 1 })]
    [DataRow(new[] { 9, 9 }, new[] { 1 }, new[] { 0, 0, 1 })]
    [DataRow(new[] { 1 }, new[] { 9, 9 }, new[] { 0, 0, 1 })]
    [DataRow(new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 5, 7, 9 })]
    [DataRow(new[] { 0 }, new[] { 1, 2 }, new[] { 1, 2 })]
    [DataRow(new[] { 1, 2 }, new[] { 0 }, new[] { 1, 2 })]
    [DataRow(new[] { 9 }, new[] { 9 }, new[] { 8, 1 })]
    [DataRow(new[] { 2, 4, 3, 1 }, new[] { 5, 6, 4 }, new[] { 7, 0, 8, 1 })]
    [DataRow(new[] { 1, 8 }, new[] { 2, 2 }, new[] { 3, 0, 1 })]
    [DataRow(new[] { 9, 9, 9 }, new[] { 1 }, new[] { 0, 0, 0, 1 })]
    [DataRow(new[] { 5, 5, 5 }, new[] { 5, 5, 5 }, new[] { 0, 1, 1, 1 })]
    [DataRow(new[] { 3, 7 }, new[] { 8, 2 }, new[] { 1, 0, 1 })]
    [DataRow(new[] { 1, 0, 0, 1 }, new[] { 9, 9, 9, 8 }, new[] { 0, 0, 0, 0, 1 })]
    [DataRow(new[] { 7 }, new[] { 8, 9, 9 }, new[] { 5, 0, 0, 1 })]
    [DataRow(new[] { 4, 3, 2, 1 }, new[] { 1, 1, 1, 1 }, new[] { 5, 4, 3, 2 })]
    public void AddTwoNumbers_WithTwoIntegerArrays_ReturnsSumAsLinkedList(int[] array1, int[] array2, int[] expectedResultArray)
    {
        // Arrange
        var list1 = ListNode.ToListNode(array1);
        var list2 = ListNode.ToListNode(array2);
        var expectedResult = ListNode.ToListNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.AddTwoNumbers(list1, list2);

        // Assert
        ListNodeAssert.AreEqual(expectedResult, actualResult);
    }
}