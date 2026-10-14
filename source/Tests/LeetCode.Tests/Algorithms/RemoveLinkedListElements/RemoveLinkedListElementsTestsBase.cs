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
    [DataRow(new[] { 1, 1, 1, 2 }, 1, new[] { 2 })]
    [DataRow(new[] { 2, 1, 1, 1 }, 1, new[] { 2 })]
    [DataRow(new[] { 1, 2, 1, 2, 1 }, 1, new[] { 2, 2 })]
    [DataRow(new[] { 1, 2, 3 }, 4, new[] { 1, 2, 3 })]
    [DataRow(new[] { 50, 50 }, 50, new int[] { })]
    [DataRow(new[] { 1, 2 }, 2, new[] { 1 })]
    [DataRow(new[] { 1, 2 }, 1, new[] { 2 })]
    [DataRow(new[] { 0, 1, 0, 2, 0 }, 0, new[] { 1, 2 })]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, 3, new[] { 5, 4, 2, 1 })]
    [DataRow(new[] { 3, 3, 4, 4, 3, 3 }, 3, new[] { 4, 4 })]
    [DataRow(new[] { 10, 20, 30, 40, 50 }, 50, new[] { 10, 20, 30, 40 })]
    [DataRow(new[] { 10, 20, 30, 40, 50 }, 10, new[] { 20, 30, 40, 50 })]
    [DataRow(new[] { 3, 1, 3, 5, 2, 3, 1, 1, 4, 2, 2, 4, 5, 1, 1, 4, 2, 4, 2, 4, 1, 5, 2, 3, 2, 5, 1, 5, 3, 1 }, 3, new[] { 1, 5, 2, 1, 1, 4, 2, 2, 4, 5, 1, 1, 4, 2, 4, 2, 4, 1, 5, 2, 2, 5, 1, 5, 1 })]
    [DataRow(new[] { 45, 30, 19, 9, 40, 44, 5, 50, 13, 10, 5, 40, 10, 23, 46, 21, 31, 41, 40, 11, 5, 13, 37, 11, 37, 4, 5, 23, 28, 21, 5, 19, 11, 50, 46, 18, 40, 29, 29, 49 }, 25, new[] { 45, 30, 19, 9, 40, 44, 5, 50, 13, 10, 5, 40, 10, 23, 46, 21, 31, 41, 40, 11, 5, 13, 37, 11, 37, 4, 5, 23, 28, 21, 5, 19, 11, 50, 46, 18, 40, 29, 29, 49 })]
    [DataRow(new[] { 1, 2, 2, 1, 1, 2, 1, 2, 2, 2, 1, 1, 1, 2, 2, 1, 1, 2, 2, 1, 1, 2, 1, 2, 2, 2, 1, 1, 1, 1, 1, 2, 1, 1, 1, 2, 2, 1, 1, 1, 1, 2, 1, 1, 2, 2, 2, 1, 1, 1 }, 2, new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 })]
    public void RemoveElements_WithListAndTargetValue_ReturnsListWithoutTargetValue(int[] headArray, int val, int[] expectedResultArray)
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