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

using LeetCode.Algorithms.RotateList;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.RotateList;

public abstract class RotateListTestsBase<T> where T : IRotateList, new()
{
    [TestMethod]
    [DataRow(new int[] { }, 0, new int[] { })]
    [DataRow(new int[] { }, 1, new int[] { })]
    [DataRow(new[] { 1 }, 0, new[] { 1 })]
    [DataRow(new[] { 1 }, 1, new[] { 1 })]
    [DataRow(new[] { 1 }, 2_000_000_000, new[] { 1 })]
    [DataRow(new[] { 1, 2 }, 0, new[] { 1, 2 })]
    [DataRow(new[] { 1, 2 }, 1, new[] { 2, 1 })]
    [DataRow(new[] { 1, 2 }, 2, new[] { 1, 2 })]
    [DataRow(new[] { 1, 2 }, 3, new[] { 2, 1 })]
    [DataRow(new[] { 0, 1, 2 }, 1, new[] { 2, 0, 1 })]
    [DataRow(new[] { 0, 1, 2 }, 2, new[] { 1, 2, 0 })]
    [DataRow(new[] { 0, 1, 2 }, 3, new[] { 0, 1, 2 })]
    [DataRow(new[] { 0, 1, 2 }, 4, new[] { 2, 0, 1 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 0, new[] { 1, 2, 3, 4, 5 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 1, new[] { 5, 1, 2, 3, 4 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 2, new[] { 4, 5, 1, 2, 3 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 5, new[] { 1, 2, 3, 4, 5 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 7, new[] { 4, 5, 1, 2, 3 })]
    [DataRow(new[] { -100, -1, 0, 1, 100 }, 3, new[] { 0, 1, 100, -100, -1 })]
    [DataRow(new[] { 1, 1, 2, 2, 3 }, 2, new[] { 2, 3, 1, 1, 2 })]
    public void RotateRight_WithGivenLinkedListAndRotationCount_ReturnsListRotatedRightBySpecifiedPlaces(int[] headArray, int k, int[] expectedResultArray)
    {
        // Arrange
        var head = ListNode.ToListNode(headArray);
        var expectedResult = ListNode.ToListNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.RotateRight(head, k);

        // Assert
        ListNodeAssert.AreEqual(expectedResult, actualResult);
    }
}