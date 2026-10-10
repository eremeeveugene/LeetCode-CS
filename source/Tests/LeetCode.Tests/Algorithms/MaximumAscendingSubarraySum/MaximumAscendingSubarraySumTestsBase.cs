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

using LeetCode.Algorithms.MaximumAscendingSubarraySum;

namespace LeetCode.Tests.Algorithms.MaximumAscendingSubarraySum;

public abstract class MaximumAscendingSubarraySumTestsBase<T> where T : IMaximumAscendingSubarraySum, new()
{
    [TestMethod]
    [DataRow(new[] { 10, 20, 30, 5, 10, 50 }, 65)]
    [DataRow(new[] { 10, 20, 30, 40, 50 }, 150)]
    [DataRow(new[] { 12, 17, 15, 13, 10, 11, 12 }, 33)]
    [DataRow(new[] { 1 }, 1)]
    [DataRow(new[] { 100 }, 100)]
    [DataRow(new[] { 1, 1 }, 1)]
    [DataRow(new[] { 1, 2 }, 3)]
    [DataRow(new[] { 2, 1 }, 2)]
    [DataRow(new[] { 5, 5, 5, 5 }, 5)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 55)]
    [DataRow(new[] { 10, 9, 8, 7, 6 }, 10)]
    [DataRow(new[] { 1, 100, 1, 100 }, 101)]
    [DataRow(new[] { 3, 6, 10, 1, 8, 9, 9, 8, 9 }, 19)]
    [DataRow(new[] { 100, 100, 100 }, 100)]
    [DataRow(new[] { 1, 2, 3, 1, 2, 3, 1, 2, 3 }, 6)]
    [DataRow(new[] { 50, 60, 70, 10, 20, 30, 40 }, 180)]
    [DataRow(new[] { 1, 3, 2, 4, 3, 5, 4, 6 }, 10)]
    [DataRow(new[] { 20, 30, 10, 5, 100 }, 105)]
    [DataRow(new[] { 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8 }, 36)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100 }, 5050)]
    public void MaxAscendingSum_GivenIntegerArray_ReturnsMaxSumOfAscendingSubarray(int[] nums, double expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxAscendingSum(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}