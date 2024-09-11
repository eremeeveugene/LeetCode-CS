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

using LeetCode.Algorithms.InsertGreatestCommonDivisorsInLinkedList;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.InsertGreatestCommonDivisorsInLinkedList;

public abstract class InsertGreatestCommonDivisorsInLinkedListTestsBase<T>
    where T : IInsertGreatestCommonDivisorsInLinkedList, new()
{
    [TestMethod]
    [DataRow(new[] { 7 }, new[] { 7 })]
    [DataRow(new[] { 18, 6, 10, 3 }, new[] { 18, 6, 6, 2, 10, 1, 3 })]
    public void InsertGreatestCommonDivisors_GivenLinkedList_ReturnsListWithGCDInserted(int[] headArray,
        int[] expectedResultArray)
    {
        // Arrange
        var head = ListNode.ToListNode(headArray) ?? throw new InvalidOperationException();
        var expectedResult = ListNode.ToListNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.InsertGreatestCommonDivisors(head);

        // Assert
        ListNodeAssert.AreEqual(expectedResult, actualResult);
    }
}