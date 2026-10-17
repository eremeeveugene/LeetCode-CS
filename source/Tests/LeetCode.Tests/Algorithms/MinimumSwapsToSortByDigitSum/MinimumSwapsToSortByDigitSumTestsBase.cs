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

using LeetCode.Algorithms.MinimumSwapsToSortByDigitSum;

namespace LeetCode.Tests.Algorithms.MinimumSwapsToSortByDigitSum;

public abstract class MinimumSwapsToSortByDigitSumTestsBase<T> where T : IMinimumSwapsToSortByDigitSum, new()
{
    [TestMethod]
    [DataRow(new[] { 37, 100 }, 1)]
    [DataRow(new[] { 22, 14, 33, 7 }, 0)]
    [DataRow(new[] { 18, 43, 34, 16 }, 2)]
    [DataRow(new[] { 5 }, 0)]
    [DataRow(new[] { 1, 2 }, 0)]
    [DataRow(new[] { 2, 1 }, 1)]
    [DataRow(new[] { 10, 1 }, 1)]
    [DataRow(new[] { 1, 10 }, 0)]
    [DataRow(new[] { 3, 2, 1 }, 1)]
    [DataRow(new[] { 2, 3, 1 }, 2)]
    [DataRow(new[] { 4, 3, 2, 1 }, 2)]
    [DataRow(new[] { 2, 1, 4, 3 }, 2)]
    [DataRow(new[] { 19, 28, 37, 46 }, 0)]
    [DataRow(new[] { 46, 37, 28, 19 }, 2)]
    [DataRow(new[] { 100, 10, 1 }, 1)]
    [DataRow(new[] { 11, 2, 20, 101 }, 1)]
    [DataRow(new[] { 9, 18, 27, 36, 45 }, 0)]
    [DataRow(new[] { 99, 1, 50 }, 2)]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, 2)]
    [DataRow(new[] { 5, 1, 2, 3, 4 }, 4)]
    [DataRow(new[] { 123, 6, 51, 15, 33 }, 4)]
    [DataRow(new[] { 1000000000, 999999999 }, 0)]
    [DataRow(new[] { 999999999, 1000000000 }, 1)]
    [DataRow(new[] { 12, 21, 3, 30 }, 2)]
    [DataRow(new[] { 7, 16, 25, 34, 43, 52, 61, 70 }, 0)]
    public void MinSwaps_WithNums_ReturnsMinimumSwaps(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinSwaps(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}