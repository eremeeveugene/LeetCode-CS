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

using LeetCode.Algorithms.MinimizeTheMaximumDifferenceOfPairs;

namespace LeetCode.Tests.Algorithms.MinimizeTheMaximumDifferenceOfPairs;

public abstract class MinimizeTheMaximumDifferenceOfPairsTestsBase<T> where T : IMinimizeTheMaximumDifferenceOfPairs, new()
{
    [TestMethod]
    [DataRow(new[] { 10, 1, 2, 7, 1, 3 }, 2, 1)]
    [DataRow(new[] { 4, 2, 1, 2 }, 1, 0)]
    [DataRow(new[] { 1, 2 }, 1, 1)]
    [DataRow(new[] { 1, 1 }, 1, 0)]
    [DataRow(new[] { 0, 0 }, 1, 0)]
    [DataRow(new[] { 1, 3, 5, 7 }, 2, 2)]
    [DataRow(new[] { 1, 2, 3, 4 }, 2, 1)]
    [DataRow(new[] { 1, 2, 3, 4 }, 1, 1)]
    [DataRow(new[] { 5, 5, 5, 5 }, 2, 0)]
    [DataRow(new[] { 0, 5, 3, 7 }, 2, 3)]
    [DataRow(new[] { 1, 100 }, 0, 0)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, 3, 1)]
    [DataRow(new[] { 10, 20, 30, 40 }, 2, 10)]
    [DataRow(new[] { 1, 1, 1, 1 }, 2, 0)]
    [DataRow(new[] { 1, 5, 9, 13 }, 2, 4)]
    [DataRow(new[] { 3, 3 }, 1, 0)]
    [DataRow(new[] { 2, 4, 6, 8 }, 1, 2)]
    [DataRow(new[] { 1, 2, 4, 8 }, 1, 1)]
    public void MinimizeMax_WithNumsAndPairCount_ReturnsMinimumPossibleMaximumDifferenceAmongPairs(
        int[] nums,
        int requiredPairsCount,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimizeMax(nums, requiredPairsCount);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}