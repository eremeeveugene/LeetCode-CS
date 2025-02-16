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

using LeetCode.Algorithms.AddTwoNumbers2;
using LeetCode.Core.Exceptions;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.AddTwoNumbers2;

public abstract class AddTwoNumbers2TestsBase<T> where T : IAddTwoNumbers2, new()
{
    [TestMethod]
    [DataRow("[0]", "[0]", "[0]")]
    [DataRow("[7,2,4,3]", "[5, 6, 4]", "[7,8,0,7]")]
    [DataRow("[2,4,3]", "[5, 6, 4]", "[8,0,7]")]
    public void AddTwoNumbers_WithTwoLinkedLists_ReturnsSumAsLinkedList(string l1JsonArray, string l2JsonArray,
        string expectedResultJsonArray)
    {
        // Arrange
        var l1Array = JsonHelper<int>.DeserializeToArray(l1JsonArray);
        var l1 = ListNode.ToListNode(l1Array) ?? throw new ListNodeBuildException();

        var l2Array = JsonHelper<int>.DeserializeToArray(l2JsonArray);
        var l2 = ListNode.ToListNode(l2Array) ?? throw new ListNodeBuildException();

        var expectedResultArray = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);
        var expectedResult = ListNode.ToListNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.AddTwoNumbers(l1, l2);

        // Assert
        ListNodeAssert.AreEqual(expectedResult, actualResult);
    }
}