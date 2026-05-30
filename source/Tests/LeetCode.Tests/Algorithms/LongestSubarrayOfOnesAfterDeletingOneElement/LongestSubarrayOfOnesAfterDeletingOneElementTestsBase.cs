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

using LeetCode.Algorithms.LongestSubarrayOfOnesAfterDeletingOneElement;

namespace LeetCode.Tests.Algorithms.LongestSubarrayOfOnesAfterDeletingOneElement;

public abstract class LongestSubarrayOfOnesAfterDeletingOneElementTestsBase<T>
    where T : ILongestSubarrayOf1AfterDeletingOneElement, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 1, 0, 1 }, 3)]
    [DataRow(new[] { 0, 1, 1, 1, 0, 1, 1, 0, 1 }, 5)]
    [DataRow(new[] { 1, 1, 1 }, 2)]
    public void LongestSubarray_WithNumsBinaryArray_ReturnsLengthOfLongestSubarrayOfOnes(
        int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LongestSubarray(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}