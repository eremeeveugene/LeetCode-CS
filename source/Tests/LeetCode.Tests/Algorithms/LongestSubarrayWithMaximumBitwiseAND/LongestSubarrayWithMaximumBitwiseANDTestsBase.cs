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

using LeetCode.Algorithms.LongestSubarrayWithMaximumBitwiseAND;

namespace LeetCode.Tests.Algorithms.LongestSubarrayWithMaximumBitwiseAND;

public abstract class LongestSubarrayWithMaximumBitwiseANDTestsBase<T>
    where T : ILongestSubarrayWithMaximumBitwiseAND, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4 }, 1)]
    [DataRow(new[] { 1, 2, 3, 3, 2, 2 }, 2)]
    [DataRow(new[] { 311155, 311155, 311155, 311155, 311155, 311155, 311155, 311155, 201191, 311155 }, 8)]
    [DataRow(new[] { 378034, 378034, 378034 }, 3)]
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