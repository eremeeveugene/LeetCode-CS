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

using LeetCode.Algorithms.RemoveLinkedListElements;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.RemoveLinkedListElements;

public abstract class RemoveLinkedListElementsTestsBase<T> where T : IRemoveLinkedListElements, new()
{
    [TestMethod]
    [DataRow("[]", 1, "[]")]
    [DataRow("[1]", 1, "[]")]
    [DataRow("[1]", 0, "[1]")]
    [DataRow("[1,2,6,3,4,5,6]", 6, "[1,2,3,4,5]")]
    [DataRow("[7,7,7,7]", 7, "[]")]
    public void RemoveElements_WithListAndTargetValue_ReturnsListWithoutTargetValue(string headJsonArray, int val,
        string expectedResultJsonArray)
    {
        // Arrange
        var headArray = JsonHelper<int>.DeserializeToArray(headJsonArray);
        var head = ListNode.ToListNode(headArray);
        var expectedResultArray = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);
        var expectedResult = ListNode.ToListNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.RemoveElements(head, val);

        // Assert
        ListNodeAssert.AreEqual(expectedResult, actualResult);
    }
}