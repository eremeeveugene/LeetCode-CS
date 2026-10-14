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

using LeetCode.Algorithms.MinimumPositiveSumSubarray;

namespace LeetCode.Tests.Algorithms.MinimumPositiveSumSubarray;

public abstract class MinimumPositiveSumSubarrayTestsBase<T> where T : IMinimumPositiveSumSubarray, new()
{
    [TestMethod]
    [DataRow(new[] { 3, -2, 1, 4 }, 2, 3, 1)]
    [DataRow(new[] { -2, 2, -3, 1 }, 2, 3, -1)]
    [DataRow(new[] { 1, 2, 3, 4 }, 2, 4, 3)]
    [DataRow(new[] { 1, 2 }, 1, 1, 1)]
    [DataRow(new[] { 1, 2 }, 2, 2, 3)]
    [DataRow(new[] { -1, -2 }, 1, 2, -1)]
    [DataRow(new[] { 0, 0, 0 }, 1, 3, -1)]
    [DataRow(new[] { 1000, 1000, 1000, 1000, 1000 }, 1, 5, 1000)]
    [DataRow(new[] { -1000, 1000 }, 1, 2, 1000)]
    [DataRow(new[] { -1000, 1000, -1000 }, 2, 3, -1)]
    [DataRow(new[] { 1, -1, 1, -1 }, 1, 4, 1)]
    [DataRow(new[] { 2, -1, 2, -1, 2 }, 2, 2, 1)]
    [DataRow(new[] { 3, -3, 3 }, 3, 3, 3)]
    [DataRow(new[] { -5, -5, 5, 5 }, 2, 4, 5)]
    [DataRow(new[] { 0, 1, 0 }, 1, 1, 1)]
    [DataRow(new[] { 4, -3, 4, -3 }, 2, 3, 1)]
    [DataRow(new[] { 3, -1, 1, -1, -5, 7, -2, -7, -10, -3 }, 7, 10, 2)]
    [DataRow(new[] { 6, 0, 10, 2, -6, 7 }, 1, 2, 1)]
    [DataRow(new[] { -6, 7, 7, -4, 0 }, 5, 5, 4)]
    [DataRow(new[] { -8, -1, 3, -8, 6, 5, 10, 9, -6, 3, 6, 0 }, 1, 7, 1)]
    [DataRow(new[] { 8, -9, 1, -9, 5, 1, 8 }, 7, 7, 5)]
    [DataRow(new[] { -3, -7, 7, -4, -3, 6, 1, -9 }, 5, 5, 7)]
    [DataRow(new[] { -4, 9, 7, 7, 7, -6 }, 3, 5, 8)]
    [DataRow(new[] { 0, -5, 0, -7, 8, 8, -2 }, 3, 3, 1)]
    [DataRow(new[] { 1, -10 }, 2, 2, -1)]
    [DataRow(new[] { -30, 296, -890, 492, -594, -366, -472, -847, 532, 464, 863, -7, -958, 271, 155, 75, 404, -717, -175, -7, 498, 948, 965, 208, 672, -199, -625, -600, -486, 967, -692, 385, -774, 858, -566, -898, 724, 993, 99, -376, 648, 822, 884, -354, 660, -353, -899, -670, 896, -142, -810, 415, 578, -362, 718, -487, 346, -174, -17, -847, 110, -826, 112, 303, -505, -540, 90, 961, -457, 179, -666, 641, -396, -900, 484, 818, -4, 200, -196, 688, -4, -545, 134, -165, 56, 283, -89, -842, 981, -60, 539, -553, -531, -11, -349, 678, -614, 986, -255, 225 }, 1, 100, 1)]
    [DataRow(new[] { -30, 296, -890, 492, -594, -366, -472, -847, 532, 464, 863, -7, -958, 271, 155, 75, 404, -717, -175, -7, 498, 948, 965, 208, 672, -199, -625, -600, -486, 967, -692, 385, -774, 858, -566, -898, 724, 993, 99, -376, 648, 822, 884, -354, 660, -353, -899, -670, 896, -142, -810, 415, 578, -362, 718, -487, 346, -174, -17, -847, 110, -826, 112, 303, -505, -540, 90, 961, -457, 179, -666, 641, -396, -900, 484, 818, -4, 200, -196, 688, -4, -545, 134, -165, 56, 283, -89, -842, 981, -60, 539, -553, -531, -11, -349, 678, -614, 986, -255, 225 }, 40, 60, 1)]
    public void MinimumSumSubarray_WithLengthInRangeAndPositiveSum_ReturnsMinimumSumOrMinusOne(int[] nums, int l, int r, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimumSumSubarray(nums, l, r);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}