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

using LeetCode.Algorithms.CountSubarraysWithFixedBounds;

namespace LeetCode.Tests.Algorithms.CountSubarraysWithFixedBounds;

public abstract class CountSubarraysWithFixedBoundsTestsBase<T> where T : ICountSubarraysWithFixedBounds, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 3, 5, 2, 7, 5 }, 1, 5, 2)]
    [DataRow(new[] { 1, 1, 1, 1 }, 1, 1, 10)]
    public void CountSubarrays_GivenRangeWithMinAndMaxValues_ReturnsExpectedCount(int[] nums, int minK, int maxK,
        long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountSubarrays(nums, minK, maxK);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}