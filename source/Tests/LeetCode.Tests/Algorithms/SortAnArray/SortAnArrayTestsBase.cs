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

using LeetCode.Algorithms.SortAnArray;

namespace LeetCode.Tests.Algorithms.SortAnArray;

public abstract class SortAnArrayTestsBase<T> where T : ISortAnArray, new()
{
    [TestMethod]
    [DataRow(new[] { 5, 2, 3, 1 }, new[] { 1, 2, 3, 5 })]
    [DataRow(new[] { 5, 1, 1, 2, 0, 0 }, new[] { 0, 0, 1, 1, 2, 5 })]
    [DataRow(new[] { 1 }, new[] { 1 })]
    [DataRow(new[] { 2, 1 }, new[] { 1, 2 })]
    [DataRow(new[] { 1, 2 }, new[] { 1, 2 })]
    [DataRow(new[] { 3, 2, 1 }, new[] { 1, 2, 3 })]
    [DataRow(new[] { 1, 1, 1 }, new[] { 1, 1, 1 })]
    [DataRow(new[] { -1, -2, -3 }, new[] { -3, -2, -1 })]
    [DataRow(new[] { -3, 0, 3 }, new[] { -3, 0, 3 })]
    [DataRow(new[] { 0, 0, 0 }, new[] { 0, 0, 0 })]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, new[] { 1, 2, 3, 4, 5 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5 })]
    [DataRow(new[] { -5, 3, -2, 8, 0 }, new[] { -5, -2, 0, 3, 8 })]
    [DataRow(new[] { 100, -100, 0 }, new[] { -100, 0, 100 })]
    [DataRow(new[] { 2, 2, 1, 1, 3, 3 }, new[] { 1, 1, 2, 2, 3, 3 })]
    [DataRow(new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
    [DataRow(new[] { -1, 0, 1 }, new[] { -1, 0, 1 })]
    [DataRow(new[] { 3, 1, 2, 3, 1 }, new[] { 1, 1, 2, 3, 3 })]
    public void SortArray_WithUnsortedArray_ReturnsSortedArray(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        solution.SortArray(nums);

        // Assert
        CollectionAssert.AreEqual(expectedResult, nums);
    }
}