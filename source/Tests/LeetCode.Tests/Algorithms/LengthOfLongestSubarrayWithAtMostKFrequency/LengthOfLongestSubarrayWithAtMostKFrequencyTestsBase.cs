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