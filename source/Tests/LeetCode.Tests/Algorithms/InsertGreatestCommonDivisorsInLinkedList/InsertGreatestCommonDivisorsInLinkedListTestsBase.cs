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

using LeetCode.Algorithms.InsertGreatestCommonDivisorsInLinkedList;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.InsertGreatestCommonDivisorsInLinkedList;

public abstract class InsertGreatestCommonDivisorsInLinkedListTestsBase<T> where T : IInsertGreatestCommonDivisorsInLinkedList, new()
{
    [TestMethod]
    [DataRow(new[] { 7 }, new[] { 7 })]
    [DataRow(new[] { 18, 6, 10, 3 }, new[] { 18, 6, 6, 2, 10, 1, 3 })]
    [DataRow(new[] { 1, 1 }, new[] { 1, 1, 1 })]
    [DataRow(new[] { 2, 4 }, new[] { 2, 2, 4 })]
    [DataRow(new[] { 4, 2 }, new[] { 4, 2, 2 })]
    [DataRow(new[] { 5, 7 }, new[] { 5, 1, 7 })]
    [DataRow(new[] { 12, 18, 24 }, new[] { 12, 6, 18, 6, 24 })]
    [DataRow(new[] { 100, 75, 50, 25 }, new[] { 100, 25, 75, 25, 50, 25, 25 })]
    [DataRow(new[] { 1000, 1000, 1000 }, new[] { 1000, 1000, 1000, 1000, 1000 })]
    [DataRow(new[] { 17, 13, 11, 7 }, new[] { 17, 1, 13, 1, 11, 1, 7 })]
    [DataRow(new[] { 6, 10, 15 }, new[] { 6, 2, 10, 5, 15 })]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new[] { 1, 1, 2, 1, 3, 1, 4, 1, 5, 1, 6, 1, 7, 1, 8 })]
    [DataRow(new[] { 8, 4, 2, 1 }, new[] { 8, 4, 4, 2, 2, 1, 1 })]
    [DataRow(new[] { 999, 333, 111 }, new[] { 999, 333, 333, 111, 111 })]
    [DataRow(new[] { 30, 42, 70 }, new[] { 30, 6, 42, 14, 70 })]
    [DataRow(new[] { 9, 6, 3 }, new[] { 9, 3, 6, 3, 3 })]
    [DataRow(new[] { 1000, 1 }, new[] { 1000, 1, 1 })]
    [DataRow(new[] { 1, 1000 }, new[] { 1, 1, 1000 })]
    [DataRow(new[] { 2, 3, 5, 7, 11, 13 }, new[] { 2, 1, 3, 1, 5, 1, 7, 1, 11, 1, 13 })]
    [DataRow(new[] { 36, 24, 60, 90, 45 }, new[] { 36, 12, 24, 12, 60, 30, 90, 45, 45 })]
    [DataRow(new[] { 332, 521, 635, 818, 9, 272, 159, 842, 775, 205, 270, 89 }, new[] { 332, 1, 521, 1, 635, 1, 818, 1, 9, 1, 272, 1, 159, 1, 842, 1, 775, 5, 205, 5, 270, 1, 89 })]
    public void InsertGreatestCommonDivisors_GivenLinkedList_ReturnsListWithGCDInserted(int[] headArray, int[] expectedResultArray)
    {
        // Arrange
        var head = ListNode.ToListNodeOrThrow(headArray);
        var expectedResult = ListNode.ToListNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.InsertGreatestCommonDivisors(head);

        // Assert
        ListNodeAssert.AreEqual(expectedResult, actualResult);
    }
}