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

using LeetCode.Algorithms.RemoveDuplicatesFromSortedList;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.RemoveDuplicatesFromSortedList;

public abstract class RemoveDuplicatesFromSortedListTestsBase<T> where T : IRemoveDuplicatesFromSortedList, new()
{
    [TestMethod]
    [DataRow(new[] { 0, 0, 0, 0, 0 }, new[] { 0 })]
    [DataRow(new[] { 1, 1, 2 }, new[] { 1, 2 })]
    [DataRow(new[] { 1, 1, 2, 3, 3 }, new[] { 1, 2, 3 })]
    [DataRow(new int[] { }, new int[] { })]
    [DataRow(new[] { 1 }, new[] { 1 })]
    [DataRow(new[] { 1, 1 }, new[] { 1 })]
    [DataRow(new[] { 1, 2 }, new[] { 1, 2 })]
    [DataRow(new[] { -100, -100, 100, 100 }, new[] { -100, 100 })]
    [DataRow(new[] { 2, 2, 2, 3, 3, 4 }, new[] { 2, 3, 4 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5 })]
    [DataRow(new[] { -3, -3, -2, -1, -1, 0, 0, 1 }, new[] { -3, -2, -1, 0, 1 })]
    [DataRow(new[] { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 }, new[] { 5 })]
    [DataRow(new[] { -100, 100 }, new[] { -100, 100 })]
    [DataRow(new[] { 0, 1, 1, 2, 2, 2, 3, 3, 3, 3 }, new[] { 0, 1, 2, 3 })]
    [DataRow(new[] { 10, 20, 20, 30, 40, 40, 40, 50 }, new[] { 10, 20, 30, 40, 50 })]
    [DataRow(new[] { -7, -7, -7, -5, -5, 0, 4, 4, 9, 9, 9, 9 }, new[] { -7, -5, 0, 4, 9 })]
    [DataRow(new[] { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7 }, new[] { 1, 2, 3, 4, 5, 6, 7 })]
    [DataRow(new[] { -19, -18, -17, -17, -16, -15, -15, -11, -10, -10, -10, -4, -4, -1, 2, 2, 3, 4, 4, 6, 7, 7, 9, 10, 10, 16, 17, 17, 18, 19 }, new[] { -19, -18, -17, -16, -15, -11, -10, -4, -1, 2, 3, 4, 6, 7, 9, 10, 16, 17, 18, 19 })]
    [DataRow(new[] { -100, -94, -90, -76, -66, -65, -59, -58, -45, -37, -37, -27, -20, -16, -16, -10, -9, -4, 4, 6, 13, 15, 18, 21, 32, 33, 36, 39, 55, 58, 59, 60, 68, 68, 71, 74, 76, 81, 86, 98 }, new[] { -100, -94, -90, -76, -66, -65, -59, -58, -45, -37, -27, -20, -16, -10, -9, -4, 4, 6, 13, 15, 18, 21, 32, 33, 36, 39, 55, 58, 59, 60, 68, 71, 74, 76, 81, 86, 98 })]
    [DataRow(new[] { -5, -5, -5, -4, -4, -4, -4, -3, -3, -3, -2, -2, -2, -2, -2, -2, -2, -1, -1, 0, 0, 0, 0, 1, 2, 2, 2, 3, 3, 3, 3, 4, 4, 5, 5 }, new[] { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 })]
    public void DeleteDuplicates_WithSortedLinkedList_ReturnsLinkedListWithUniqueSortedElements(int[] headArray, int[] expectedResultArray)
    {
        // Arrange
        var head = ListNode.ToListNode(headArray);
        var expectedResult = ListNode.ToListNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.DeleteDuplicates(head);

        // Assert
        ListNodeAssert.AreEqual(expectedResult, actualResult);
    }
}