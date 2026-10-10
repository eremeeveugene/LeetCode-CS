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

using LeetCode.Algorithms.CountOfInterestingSubarrays;

namespace LeetCode.Tests.Algorithms.CountOfInterestingSubarrays;

public abstract class CountOfInterestingSubarraysTestsBase<T> where T : ICountOfInterestingSubarrays, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 2, 4 }, 2, 1, 3L)]
    [DataRow(new[] { 3, 1, 9, 6 }, 3, 0, 2L)]
    [DataRow(new[] { 11, 12, 21, 31 }, 10, 1, 5L)]
    [DataRow(new[] { 1 }, 1, 0, 1L)]
    [DataRow(new[] { 1 }, 2, 1, 1L)]
    [DataRow(new[] { 2 }, 2, 0, 0L)]
    [DataRow(new[] { 1, 1 }, 2, 0, 3L)]
    [DataRow(new[] { 1, 2, 3, 4 }, 2, 1, 6L)]
    [DataRow(new[] { 5, 5, 5, 5 }, 5, 0, 0L)]
    [DataRow(new[] { 7, 7, 7 }, 7, 0, 0L)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, 3, 0, 6L)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, 3, 1, 12L)]
    [DataRow(new[] { 4, 4, 4, 4, 4 }, 4, 0, 2L)]
    [DataRow(new[] { 2, 4, 6, 8 }, 2, 0, 4L)]
    [DataRow(new[] { 1, 3, 5, 7 }, 2, 1, 6L)]
    [DataRow(new[] { 10, 20, 30 }, 1000000000, 10, 0L)]
    [DataRow(new[] { 1000000000, 1000000000 }, 1000000000, 0, 0L)]
    [DataRow(new[] { 1, 2, 1, 2, 1, 2 }, 2, 1, 12L)]
    [DataRow(new[] { 3, 3, 3, 3, 3, 3 }, 3, 0, 5L)]
    [DataRow(new[] { 6, 1, 6, 1, 6 }, 5, 1, 5L)]
    [DataRow(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 }, 4, 2, 8L)]
    public void CountInterestingSubarrays_WithModuloAndTargetRemainder_ReturnsMatchingSubarrayCount(
        int[] nums,
        int modulo,
        int k,
        long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountInterestingSubarrays(nums, modulo, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}