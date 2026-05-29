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

using LeetCode.Algorithms.CountTheNumberOfFairPairs;

namespace LeetCode.Tests.Algorithms.CountTheNumberOfFairPairs;

public abstract class CountTheNumberOfFairPairsTestsBase<T> where T : ICountTheNumberOfFairPairs, new()
{
    [TestMethod]
    [DataRow(new[] { 0, 1, 7, 4, 4, 5 }, 3, 6, 6L)]
    [DataRow(new[] { 1, 7, 9, 2, 5 }, 11, 11, 1L)]
    public void CountFairPairs_WithArrayAndBounds_ReturnsTheNumberOfFairPairs(int[] nums, int lower,
        int upper, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountFairPairs(nums, lower, upper);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}