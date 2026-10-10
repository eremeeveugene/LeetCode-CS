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

using LeetCode.Algorithms.NumberOfWaysToSplitArray;

namespace LeetCode.Tests.Algorithms.NumberOfWaysToSplitArray;

public abstract class NumberOfWaysToSplitArrayTestsBase<T> where T : INumberOfWaysToSplitArray, new()
{
    [TestMethod]
    [DataRow(new[] { 10, 4, -8, 7 }, 2)]
    [DataRow(new[] { 2, 3, 1, 0 }, 2)]
    [DataRow(new[] { 0, 0 }, 1)]
    [DataRow(new[] { 1, 1 }, 1)]
    [DataRow(new[] { -1, 1 }, 0)]
    [DataRow(new[] { 1, -1 }, 1)]
    [DataRow(new[] { 100000, 100000 }, 1)]
    [DataRow(new[] { -100000, -100000 }, 1)]
    [DataRow(new[] { 100000, -100000, 100000 }, 1)]
    [DataRow(new[] { 5, 5, 5 }, 1)]
    [DataRow(new[] { -1, -2, -3 }, 2)]
    [DataRow(new[] { 0, 0, 0, 0 }, 3)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 1)]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, 3)]
    [DataRow(new[] { -5, 10, -5, 10 }, 1)]
    [DataRow(new[] { 100000, 100000, 100000, 100000, 100000, -100000, -100000, -100000, -100000, -100000 }, 9)]
    [DataRow(new[] { -18, 16, 5, -9, 2, -7, -16, -1, -10, 0 }, 6)]
    [DataRow(new[] { -13, -12, 6, 2, 6, 18, -13, 11, -15, 12, -18, -8, 8, 2, 16, 8, -4, 14, -5, 5 }, 3)]
    [DataRow(new[] { 8, 20, -9, 5, -3, -2, 2, -5, 12, 9, -18, 2, -20, 1, 12, -18 }, 15)]
    [DataRow(new[] { -16, -2, 0, 11, -3, -12 }, 2)]
    [DataRow(new[] { -9, -13, -5, 14, 11, -5, 5, 19, 17, 6, -15, -7, -8, -14, 7, 5, 0, -12 }, 11)]
    [DataRow(new[] { 2, 8, -2, 18, 4, -9, 12, -3, -3, -11, -4, 14, 9, -7 }, 9)]
    public void WaysToSplitArray_WithIntegerArray_ReturnsNumberOfValidSplits(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.WaysToSplitArray(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}