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
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.DeleteNodeInLinkedList;

public abstract class DeleteNodeInLinkedListTestsBase<T> where T : IDeleteNodeInLinkedList, new()
{
    [TestMethod]
    [DataRow("[]", 0, "[]")]
    [DataRow("[4, 5, 1, 9]", 5, "[4, 1, 9]")]
    [DataRow("[4, 5, 1, 9]", 1, "[4, 5, 9]")]
    public void DeleteNode_WhenNodeExists_RemovesNodeFromList(string actualResultJsonArray, int node,
        string expectedResultJsonArray)
    {
        // Arrange
        var actualResultArray = JsonHelper<int>.DeserializeToArray(actualResultJsonArray);
        var expectedResultArray = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);


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