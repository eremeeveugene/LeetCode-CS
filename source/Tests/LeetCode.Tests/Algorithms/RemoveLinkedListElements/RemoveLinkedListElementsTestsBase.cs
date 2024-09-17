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

using LeetCode.Algorithms.RemoveLinkedListElements;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.RemoveLinkedListElements;

public abstract class RemoveLinkedListElementsTestsBase<T> where T : IRemoveLinkedListElements, new()
{
    [TestMethod]
    [DataRow(new int[] { }, 1, new int[] { })]
    [DataRow(new[] { 1 }, 1, new int[] { })]
    [DataRow(new[] { 1 }, 0, new[] { 1 })]
    [DataRow(new[] { 1, 2, 6, 3, 4, 5, 6 }, 6, new[] { 1, 2, 3, 4, 5 })]
    [DataRow(new[] { 7, 7, 7, 7 }, 7, new int[] { })]
    public void RemoveElements_WithHeadArrayAndValue_ReturnsExpectedResult(int[] headArray, int val,
        int[] expectedResultArray)
    {
        // Arrange
        var head = ListNode.ToListNode(headArray);

        var expectedResult = ListNode.ToListNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.RemoveElements(head, val);

        // Assert
        ListNodeAssert.AreEqual(expectedResult, actualResult);
    }
}