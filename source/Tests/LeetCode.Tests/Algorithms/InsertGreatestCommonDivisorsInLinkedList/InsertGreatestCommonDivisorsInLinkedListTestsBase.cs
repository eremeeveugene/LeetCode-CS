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
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.InsertGreatestCommonDivisorsInLinkedList;

public abstract class InsertGreatestCommonDivisorsInLinkedListTestsBase<T>
    where T : IInsertGreatestCommonDivisorsInLinkedList, new()
{
    [TestMethod]
    [DataRow("[7]", "[7]")]
    [DataRow("[18,6,10,3]", "[18,6,6,2,10,1,3]")]
    public void InsertGreatestCommonDivisors_GivenLinkedList_ReturnsListWithGCDInserted(string headJsonArray,
        string expectedResultJsonArray)
    {
        // Arrange
        var headArray = JsonHelper<int>.DeserializeToArray(headJsonArray);
        var head = ListNode.ToListNode(headArray) ?? throw new InvalidOperationException();
        var expectedResultArray = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);
        var expectedResult = ListNode.ToListNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.InsertGreatestCommonDivisors(head);

        // Assert
        ListNodeAssert.AreEqual(expectedResult, actualResult);
    }
}