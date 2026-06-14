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

using LeetCode.Algorithms.MaximumTwinSumOfALinkedList;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.MaximumTwinSumOfALinkedList;

public abstract class MaximumTwinSumOfALinkedListTestsBase<T> where T : IMaximumTwinSumOfALinkedList, new()
{
    [TestMethod]
    [DataRow(new[] { 5, 4, 2, 1 }, 6)]
    [DataRow(new[] { 4, 2, 2, 3 }, 7)]
    [DataRow(new[] { 1, 100000 }, 100001)]
    [DataRow(new[] { 1, 2 }, 3)]
    [DataRow(new[] { 5, 5 }, 10)]
    [DataRow(new[] { 1, 2, 3, 4 }, 5)]
    [DataRow(new[] { 1, 1, 1, 1 }, 2)]
    [DataRow(new[] { 10, 20, 30, 40 }, 50)]
    [DataRow(new[] { 100000, 100000 }, 200000)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, 7)]
    [DataRow(new[] { 7, 3, 5, 9 }, 16)]
    [DataRow(new[] { 2, 4, 6, 8, 10, 12 }, 14)]
    [DataRow(new[] { 9, 1, 1, 9 }, 18)]
    [DataRow(new[] { 3, 1, 4, 1, 5, 9 }, 12)]
    [DataRow(new[] { 100, 1, 1, 100 }, 200)]
    [DataRow(new[] { 50, 60, 70, 80 }, 130)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 9)]
    [DataRow(new[] { 10, 1, 2, 3, 4, 100 }, 110)]
    [DataRow(new[] { 6, 6, 6, 6 }, 12)]
    [DataRow(new[] { 1, 3, 5, 7, 9, 11, 13, 15 }, 16)]
    [DataRow(new[] { 99999, 1 }, 100000)]
    [DataRow(new[] { 2, 2, 2, 2, 2, 2 }, 4)]
    [DataRow(new[] { 40, 30, 20, 10 }, 50)]
    public void PairSum_GivenHeadArray_ReturnsMaximumTwinSum(int[] headArray, int expectedResult)
    {
        // Arrange
        var head = ListNode.ToListNodeOrThrow(headArray);

        var solution = new T();

        // Act
        var actualResult = solution.PairSum(head);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}