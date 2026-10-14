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

using LeetCode.Algorithms.ReverseLinkedList;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.ReverseLinkedList;

public abstract class ReverseLinkedListTestsBase<T> where T : IReverseLinkedList, new()
{
    [TestMethod]
    [DataRow(new int[] { }, new int[] { })]
    [DataRow(new[] { 1, 2 }, new[] { 2, 1 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, new[] { 5, 4, 3, 2, 1 })]
    [DataRow(new[] { 1 }, new[] { 1 })]
    [DataRow(new[] { 0 }, new[] { 0 })]
    [DataRow(new[] { 5000 }, new[] { 5000 })]
    [DataRow(new[] { -5000 }, new[] { -5000 })]
    [DataRow(new[] { 1, 1 }, new[] { 1, 1 })]
    [DataRow(new[] { 1, 2, 3 }, new[] { 3, 2, 1 })]
    [DataRow(new[] { 3, 2, 1 }, new[] { 1, 2, 3 })]
    [DataRow(new[] { 0, 0, 0 }, new[] { 0, 0, 0 })]
    [DataRow(new[] { -1, 0, 1 }, new[] { 1, 0, -1 })]
    [DataRow(new[] { 5000, -5000 }, new[] { -5000, 5000 })]
    [DataRow(new[] { 1, 2, 3, 4 }, new[] { 4, 3, 2, 1 })]
    [DataRow(new[] { 10, 20, 30, 40, 50, 60 }, new[] { 60, 50, 40, 30, 20, 10 })]
    [DataRow(new[] { 1, 2, 1, 2, 1 }, new[] { 1, 2, 1, 2, 1 })]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }, new[] { 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 })]
    [DataRow(new[] { 4692, 1945, -1934, 2528, -4069, -2104, -1485, -2971, -3016, -1016, -3892, 68, 816, 499, -2152, -2945, -2631, 3110, 2876, 745, -1205, -1454, -1762, 1719, 2423, -1670, -4479, 4906, -1400, -469 }, new[] { -469, -1400, 4906, -4479, -1670, 2423, 1719, -1762, -1454, -1205, 745, 2876, 3110, -2631, -2945, -2152, 499, 816, 68, -3892, -1016, -3016, -2971, -1485, -2104, -4069, 2528, -1934, 1945, 4692 })]
    [DataRow(new[] { 3818, 3402, 1498, -3670, 2611, 823, -4950, 2894, 2049, 2366, -979, -1476, 3301, -2392, -569, 2417, -2529, -189, -4651, 4250, 236, 1750, 678, 4901, -4331, 3055, -249, -537, -3766, 928, -786, -3043, 4423, 4157, -2152, 1673, -1932, -2933, 2627, -3746, 4364, -4033, 518, -322, -283, 4850, -4118, -2724, 648, 4842, 4349 }, new[] { 4349, 4842, 648, -2724, -4118, 4850, -283, -322, 518, -4033, 4364, -3746, 2627, -2933, -1932, 1673, -2152, 4157, 4423, -3043, -786, 928, -3766, -537, -249, 3055, -4331, 4901, 678, 1750, 236, 4250, -4651, -189, -2529, 2417, -569, -2392, 3301, -1476, -979, 2366, 2049, 2894, -4950, 823, 2611, -3670, 1498, 3402, 3818 })]
    [DataRow(new[] { 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7 }, new[] { 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7 })]
    public void ReverseList_WithSinglyLinkedList_ReturnsListInReversedOrder(int[] headArray, int[] expectedResultArray)
    {
        // Arrange
        var head = ListNode.ToListNode(headArray);
        var expectedResult = ListNode.ToListNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.ReverseList(head);

        // Assert
        ListNodeAssert.AreEqual(expectedResult, actualResult);
    }
}