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

using LeetCode.Algorithms.FindMinimumInRotatedSortedArray;

namespace LeetCode.Tests.Algorithms.FindMinimumInRotatedSortedArray;

public abstract class FindMinimumInRotatedSortedArrayTestsBase<T> where T : IFindMinimumInRotatedSortedArray, new()
{
    [TestMethod]
    [DataRow(new[] { 1 }, 1)]
    [DataRow(new[] { 1, 2 }, 1)]
    [DataRow(new[] { 2, 1 }, 1)]
    [DataRow(new[] { 3, 4, 5, 1, 2 }, 1)]
    [DataRow(new[] { 4, 5, 6, 7, 0, 1 }, 0)]
    [DataRow(new[] { 11, 13, 15, 17 }, 11)]
    [DataRow(new[] { 5, 1, 2, 3, 4 }, 1)]
    [DataRow(new[] { 2, 3, 4, 5, 1 }, 1)]
    [DataRow(new[] { 30, 40, 50, 10, 20 }, 10)]
    [DataRow(new[] { 4, 5, 6, 1, 2, 3 }, 1)]
    [DataRow(new[] { 6, 1, 2, 3, 4, 5 }, 1)]
    [DataRow(new[] { 2, 3, 4, 5, 6, 1 }, 1)]
    [DataRow(new[] { -4, -3, -2, -1 }, -4)]
    [DataRow(new[] { -1, 0, 1, -5, -4, -3, -2 }, -5)]
    [DataRow(new[] { 0, 1, 2, 3, 4, 5 }, 0)]
    [DataRow(new[] { 3, 4, 5, 6, -2, -1, 0, 1, 2 }, -2)]
    [DataRow(new[] { 4998, 4999, 5000, -5000, -4999 }, -5000)]
    [DataRow(new[] { -4999, 0, 4999, 5000, -5000 }, -5000)]
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