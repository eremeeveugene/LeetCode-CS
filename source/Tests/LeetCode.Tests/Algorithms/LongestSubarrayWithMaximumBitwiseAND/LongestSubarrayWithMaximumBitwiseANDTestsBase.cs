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

using LeetCode.Algorithms.LongestSubarrayWithMaximumBitwiseAND;

namespace LeetCode.Tests.Algorithms.LongestSubarrayWithMaximumBitwiseAND;

public abstract class LongestSubarrayWithMaximumBitwiseANDTestsBase<T> where T : ILongestSubarrayWithMaximumBitwiseAND, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4 }, 1)]
    [DataRow(new[] { 1, 2, 3, 3, 2, 2 }, 2)]
    [DataRow(new[] { 311155, 311155, 311155, 311155, 311155, 311155, 311155, 311155, 201191, 311155 }, 8)]
    [DataRow(new[] { 378034, 378034, 378034 }, 3)]
    [DataRow(new[] { 1 }, 1)]
    [DataRow(new[] { 5, 5 }, 2)]
    [DataRow(new[] { 1, 2 }, 1)]
    [DataRow(new[] { 2, 1 }, 1)]
    [DataRow(new[] { 7, 7, 7, 7 }, 4)]
    [DataRow(new[] { 1, 1, 2, 2, 2 }, 3)]
    [DataRow(new[] { 3, 3, 1, 3, 3, 3 }, 3)]
    [DataRow(new[] { 6, 2, 6, 6, 2 }, 2)]
    [DataRow(new[] { 1000000, 1, 1000000, 1000000 }, 2)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 1)]
    [DataRow(new[] { 8, 7, 6, 5, 4, 3, 2, 1 }, 1)]
    [DataRow(new[] { 4, 4, 4, 3, 3, 3, 3 }, 3)]
    [DataRow(new[] { 9, 1, 9, 9, 1, 9, 9, 9 }, 3)]
    [DataRow(new[] { 2, 3, 2, 3, 3, 3, 2 }, 3)]
    [DataRow(new[] { 1073741823, 1073741823, 1, 1073741823 }, 2)]
    [DataRow(new[] { 7, 7, 3, 7 }, 2)]
    [DataRow(new[] { 3, 1, 6, 4, 4, 2, 1, 1, 1 }, 1)]
    [DataRow(new[] { 5, 3, 1, 2, 5, 5, 3, 3, 2, 1, 3, 2 }, 2)]
    [DataRow(new[] { 6, 3, 3, 2, 2, 3 }, 1)]
    [DataRow(new[] { 6, 6, 3, 1, 5, 3, 6, 4, 5, 2 }, 2)]
    [DataRow(new[] { 2, 4, 3, 1, 5, 3, 1, 3 }, 1)]
    [DataRow(new[] { 5, 2, 4, 4, 5, 3, 4, 4, 2, 2 }, 1)]
    public void LongestSubarray_GivenArrayOfIntegers_ReturnsLengthOfLongestSubarray(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LongestSubarray(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}