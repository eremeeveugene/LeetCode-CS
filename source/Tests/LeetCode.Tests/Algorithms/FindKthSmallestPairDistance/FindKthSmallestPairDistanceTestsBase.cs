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

using LeetCode.Algorithms.FindKthSmallestPairDistance;

namespace LeetCode.Tests.Algorithms.FindKthSmallestPairDistance;

public abstract class FindKthSmallestPairDistanceTestsBase<T> where T : IFindKthSmallestPairDistance, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 3, 1 }, 1, 0)]
    [DataRow(new[] { 1, 1, 1 }, 2, 0)]
    [DataRow(new[] { 1, 6, 1 }, 3, 5)]
    [DataRow(new[] { 1, 2 }, 1, 1)]
    [DataRow(new[] { 5, 5 }, 1, 0)]
    [DataRow(new[] { 1, 1000000 }, 1, 999999)]
    [DataRow(new[] { 0, 0, 0, 0 }, 6, 0)]
    [DataRow(new[] { 1, 2, 3, 4 }, 1, 1)]
    [DataRow(new[] { 1, 2, 3, 4 }, 6, 3)]
    [DataRow(new[] { 9, 10, 7, 10, 6, 1, 5, 4, 9, 8 }, 18, 2)]
    [DataRow(new[] { 39, 44, 48 }, 3, 9)]
    [DataRow(new[] { 15, 17, 47, 16, 18, 46, 4, 42, 28, 19 }, 30, 25)]
    [DataRow(new[] { 25, 49, 7, 16, 14, 20, 22, 16 }, 12, 7)]
    [DataRow(new[] { 9, 10, 35, 42, 42, 17, 10, 0, 41, 4 }, 8, 5)]
    [DataRow(new[] { 1, 5, 17, 13, 24, 25, 37 }, 15, 20)]
    [DataRow(new[] { 41, 43, 7 }, 3, 36)]
    [DataRow(new[] { 11, 6, 47, 31, 32, 43, 12 }, 9, 16)]
    [DataRow(new[] { 39, 13, 31, 18, 32, 16, 6, 7, 5 }, 18, 13)]
    [DataRow(new[] { 7, 1, 10, 47, 26, 7 }, 11, 25)]
    [DataRow(new[] { 37, 5, 27, 30, 43, 10, 34, 24, 29, 19 }, 32, 19)]
    [DataRow(new[] { 27, 26, 38, 6, 16, 30, 25, 15, 28 }, 32, 22)]
    public void SmallestDistancePair_WithArrayAndK_ReturnsKthSmallestAbsolutePairDistance(int[] nums, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SmallestDistancePair(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}