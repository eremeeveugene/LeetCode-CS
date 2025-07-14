// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.ConvertBinaryNumberInLinkedListToInteger;
using LeetCode.Core.Exceptions;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;

namespace LeetCode.Tests.Algorithms.ConvertBinaryNumberInLinkedListToInteger;

public abstract class ConvertBinaryNumberInLinkedListToIntegerTestsBase<T>
    where T : IConvertBinaryNumberInLinkedListToInteger, new()
{
    [TestMethod]
    [DataRow("[0]", 0)]
    [DataRow("[1,0,1]", 5)]
    public void GetDecimalValue_WithBinaryLinkedList_ReturnsDecimalValue(string headJson, int expectedResult)
    {
        // Arrange
        var headArray = JsonHelper<int[]>.Parse(headJson);

        var head = ListNode.ToListNode(headArray) ?? throw new ListNodeBuildException();

        var solution = new T();

        // Act
        var actualResult = solution.GetDecimalValue(head);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}