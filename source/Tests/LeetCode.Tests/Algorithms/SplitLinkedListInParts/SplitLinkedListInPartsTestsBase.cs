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

using LeetCode.Algorithms.SplitLinkedListInParts;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.SplitLinkedListInParts;

public abstract class SplitLinkedListInPartsTestsBase<T> where T : ISplitLinkedListInParts, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void SplitListToParts_WithLinkedListAndPartCount_ReturnsEquallyDividedParts(int[] headArray, int k, int[][] expectedResultNestedArray)
    {
        // Arrange
        var head = ListNode.ToListNode(headArray);

        var expectedResult = new ListNode?[k];

        for (var i = 0; i < expectedResultNestedArray.Length; i++)
        {
            expectedResult[i] = ListNode.ToListNode(expectedResultNestedArray[i]);
        }

        var solution = new T();

        // Act
        var actualResult = solution.SplitListToParts(head, k);

        // Assert
        ListNodeAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [Array.Empty<int>(), 5, new[] { Array.Empty<int>(), Array.Empty<int>(), Array.Empty<int>(), Array.Empty<int>(), Array.Empty<int>() }];

        yield return [new[] { 1, 2, 3 }, 5, new[] { new[] { 1 }, new[] { 2 }, new[] { 3 }, Array.Empty<int>(), Array.Empty<int>() }];

        yield return [new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 3, new[] { new[] { 1, 2, 3, 4 }, new[] { 5, 6, 7 }, new[] { 8, 9, 10 } }];
    }
}