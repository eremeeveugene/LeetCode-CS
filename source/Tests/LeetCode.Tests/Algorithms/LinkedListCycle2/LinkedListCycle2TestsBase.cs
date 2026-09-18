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

using LeetCode.Algorithms.LinkedListCycle2;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.LinkedListCycle2;

public abstract class LinkedListCycle2TestsBase<T> where T : ILinkedListCycle2, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 2, 0, -4 }, 1, 1)]
    [DataRow(new[] { 1, 2 }, 0, 0)]
    [DataRow(new[] { 1 }, -1, -1)]
    [DataRow(new int[] { }, -1, -1)]
    [DataRow(new[] { 1 }, 0, 0)]
    [DataRow(new[] { 0 }, 0, 0)]
    [DataRow(new[] { -100000 }, 0, 0)]
    [DataRow(new[] { 1, 2 }, -1, -1)]
    [DataRow(new[] { 1, 2 }, 1, 1)]
    [DataRow(new[] { 5, 5 }, -1, -1)]
    [DataRow(new[] { 5, 5 }, 0, 0)]
    [DataRow(new[] { 5, 5 }, 1, 1)]
    [DataRow(new[] { 1, 2, 3 }, -1, -1)]
    [DataRow(new[] { 1, 2, 3 }, 0, 0)]
    [DataRow(new[] { 1, 2, 3 }, 1, 1)]
    [DataRow(new[] { 1, 2, 3 }, 2, 2)]
    [DataRow(new[] { 1, 2, 3, 4 }, -1, -1)]
    [DataRow(new[] { 1, 2, 3, 4 }, 0, 0)]
    [DataRow(new[] { 1, 2, 3, 4 }, 1, 1)]
    [DataRow(new[] { 1, 2, 3, 4 }, 2, 2)]
    [DataRow(new[] { 1, 2, 3, 4 }, 3, 3)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, -1, -1)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 2, 2)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 4, 4)]
    [DataRow(new[] { 7, 7, 7, 7, 7 }, 3, 3)]
    [DataRow(new[] { -100000, 0, 100000 }, 1, 1)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 0, 0)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 1, 1)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 8, 8)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 9, 9)]
    public void DetectCycle_WithLinkedListAndCyclePosition_ReturnsCycleEntryNode(int[] headArray, int pos, int expectedDistance)
    {
        // Arrange
        var head = ListNode.ToCycledListNode(headArray, pos, expectedDistance, out var expectedResult);

        var solution = new T();

        // Act
        var actualResult = solution.DetectCycle(head);

        // Assert
        Assert.AreSame(expectedResult, actualResult);
    }
}