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

using LeetCode.Algorithms.MergeTwoSortedLists;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.MergeTwoSortedLists;

public abstract class MergeTwoSortedListsTestsBase<T> where T : IMergeTwoSortedLists, new()
{
    [TestMethod]
    [DataRow(new int[] { }, new int[] { }, new int[] { })]
    [DataRow(new int[] { }, new[] { 0 }, new[] { 0 })]
    [DataRow(new[] { 0 }, new int[] { }, new[] { 0 })]
    [DataRow(new[] { 1, 2, 4 }, new[] { 1, 3, 4 }, new[] { 1, 1, 2, 3, 4, 4 })]
    [DataRow(new[] { -9, 3 }, new[] { 5, 7 }, new[] { -9, 3, 5, 7 })]
    [DataRow(new[] { 1 }, new[] { 2 }, new[] { 1, 2 })]
    [DataRow(new[] { 2 }, new[] { 1 }, new[] { 1, 2 })]
    [DataRow(new[] { 1, 1 }, new[] { 1, 1 }, new[] { 1, 1, 1, 1 })]
    [DataRow(new[] { -100, 100 }, new[] { 0 }, new[] { -100, 0, 100 })]
    [DataRow(new[] { 5, 6, 7 }, new[] { 1, 2, 3 }, new[] { 1, 2, 3, 5, 6, 7 })]
    [DataRow(new[] { 1, 2, 3 }, new[] { 7, 8, 9 }, new[] { 1, 2, 3, 7, 8, 9 })]
    [DataRow(new[] { -3, -2, -1 }, new[] { -3, -2, -1 }, new[] { -3, -3, -2, -2, -1, -1 })]
    [DataRow(new[] { 0 }, new[] { 0 }, new[] { 0, 0 })]
    [DataRow(new[] { 1, 3, 5, 7, 9 }, new[] { 2, 4, 6, 8, 10 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
    [DataRow(new[] { 10, 20 }, new[] { 15 }, new[] { 10, 15, 20 })]
    [DataRow(new[] { -100 }, new[] { 100 }, new[] { -100, 100 })]
    [DataRow(new[] { 2, 2, 2 }, new[] { 1, 3 }, new[] { 1, 2, 2, 2, 3 })]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, new[] { 5, 5, 5 }, new[] { 1, 2, 3, 4, 5, 5, 5, 5, 6, 7, 8, 9, 10 })]
    [DataRow(new[] { 100, 100 }, new[] { -100, -100, -100 }, new[] { -100, -100, -100, 100, 100 })]
    [DataRow(new[] { 4 }, new[] { 1, 2, 3, 5, 6 }, new[] { 1, 2, 3, 4, 5, 6 })]
    public void MergeTwoLists_WithTwoIntegerArrays_ReturnsMergedSortedLinkedList(int[] list1Array, int[] list2Array, int[] expectedResultArray)
    {
        // Arrange
        var list1 = ListNode.ToListNode(list1Array);
        var list2 = ListNode.ToListNode(list2Array);
        var expectedResult = ListNode.ToListNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.MergeTwoLists(list1, list2);

        // Assert
        ListNodeAssert.AreEqual(expectedResult, actualResult);
    }
}