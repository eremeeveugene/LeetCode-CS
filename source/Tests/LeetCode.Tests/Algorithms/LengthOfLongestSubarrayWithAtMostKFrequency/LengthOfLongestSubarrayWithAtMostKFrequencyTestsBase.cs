// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.LengthOfLongestSubarrayWithAtMostKFrequency;

namespace LeetCode.Tests.Algorithms.LengthOfLongestSubarrayWithAtMostKFrequency;

public abstract class LengthOfLongestSubarrayWithAtMostKFrequencyTestsBase<T>
    where T : ILengthOfLongestSubarrayWithAtMostKFrequency, new()
{
    [TestMethod]
    [DataRow(new[] { 1 }, 1, 1)]
    [DataRow(new[] { 1, 11 }, 2, 2)]
    [DataRow(new[] { 2, 11 }, 1, 2)]
    [DataRow(new[] { 1, 1, 2 }, 2, 3)]
    [DataRow(new[] { 1, 2, 3, 1, 2, 3, 1, 2 }, 2, 6)]
    [DataRow(new[] { 1, 2, 1, 2, 1, 2, 1, 2 }, 1, 2)]
    [DataRow(new[] { 5, 5, 5, 5, 5, 5, 5 }, 4, 4)]
    [DataRow(new[] { 1, 1, 1, 1, 1 }, 1, 1)]
    [DataRow(new[] { 1, 1, 1, 1, 1 }, 3, 3)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 1, 5)]
    [DataRow(new[] { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 }, 3, 9)]
    [DataRow(new[] { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 }, 4, 10)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 2, 10)]
    [DataRow(new[] { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5 }, 1, 2)]
    [DataRow(new[] { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5 }, 2, 10)]
    public void MaxSubarrayLength_GivenArrayAndK_ReturnsMaxSubarrayLength(int[] nums, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxSubarrayLength(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}