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

using LeetCode.Algorithms.MaximumSumOfDistinctSubarraysWithLengthK;

namespace LeetCode.Tests.Algorithms.MaximumSumOfDistinctSubarraysWithLengthK;

public abstract class MaximumSumOfDistinctSubarraysWithLengthKTestsBase<T> where T : IMaximumSumOfDistinctSubarraysWithLengthK, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 5, 4, 2, 9, 9, 9 }, 3, 15L)]
    [DataRow(new[] { 4, 4, 4 }, 3, 0L)]
    public void MaximumSubarraySum_WithArrayAndWindowSize_ReturnsMaximumSubarraySum(int[] nums, int k, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaximumSubarraySum(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}