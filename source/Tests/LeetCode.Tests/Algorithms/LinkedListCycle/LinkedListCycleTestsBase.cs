// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.LinkedListCycle;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.LinkedListCycle;

public abstract class LinkedListCycleTestsBase<T> where T : ILinkedListCycle, new()
{
    [TestMethod]
    [DataRow(new int[] { }, -1, false)]
    [DataRow(new[] { 3, 2, 0, -4 }, 1, true)]
    [DataRow(new[] { 1, 2 }, 0, true)]
    [DataRow(new[] { 1 }, -1, false)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, -1, false)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 4, true)]
    [DataRow(new[] { 1, 1, 1, 1, 1 }, 0, true)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 2, true)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 0, true)]
    public void HasCycle_GivenLinkedList_ReturnsCorrectCycleDetectionOutcome(int[] headArray, int pos,
        bool expectedResult)
    {
        // Arrange
        var head = ListNode.ToCycledListNode(headArray, pos);

        var solution = new T();

        // Act
        var actualResult = solution.HasCycle(head);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}