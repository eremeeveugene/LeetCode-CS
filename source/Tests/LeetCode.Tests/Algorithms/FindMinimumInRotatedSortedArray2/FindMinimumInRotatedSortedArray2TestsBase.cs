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

using LeetCode.Algorithms.FindMinimumInRotatedSortedArray2;

namespace LeetCode.Tests.Algorithms.FindMinimumInRotatedSortedArray2;

public abstract class FindMinimumInRotatedSortedArray2TestsBase<T> where T : IFindMinimumInRotatedSortedArray2, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 1 }, 1)]
    [DataRow(new[] { 1, 1, 1 }, 1)]
    [DataRow(new[] { 1, 1, 2 }, 1)]
    [DataRow(new[] { 2, 1, 1 }, 1)]
    [DataRow(new[] { 1, 2, 1 }, 1)]
    [DataRow(new[] { 2, 2, 2, 0, 1 }, 0)]
    [DataRow(new[] { 2, 2, 2, 2, 0, 1, 2 }, 0)]
    [DataRow(new[] { 2, 0, 1, 2, 2, 2, 2 }, 0)]
    [DataRow(new[] { 2, 2, 0, 1, 2, 2, 2 }, 0)]
    [DataRow(new[] { 10, 10, 10, 1, 10 }, 1)]
    [DataRow(new[] { 10, 1, 10, 10, 10 }, 1)]
    [DataRow(new[] { 10, 10, 10, 10, 1 }, 1)]
    [DataRow(new[] { 1, 10, 10, 10, 10 }, 1)]
    [DataRow(new[] { 3, 3, 1, 3 }, 1)]
    [DataRow(new[] { 3, 1, 3, 3, 3 }, 1)]
    [DataRow(new[] { 3, 3, 3, 1, 3 }, 1)]
    [DataRow(new[] { 1, 3, 3, 3, 3 }, 1)]
    [DataRow(new[] { 3, 3, 3, 3, 1 }, 1)]
    [DataRow(new[] { 1, 1, 1, 0, 1 }, 0)]
    [DataRow(new[] { 1, 0, 1, 1, 1 }, 0)]
    [DataRow(new[] { 1, 1, 0, 1, 1 }, 0)]
    [DataRow(new[] { 0, 1, 1, 1, 1 }, 0)]
    [DataRow(new[] { 1, 1, 1, 1, 0 }, 0)]
    [DataRow(new[] { -1, -1, -1, -5, -5, -4, -3, -2 }, -5)]
    [DataRow(new[] { -5, -5, -4, -3, -2, -1, -1, -1 }, -5)]
    [DataRow(new[] { -3, -2, -1, -1, -5, -5, -4 }, -5)]
    [DataRow(new[] { -1, -5, -5, -4, -3, -2, -1 }, -5)]
    [DataRow(new[] { 0, 0, 0, 0, 0 }, 0)]
    [DataRow(new[] { -5000 }, -5000)]
    [DataRow(new[] { 5000 }, 5000)]
    [DataRow(new[] { 5000, -5000 }, -5000)]
    [DataRow(new[] { -5000, 5000 }, -5000)]
    [DataRow(new[] { 5000, 5000, -5000, -5000, 0, 5000 }, -5000)]
    [DataRow(new[] { 0, 5000, 5000, 5000, -5000, -5000 }, -5000)]
    [DataRow(new[] { -5000, -5000, 0, 5000, 5000, 5000 }, -5000)]
    [DataRow(new[] { 2, 2, 2, 2, 2, 2, 2, 1, 2 }, 1)]
    [DataRow(new[] { 2, 1, 2, 2, 2, 2, 2, 2, 2 }, 1)]
    [DataRow(new[] { 2, 2, 2, 2, 1, 2, 2, 2, 2 }, 1)]
    [DataRow(new[] { 1, 2, 2, 2, 2, 2, 2, 2, 2 }, 1)]
    [DataRow(new[] { 2, 2, 2, 2, 2, 2, 2, 2, 1 }, 1)]
    [DataRow(new[] { 4, 4, 5, 6, 7, 0, 1, 4, 4 }, 0)]
    [DataRow(new[] { 4, 4, 4, 5, 6, 7, 0, 1, 4 }, 0)]
    [DataRow(new[] { 0, 1, 4, 4, 4, 5, 6, 7, 7 }, 0)]
    public void FindMin_WithRotatedSortedArray_ReturnsMinimumElement(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindMin(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}