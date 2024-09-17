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

using LeetCode.Algorithms.RemoveDuplicatesFromSortedList;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.RemoveDuplicatesFromSortedList;

public abstract class RemoveDuplicatesFromSortedListTestsBase<T> where T : IRemoveDuplicatesFromSortedList, new()
{
    [TestMethod]
    [DataRow("[0,0,0,0,0]", "[0]")]
    [DataRow("[1,1,2]", "[1,2]")]
    [DataRow("[1,1,2,3,3]", "[1,2,3]")]
    public void DeleteDuplicates_GivenLinkedList_RemovesDuplicatesAndReturnsExpectedList(string headJsonArray,
        string expectedResultJsonArray)
    {
        // Arrange
        var headArray = JsonHelper<int>.DeserializeToArray(headJsonArray);
        var head = ListNode.ToListNode(headArray);
        var expectedResultArray = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);
        var expectedResult = ListNode.ToListNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.DeleteDuplicates(head);

        // Assert
        ListNodeAssert.AreEqual(expectedResult, actualResult);
    }
}