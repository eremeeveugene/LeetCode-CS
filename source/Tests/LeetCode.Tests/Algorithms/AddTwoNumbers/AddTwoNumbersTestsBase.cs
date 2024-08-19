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

using LeetCode.Algorithms.AddTwoNumbers;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.AddTwoNumbers;

public abstract class AddTwoNumbersTestsBase<T> where T : IAddTwoNumbers, new()
{
    [TestMethod]
    [DataRow("[2, 4, 3]", "[5, 6, 4]", "[7, 0, 8]")]
    [DataRow("[0]", "[0]", "[0]")]
    [DataRow("[9, 9, 9, 9, 9, 9, 9]", "[9, 9, 9, 9]", "[8, 9, 9, 9, 0, 0, 0, 1]")]
    [DataRow("[9]", "[1, 9, 9, 9, 9, 9, 9, 9, 9, 9]", "[0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1]")]
    public void AddTwoNumbers_WithTwoIntegerArrays_ReturnsSumAsLinkedList(string array1JsonArray,
        string array2JsonArray, string expectedResultJsonArray)
    {
        // Arrange
        var array1 = JsonHelper<int>.DeserializeToArray(array1JsonArray);
        var list1 = ListNode.ToListNode(array1);

        var array2 = JsonHelper<int>.DeserializeToArray(array2JsonArray);
        var list2 = ListNode.ToListNode(array2);

        var expectedResultArray = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);
        var expectedResult = ListNode.ToListNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.AddTwoNumbers(list1, list2);

        // Assert
        ListNodeAssert.AreEqual(expectedResult, actualResult);
    }
}