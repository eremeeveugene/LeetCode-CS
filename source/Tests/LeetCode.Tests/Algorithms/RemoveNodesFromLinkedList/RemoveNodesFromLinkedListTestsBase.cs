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
    [DataRow(new[] { 2, 1 }, new[] { 2, 1 })]
    [DataRow(new[] { 1, 2 }, new[] { 2 })]
    [DataRow(new[] { 5, 5, 4 }, new[] { 5, 5, 4 })]
    [DataRow(new[] { 4, 5, 5 }, new[] { 5, 5 })]
    [DataRow(new[] { 1, 3, 2, 4, 3, 5, 4 }, new[] { 5, 4 })]
    [DataRow(new[] { 100000, 1, 100000 }, new[] { 100000, 100000 })]
    [DataRow(new[] { 1, 100000 }, new[] { 100000 })]
    [DataRow(new[] { 100000, 1 }, new[] { 100000, 1 })]
    [DataRow(new[] { 2, 2, 1, 1, 3, 3 }, new[] { 3, 3 })]
    [DataRow(new[] { 7, 1, 7, 1, 7 }, new[] { 7, 7, 7 })]
    [DataRow(new[] { 1, 1, 2, 2, 1, 1 }, new[] { 2, 2, 1, 1 })]
    [DataRow(new[] { 10, 9, 8, 100, 7, 6, 5 }, new[] { 100, 7, 6, 5 })]
    [DataRow(new[] { 20, 16, 10, 20, 3, 7, 2, 16, 20, 15, 6, 12, 18, 15, 16, 15, 8, 2, 16, 13, 16, 1, 9, 6, 14, 6, 2, 4, 19, 4 }, new[] { 20, 20, 20, 19, 4 })]
    [DataRow(new[] { 46155, 54750, 84713, 76162, 358, 69736, 41134, 51476, 52890, 79086, 2666, 64142, 78471, 6974, 40078, 7013, 69628, 12830, 43759, 73570, 76726, 55832, 72794, 64666, 28241 }, new[] { 84713, 79086, 78471, 76726, 72794, 64666, 28241 })]
    [DataRow(new[] { 46, 42, 31, 31, 29, 29, 27, 25, 21, 17, 17, 16, 11, 11, 10, 9, 8, 7, 5, 1 }, new[] { 46, 42, 31, 31, 29, 29, 27, 25, 21, 17, 17, 16, 11, 11, 10, 9, 8, 7, 5, 1 })]
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