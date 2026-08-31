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

using LeetCode.Algorithms.AdjacentIncreasingSubarraysDetection2;

namespace LeetCode.Tests.Algorithms.AdjacentIncreasingSubarraysDetection2;

public abstract class AdjacentIncreasingSubarraysDetection2TestsBase<T> where T : IAdjacentIncreasingSubarraysDetection2, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 5, 7, 8, 9, 2, 3, 4, 3, 1 }, 3)]
    [DataRow(new[] { 1, 2, 3, 4, 4, 4, 4, 5, 6, 7 }, 2)]
    [DataRow(new[] { 1, 2 }, 1)]
    [DataRow(new[] { 2, 1 }, 1)]
    [DataRow(new[] { 1, 2, 3, 4 }, 2)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 2)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, 3)]
    [DataRow(new[] { 6, 5, 4, 3, 2, 1 }, 1)]
    [DataRow(new[] { 1, 1, 1, 1 }, 1)]
    [DataRow(new[] { 1, 2, 1, 2 }, 2)]
    [DataRow(new[] { 1, 2, 3, 1, 2, 3 }, 3)]
    [DataRow(new[] { 1, 2, 3, 4, 1, 2 }, 2)]
    [DataRow(new[] { 1, 2, 1, 2, 3, 4 }, 2)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 1, 2 }, 2)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 1, 2, 3 }, 3)]
    [DataRow(new[] { 5, 4, 3, 2, 1, 0, -1 }, 1)]
    [DataRow(new[] { -3, -2, -1, 0, 1, 2 }, 3)]
    [DataRow(new[] { 1, 3, 2, 4, 3, 5, 4, 6 }, 2)]
    [DataRow(new[] { 1, 3, 5, 2, 4, 6, 8 }, 3)]
    [DataRow(new[] { 1, 3, 5, 7, 2, 4, 6 }, 3)]
    [DataRow(new[] { 1, 2, 3, 2, 3, 4, 1, 2, 3 }, 3)]
    [DataRow(new[] { 10, 20, 30, 40, 50, 60, 70, 80 }, 4)]
    [DataRow(new[] { -1_000_000_000, 0, 1_000_000_000, -999_999_999, 1, 999_999_999 }, 3)]
    [DataRow(new[] { 3, 1, 2, 3, 0, 1, 2, 3, 4 }, 3)]
    [DataRow(new[] { 1, 2, 3, 4, 0, -1, 0, 1, 2, 3 }, 2)]
    public void MaxIncreasingSubarrays_WithGivenNumbers_ReturnsMaximumAdjacentIncreasingSubarrayLength(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxIncreasingSubarrays(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}