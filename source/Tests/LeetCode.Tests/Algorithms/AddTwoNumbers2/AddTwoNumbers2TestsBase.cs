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

using LeetCode.Algorithms.AddTwoNumbers2;
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
    public void AddTwoNumbers_WithTwoLinkedLists_ReturnsSumAsLinkedList(string l1Json, string l2Json,
        string expectedResultJson)
    {
        // Arrange
        var l1Array = JsonHelper.Parse<int[]>(l1Json);
        var l1 = ListNode.ToListNodeOrThrow(l1Array);

        var l2Array = JsonHelper.Parse<int[]>(l2Json);
        var l2 = ListNode.ToListNodeOrThrow(l2Array);

        var expectedResultArray = JsonHelper.Parse<int[]>(expectedResultJson);
        var expectedResult = ListNode.ToListNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.AddTwoNumbers(l1, l2);

        // Assert
        ListNodeAssert.AreEqual(expectedResult, actualResult);
    }
}