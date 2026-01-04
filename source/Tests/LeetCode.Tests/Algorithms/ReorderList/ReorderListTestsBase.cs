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

using LeetCode.Algorithms.ReorderList;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.ReorderList;

public abstract class ReorderListTestsBase<T> where T : IReorderList, new()
{
    [TestMethod]
    [DataRow("[1,2,3,4]", "[1,4,2,3]")]
    [DataRow("[1,2,3,4,5]", "[1,5,2,4,3]")]
    public void ReorderList_GivenHeadArray_ResultsInExpectedOrder(string headJson, string expectedResultJson)
    {
        // Arrange
        var headArray = JsonHelper<int[]>.Parse(headJson);
        var head = ListNode.ToListNode(headArray);
        var expectedResultArray = JsonHelper<int[]>.Parse(expectedResultJson);
        var expectedResult = ListNode.ToListNode(expectedResultArray);

        var solution = new T();

        // Act
        solution.ReorderList(head);

        // Assert
        ListNodeAssert.AreEqual(expectedResult, head);
    }
}