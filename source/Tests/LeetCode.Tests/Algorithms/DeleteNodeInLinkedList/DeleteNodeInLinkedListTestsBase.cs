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

using LeetCode.Algorithms.DeleteNodeInLinkedList;
using LeetCode.Core.Extensions;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.DeleteNodeInLinkedList;

public abstract class DeleteNodeInLinkedListTestsBase<T> where T : IDeleteNodeInLinkedList, new()
{
    [TestMethod]
    [DataRow(new[] { 4, 5, 1, 9 }, 5, new[] { 4, 1, 9 })]
    [DataRow(new[] { 4, 5, 1, 9 }, 1, new[] { 4, 5, 9 })]
    public void DeleteNode_WhenNodeExists_RemovesNodeFromList(int[] actualResultArray, int node,
        int[] expectedResultArray)
    {
        // Arrange
        var actualResult = actualResultArray.ToListNode();
        var expectedResult = expectedResultArray.ToListNode();

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
        AssertExtensions.AreListNodesEqual(expectedResult, actualResult);
    }
}