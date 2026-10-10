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

using LeetCode.Algorithms.LongestStrictlyIncreasingOrStrictlyDecreasingSubarray;

namespace LeetCode.Tests.Algorithms.LongestStrictlyIncreasingOrStrictlyDecreasingSubarray;

public abstract class LongestStrictlyIncreasingOrStrictlyDecreasingSubarrayTestsBase<T>
    where T : ILongestStrictlyIncreasingOrStrictlyDecreasingSubarray, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 4, 3, 3, 2 }, 2)]
    [DataRow(new[] { 3, 3, 3, 3 }, 1)]
    [DataRow(new[] { 3, 2, 1 }, 3)]
    [DataRow(new[] { 1 }, 1)]
    [DataRow(new[] { 1, 2 }, 2)]
    [DataRow(new[] { 2, 1 }, 2)]
    [DataRow(new[] { 5, 5 }, 1)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 5)]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, 5)]
    [DataRow(new[] { 1, 3, 2, 4, 3, 5 }, 2)]
    [DataRow(new[] { 1, 2, 2, 3, 4 }, 3)]
    [DataRow(new[] { 3, 2, 1, 1, 2, 3, 4 }, 4)]
    [DataRow(new[] { 50, 1, 50, 1, 50 }, 2)]
    [DataRow(new[] { 1, 50 }, 2)]
    [DataRow(new[] { 50, 49, 48, 47, 46, 45, 44, 43, 42, 41, 40 }, 11)]
    [DataRow(new[] { 1, 2, 3, 3, 2, 1 }, 3)]
    [DataRow(new[] { 10, 20, 30, 20, 10, 20, 30, 40 }, 4)]
    [DataRow(new[] { 4, 4, 4, 5, 6, 7, 7, 3 }, 4)]
    [DataRow(new[] { 10, 6, 5, 3, 3, 1, 6, 9, 8, 10, 2, 6, 9, 10, 1 }, 4)]
    [DataRow(new[] { 3, 8, 7, 3, 3, 4, 1, 2, 3, 9, 10, 2, 7, 2 }, 5)]
    [DataRow(new[] { 4, 4, 7, 2, 5, 4, 7, 5, 6, 1, 4, 1 }, 2)]
    [DataRow(new[] { 1, 7, 8, 3, 1, 4, 7, 2, 10, 1, 2, 10, 4, 4 }, 3)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 }, 50)]
    [DataRow(new[] { 50, 49, 48, 47, 46, 45, 44, 43, 42, 41, 40, 39, 38, 37, 36, 35, 34, 33, 32, 31, 30, 29, 28, 27, 26, 25, 24, 23, 22, 21, 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }, 50)]
    [DataRow(new[] { 1, 50, 1, 50, 1, 50, 1, 50, 1, 50, 1, 50, 1, 50, 1, 50, 1, 50, 1, 50, 1, 50, 1, 50, 1, 50, 1, 50, 1, 50, 1, 50, 1, 50, 1, 50, 1, 50, 1, 50, 1, 50, 1, 50, 1, 50, 1, 50, 1, 50 }, 2)]
    public void LongestMonotonicSubarray_WithGivenNums_ReturnsLengthOfTheLongestMonotonicSubarray(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LongestMonotonicSubarray(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}