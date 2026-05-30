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