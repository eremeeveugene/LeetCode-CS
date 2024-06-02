﻿// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.MergeTwoSortedLists;
using LeetCode.Core.Extensions;
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
    public void MergeTwoLists_WithTwoIntegerArrays_ReturnsMergedSortedLinkedList(int[] array1, int[] array2,
        int[] expectedResultArray)
    {
        // Arrange
        var solution = new T();

        var list1 = array1.ToListNode();
        var list2 = array2.ToListNode();
        var expectedResult = expectedResultArray.ToListNode();

        // Act
        var actualResult = solution.MergeTwoLists(list1, list2);

        // Assert
        AssertExtensions.AreListNodesEqual(expectedResult, actualResult);
    }
}