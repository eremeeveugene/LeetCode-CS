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

using LeetCode.Algorithms.ConvertBinaryNumberInLinkedListToInteger;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.ConvertBinaryNumberInLinkedListToInteger;

public abstract class ConvertBinaryNumberInLinkedListToIntegerTestsBase<T> where T : IConvertBinaryNumberInLinkedListToInteger, new()
{
    [TestMethod]
    [DataRow(new[] { 0 }, 0)]
    [DataRow(new[] { 1, 0, 1 }, 5)]
    [DataRow(new[] { 1 }, 1)]
    [DataRow(new[] { 1, 1 }, 3)]
    [DataRow(new[] { 1, 0 }, 2)]
    [DataRow(new[] { 1, 1, 1 }, 7)]
    [DataRow(new[] { 1, 0, 0 }, 4)]
    [DataRow(new[] { 1, 1, 0, 1 }, 13)]
    [DataRow(new[] { 0, 0, 1 }, 1)]
    [DataRow(new[] { 1, 0, 0, 0 }, 8)]
    [DataRow(new[] { 1, 1, 1, 1, 1 }, 31)]
    [DataRow(new[] { 1, 0, 1, 0, 1, 0 }, 42)]
    [DataRow(new[] { 0, 0, 0 }, 0)]
    [DataRow(new[] { 1, 1, 1, 1, 1, 1, 1, 1 }, 255)]
    [DataRow(new[] { 1, 0, 0, 1, 0, 0, 1 }, 73)]
    [DataRow(new[] { 1, 1, 0, 0, 1, 1 }, 51)]
    [DataRow(new[] { 0, 1, 0, 1 }, 5)]
    [DataRow(new[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 536870912)]
    [DataRow(new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 1073741823)]
    [DataRow(new[] { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 }, 715827882)]
    [DataRow(new[] { 1, 0, 1, 1, 0, 1 }, 45)]
    public void GetDecimalValue_WithBinaryLinkedList_ReturnsDecimalValue(int[] headArray, int expectedResult)
    {
        // Arrange
        var head = ListNode.ToListNodeOrThrow(headArray);

        var solution = new T();

        // Act
        var actualResult = solution.GetDecimalValue(head);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}