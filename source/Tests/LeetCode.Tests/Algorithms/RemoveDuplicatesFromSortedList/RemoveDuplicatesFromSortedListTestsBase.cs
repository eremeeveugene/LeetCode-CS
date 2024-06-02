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
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.RemoveDuplicatesFromSortedList;

public abstract class RemoveDuplicatesFromSortedListTestsBase<T> where T : IRemoveDuplicatesFromSortedList, new()
{
    [TestMethod]
    [DataRow(new[] { 0, 0, 0, 0, 0 }, new[] { 0 })]
    [DataRow(new[] { 1, 1, 2 }, new[] { 1, 2 })]
    [DataRow(new[] { 1, 1, 2, 3, 3 }, new[] { 1, 2, 3 })]
    public void DeleteDuplicates_GivenLinkedList_RemovesDuplicatesAndReturnsExpectedList(int[] headArray,
        int[] expectedResultArray)
    {
        // Arrange
        var solution = new T();

        var head = ListNode.ToListNode(headArray);
        var expectedResult = ListNode.ToListNode(expectedResultArray);

        // Act
        var actualResult = solution.DeleteDuplicates(head);

        // Assert
        ListNodeAssert.AreEqual(expectedResult, actualResult);
    }
}