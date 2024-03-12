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

using LeetCode.Algorithms.RemoveZeroSumConsecutiveNodesFromLinkedList;
using LeetCode.Core.Extensions;
using LeetCode.Tests.Extensions;

namespace LeetCode.Tests.Algorithms.RemoveZeroSumConsecutiveNodesFromLinkedList;

public abstract class RemoveZeroSumConsecutiveNodesFromLinkedListTestsBase<T>
    where T : IRemoveZeroSumConsecutiveNodesFromLinkedList, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, -3, 3, 1 }, new[] { 3, 1 })]
    [DataRow(new[] { 1, 2, 3, -3, 4 }, new[] { 1, 2, 4 })]
    [DataRow(new[] { 1, 2, 3, -3, -2 }, new[] { 1 })]
    public void RemoveZeroSumSublists_WithVariousLists_ReturnsExpectedResult(int[] headArray, int[] expectedResultArray)
    {
        // Arrange
        var solution = new T();

        var head = headArray.ToListNode();
        var expectedResult = expectedResultArray.ToListNode();

        // Act
        var actualResult = solution.RemoveZeroSumSublists(head);

        // Assert
        AssertExtensions.AreListNodesEqual(expectedResult, actualResult);
    }
}