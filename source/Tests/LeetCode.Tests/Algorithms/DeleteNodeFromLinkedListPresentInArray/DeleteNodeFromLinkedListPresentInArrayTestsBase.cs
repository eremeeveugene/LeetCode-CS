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

using LeetCode.Algorithms.DeleteNodeFromLinkedListPresentInArray;
using LeetCode.Core.Models;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.DeleteNodeFromLinkedListPresentInArray;

public abstract class DeleteNodeFromLinkedListPresentInArrayTestsBase<T> where T : IDeleteNodeFromLinkedListPresentInArray, new()
{
    [TestMethod]
    [DataRow(new int[] { }, new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5 })]
    [DataRow(new[] { 1, 2, 3 }, new[] { 1, 2, 3, 4, 5 }, new[] { 4, 5 })]
    [DataRow(new[] { 1 }, new[] { 1, 2, 1, 2, 1, 2 }, new[] { 2, 2, 2 })]
    [DataRow(new[] { 5 }, new[] { 1, 2, 3, 4 }, new[] { 1, 2, 3, 4 })]
    [DataRow(
        new[] { 312, 514, 872, 995, 1204, 1567, 2093, 3057, 4500, 4999, 5781, 6352, 7234, 8345, 9999 },
        new[]
        {
            234,
            312,
            405,
            514,
            672,
            872,
            995,
            1040,
            1204,
            1500,
            1567,
            2093,
            2500,
            3057,
            4000,
            4500,
            4999,
            5781,
            6000,
            6352,
            7000,
            7234,
            8000,
            8345,
            9000,
            9999
        },
        new[] { 234, 405, 672, 1040, 1500, 2500, 4000, 6000, 7000, 8000, 9000 })]
    [DataRow(new[] { 2 }, new[] { 1, 2, 3 }, new[] { 1, 3 })]
    [DataRow(new[] { 1, 2, 3 }, new[] { 1, 2, 3, 4 }, new[] { 4 })]
    [DataRow(new[] { 3, 1 }, new[] { 1, 2, 3 }, new[] { 2 })]
    [DataRow(new[] { 100000 }, new[] { 100000, 5 }, new[] { 5 })]
    [DataRow(new[] { 4, 5, 6 }, new[] { 7, 4, 8, 5, 9, 6 }, new[] { 7, 8, 9 })]
    [DataRow(new[] { 9 }, new[] { 1, 9, 9, 9, 2 }, new[] { 1, 2 })]
    [DataRow(new[] { 1, 2 }, new[] { 1, 1, 2, 2, 3 }, new[] { 3 })]
    [DataRow(new[] { 10, 20, 30 }, new[] { 10, 20, 30, 40 }, new[] { 40 })]
    [DataRow(new[] { 50 }, new[] { 10, 20, 30, 40, 50 }, new[] { 10, 20, 30, 40 })]
    [DataRow(new[] { 10 }, new[] { 10, 20, 30, 40, 50 }, new[] { 20, 30, 40, 50 })]
    [DataRow(new[] { 11, 10, 2, 1 }, new[] { 10, 9, 3, 6 }, new[] { 9, 3, 6 })]
    [DataRow(new[] { 7, 11, 3, 4 }, new[] { 5, 9, 4, 4, 12, 8, 9, 9 }, new[] { 5, 9, 12, 8, 9, 9 })]
    [DataRow(new[] { 11 }, new[] { 9, 7, 12 }, new[] { 9, 7, 12 })]
    [DataRow(new[] { 5 }, new[] { 3, 10 }, new[] { 3, 10 })]
    [DataRow(new[] { 10, 7, 11, 12 }, new[] { 5 }, new[] { 5 })]
    [DataRow(new[] { 11, 5, 7, 9 }, new[] { 8, 3, 6, 2, 1, 3, 8, 4, 5, 11 }, new[] { 8, 3, 6, 2, 1, 3, 8, 4 })]
    [DataRow(new[] { 11, 1, 5 }, new[] { 10, 6, 9, 10, 7, 10, 4 }, new[] { 10, 6, 9, 10, 7, 10, 4 })]
    [DataRow(new[] { 11, 10 }, new[] { 11, 12, 3, 12, 6, 9, 10, 10, 2, 12 }, new[] { 12, 3, 12, 6, 9, 2, 12 })]
    [DataRow(new[] { 2, 6, 12, 7 }, new[] { 5, 2, 2, 8, 11 }, new[] { 5, 8, 11 })]
    [DataRow(new[] { 2, 1, 10, 11 }, new[] { 1, 5, 7 }, new[] { 5, 7 })]
    public void ModifiedList_WithNumsAndHeadArray_ReturnsModifiedList(int[] nums, int[] headArray, int[] expectedResultArray)
    {
        // Arrange
        var head = ListNode.ToListNode(headArray);
        var expectedResult = ListNode.ToListNode(expectedResultArray);

        var solution = new T();

        // Act
        var actualResult = solution.ModifiedList(nums, head);

        // Assert
        ListNodeAssert.AreEqual(expectedResult, actualResult);
    }
}