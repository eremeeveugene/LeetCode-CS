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

using LeetCode.Algorithms.DeleteNodeInLinkedList;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.DeleteNodeInLinkedList;

public abstract class DeleteNodeInLinkedListTestsBase<T> where T : IDeleteNodeInLinkedList, new()
{
    [TestMethod]
    [DataRow(new int[] { }, 0, new int[] { })]
    [DataRow(new[] { 4 }, 4, new[] { 4 })]
    [DataRow(new[] { 1, 2 }, 1, new[] { 2 })]
    [DataRow(new[] { 1, 2 }, 2, new[] { 1, 2 })]
    [DataRow(new[] { 4, 5, 1, 9 }, 4, new[] { 5, 1, 9 })]
    [DataRow(new[] { 4, 5, 1, 9 }, 5, new[] { 4, 1, 9 })]
    [DataRow(new[] { 4, 5, 1, 9 }, 1, new[] { 4, 5, 9 })]
    [DataRow(new[] { 4, 5, 1, 9 }, 9, new[] { 4, 5, 1, 9 })]
    [DataRow(new[] { 4, 5, 1, 9 }, 7, new[] { 4, 5, 1, 9 })]
    [DataRow(new[] { 1, 2, 1, 3 }, 1, new[] { 2, 1, 3 })]
    [DataRow(new[] { 1, 2, 1, 3 }, 3, new[] { 1, 2, 1, 3 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 1, new[] { 2, 3, 4, 5 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 2, new[] { 1, 3, 4, 5 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 3, new[] { 1, 2, 4, 5 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 4, new[] { 1, 2, 3, 5 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 5, new[] { 1, 2, 3, 4, 5 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 9, new[] { 1, 2, 3, 4, 5 })]
    [DataRow(new[] { 0, 0, 0 }, 0, new[] { 0, 0 })]
    [DataRow(new[] { -1, -2, -3 }, -1, new[] { -2, -3 })]
    [DataRow(new[] { -1, -2, -3 }, -3, new[] { -1, -2, -3 })]
    public void DeleteNode_WhenNodeExists_RemovesNodeFromList(int[] actualResultArray, int node, int[] expectedResultArray)
    {
        // Arrange
        var actualResult = ListNode.ToListNode(actualResultArray);
        var expectedResult = ListNode.ToListNode(expectedResultArray);

        var solution = new T();

        // Act
        var nodeToDelete = actualResult;

        while (nodeToDelete != null)
        {
            if (nodeToDelete.val == node)
            {
                solution.DeleteNode(nodeToDelete);

                break;
            }

            nodeToDelete = nodeToDelete.next;
        }

        // Assert
        ListNodeAssert.AreEqual(expectedResult, actualResult);
    }
}