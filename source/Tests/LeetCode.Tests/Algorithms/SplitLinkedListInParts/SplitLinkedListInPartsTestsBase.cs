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

using LeetCode.Algorithms.SplitLinkedListInParts;
using LeetCode.Core.Helpers;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.SplitLinkedListInParts;

public abstract class SplitLinkedListInPartsTestsBase<T> where T : ISplitLinkedListInParts, new()
{
    [TestMethod]
    [DataRow(new int[] { }, 5, "[[],[],[],[],[]]")]
    [DataRow(new[] { 1, 2, 3 }, 5, "[[1],[2],[3],[],[]]")]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 3, "[[1,2,3,4],[5,6,7],[8,9,10]]")]
    public void SplitListToParts_WithHeadArrayAndK_ReturnsListOfParts(int[] headArray, int k,
        string expectedResultJsonArray)
    {
        // Arrange
        var head = ListNode.ToListNode(headArray);

        var expectedResultJaggedArray = JsonHelper<int>.DeserializeToJaggedArray(expectedResultJsonArray);

        var expectedResult = new ListNode?[k];

        for (var i = 0; i < expectedResultJaggedArray.Length; i++)
        {
            expectedResult[i] = ListNode.ToListNode(expectedResultJaggedArray[i]);
        }

        var solution = new T();

        // Act
        var actualResult = solution.SplitListToParts(head, k);

        // Assert
        ListNodeAssert.AreEqual(expectedResult, actualResult);
    }
}