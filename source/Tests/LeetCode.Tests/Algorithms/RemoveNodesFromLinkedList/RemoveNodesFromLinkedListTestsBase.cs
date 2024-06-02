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

using LeetCode.Algorithms.RemoveNodesFromLinkedList;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.RemoveNodesFromLinkedList;

public abstract class RemoveNodesFromLinkedListTestsBase<T> where T : IRemoveNodesFromLinkedList, new()
{
    [TestMethod]
    [DataRow(new[] { 1 }, new[] { 1 })]
    [DataRow(new[] { 1, 1, 1, 1 }, new[] { 1, 1, 1, 1 })]
    [DataRow(new[] { 5, 2, 13, 3, 8 }, new[] { 13, 8 })]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new[] { 9 })]
    [DataRow(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 }, new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 })]
    [DataRow(new[] { 1, 2, 3, 1, 2, 3, 1, 2, 3 }, new[] { 3, 3, 3 })]
    [DataRow(new[] { 3, 2, 1, 3, 2, 1, 3, 2, 1 }, new[] { 3, 3, 3, 2, 1 })]
    public void RemoveNodes_WithVariousLists_RemovesExpectedNodes(int[] headArray, int[] expectedResultArray)
    {
        // Arrange
        var head = ListNode.ToListNode(headArray);

        var expectedResult = ListNode.ToListNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.RemoveNodes(head);

        // Assert
        ListNodeAssert.AreEqual(expectedResult, actualResult);
    }
}