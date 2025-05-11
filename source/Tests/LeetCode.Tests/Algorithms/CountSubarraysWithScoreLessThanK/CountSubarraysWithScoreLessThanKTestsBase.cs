// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.CountSubarraysWithScoreLessThanK;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.CountSubarraysWithScoreLessThanK;

public abstract class CountSubarraysWithScoreLessThanKTestsBase<T> where T : ICountSubarraysWithScoreLessThanK, new()
{
    [TestMethod]
    [DataRow("[2,1,4,3,5]", 10, 6)]
    [DataRow("[1,1,1]", 5, 5)]
    public void CountSubarrays_WithPositiveIntArrayAndScoreThreshold_ReturnsNumberOfSubarraysWithScoreLessThanK(
        string numsJson, long k, long expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.CountSubarrays(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}