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

using LeetCode.Algorithms.RangeSumOfSortedSubarraySums;

namespace LeetCode.Tests.Algorithms.RangeSumOfSortedSubarraySums;

public abstract class RangeSumOfSortedSubarraySumsTestsBase<T> where T : IRangeSumOfSortedSubarraySums, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4 }, 4, 1, 5, 13)]
    [DataRow(new[] { 1, 2, 3, 4 }, 4, 3, 4, 6)]
    [DataRow(new[] { 1, 2, 3, 4 }, 4, 1, 10, 50)]
    [DataRow(new[] { 1 }, 1, 1, 1, 1)]
    [DataRow(new[] { 5 }, 1, 1, 1, 5)]
    [DataRow(new[] { 100 }, 1, 1, 1, 100)]
    [DataRow(new[] { 1, 1 }, 2, 1, 3, 4)]
    [DataRow(new[] { 1, 1 }, 2, 2, 2, 1)]
    [DataRow(new[] { 2, 1 }, 2, 1, 3, 6)]
    [DataRow(new[] { 3, 1, 2 }, 3, 1, 6, 19)]
    [DataRow(new[] { 3, 1, 2 }, 3, 2, 4, 8)]
    [DataRow(new[] { 3, 1, 2 }, 3, 6, 6, 6)]
    [DataRow(new[] { 100, 100, 100, 100, 100 }, 5, 1, 15, 3500)]
    [DataRow(new[] { 100, 1, 100, 1, 100 }, 5, 3, 9, 704)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, 6, 1, 21, 196)]
    [DataRow(new[] { 6, 5, 4, 3, 2, 1 }, 6, 10, 15, 58)]
    [DataRow(new[] { 7, 7, 7 }, 3, 2, 5, 42)]
    [DataRow(new[] { 10, 20, 30, 40 }, 4, 5, 5, 40)]
    [DataRow(new[] { 1, 100, 1, 100 }, 4, 1, 4, 202)]
    [DataRow(new[] { 4, 3, 2, 1 }, 4, 1, 10, 50)]
    public void RangeSum_WithSubarraySumRange_ReturnsSumOfSortedSubarraySumsBetweenIndices(int[] nums, int n, int left, int right, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RangeSum(nums, n, left, right);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void RangeSum_WithMaxLengthArray_ReturnsSumOfSortedSubarraySumsBetweenIndices()
    {
        // Arrange
        var solution = new T();

        var nums = new int[1000];

        for (var i = 0; i < nums.Length; i++)
        {
            nums[i] = 100;
        }

        // Act
        var actualResult = solution.RangeSum(nums, 1000, 1, 500500);

        // Assert
        Assert.AreEqual(716699888, actualResult);
    }

    [TestMethod]
    public void RangeSum_WithMaxLengthArrayAndTopRange_ReturnsSumOfLargestSubarraySums()
    {
        // Arrange
        var solution = new T();

        var nums = new int[1000];

        for (var i = 0; i < nums.Length; i++)
        {
            nums[i] = 100;
        }

        // Act
        var actualResult = solution.RangeSum(nums, 1000, 500491, 500500);

        // Assert
        Assert.AreEqual(998000, actualResult);
    }
}