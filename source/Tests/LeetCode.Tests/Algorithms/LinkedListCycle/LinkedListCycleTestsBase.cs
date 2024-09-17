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

using LeetCode.Algorithms.LinkedListCycle;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.LinkedListCycle;

public abstract class LinkedListCycleTestsBase<T> where T : ILinkedListCycle, new()
{
    [TestMethod]
    [DataRow("[]", -1, false)]
    [DataRow("[3,2,0,-4]", 1, true)]
    [DataRow("[1,2]", 0, true)]
    [DataRow("[1]", -1, false)]
    [DataRow("[1,2,3,4,5]", -1, false)]
    [DataRow("[1,2,3,4,5]", 4, true)]
    [DataRow("[1,1,1,1,1]", 0, true)]
    [DataRow("[1,2,3,4,5,6,7,8,9]", 2, true)]
    [DataRow("[1,2,3,4,5,6,7,8,9,10]", 0, true)]
    public void HasCycle_GivenLinkedList_ReturnsCorrectCycleDetectionOutcome(string headJsonArray, int pos,
        bool expectedResult)
    {
        // Arrange
        var headArray = JsonHelper<int>.DeserializeToArray(headJsonArray);
        var head = ListNode.ToCycledListNode(headArray, pos);

        var solution = new T();

        // Act
        var actualResult = solution.HasCycle(head);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}