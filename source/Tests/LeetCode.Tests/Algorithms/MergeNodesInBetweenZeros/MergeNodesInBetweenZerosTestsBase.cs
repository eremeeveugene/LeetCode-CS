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

using LeetCode.Algorithms.MergeNodesInBetweenZeros;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.MergeNodesInBetweenZeros;

public abstract class MergeNodesInBetweenZerosTestsBase<T> where T : IMergeNodesInBetweenZeros, new()
{
    [TestMethod]
    [DataRow(new[] { 0, 3, 1, 0, 4, 5, 2, 0 }, new[] { 4, 11 })]
    [DataRow(new[] { 0, 1, 0, 3, 0, 2, 2, 0 }, new[] { 1, 3, 4 })]
    [DataRow(new[] { 0, 200, 300, 0, 400, 500, 0 }, new[] { 500, 900 })]
    [DataRow(new[] { 0, 1, 0 }, new[] { 1 })]
    [DataRow(new[] { 0, 1000000, 0 }, new[] { 1000000 })]
    [DataRow(new[] { 0, 1, 2, 3, 0 }, new[] { 6 })]
    [DataRow(new[] { 0, 5, 0, 5, 0 }, new[] { 5, 5 })]
    [DataRow(new[] { 0, 1, 0, 2, 0, 3, 0 }, new[] { 1, 2, 3 })]
    [DataRow(new[] { 0, 100, 200, 300, 0 }, new[] { 600 })]
    [DataRow(new[] { 0, 7, 0, 3, 0 }, new[] { 7, 3 })]
    [DataRow(new[] { 0, 1, 1, 1, 0 }, new[] { 3 })]
    [DataRow(new[] { 0, 999999, 1, 0 }, new[] { 1000000 })]
    [DataRow(new[] { 0, 10, 20, 0, 30, 0 }, new[] { 30, 30 })]
    [DataRow(new[] { 0, 0, 5, 0 }, new[] { 0, 5 })]
    [DataRow(new[] { 0, 1, 0, 1, 0, 1, 0 }, new[] { 1, 1, 1 })]
    [DataRow(new[] { 0, 50, 50, 0, 100, 0 }, new[] { 100, 100 })]
    [DataRow(new[] { 0, 2, 4, 6, 0, 1, 3, 5, 0 }, new[] { 12, 9 })]
    [DataRow(new int[] { }, new int[] { })]
    [DataRow(new[] { 0, 5, 0 }, new[] { 5 })]
    [DataRow(new[] { 0, 1, 2, 3, 4, 5, 0 }, new[] { 15 })]
    [DataRow(new[] { 0, 10, 0, 20, 0, 30, 0 }, new[] { 10, 20, 30 })]
    [DataRow(new[] { 0, 42, 0 }, new[] { 42 })]
    [DataRow(new[] { 0, 1, 2, 0, 3, 4, 0, 5, 6, 0 }, new[] { 3, 7, 11 })]
    public void MergeNodes_WithZeroDelimitedValues_ReturnsListWithSegmentSums(int[] headArray, int[] expectedResultArray)
    {
        // Arrange
        var head = ListNode.ToListNode(headArray);
        var expectedResult = ListNode.ToListNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.MergeNodes(head);

        // Assert
        ListNodeAssert.AreEqual(expectedResult, actualResult);
    }
}