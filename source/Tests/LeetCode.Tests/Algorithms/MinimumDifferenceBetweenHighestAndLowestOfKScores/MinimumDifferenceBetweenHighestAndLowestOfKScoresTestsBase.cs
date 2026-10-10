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

using LeetCode.Algorithms.MinimumDifferenceBetweenHighestAndLowestOfKScores;

namespace LeetCode.Tests.Algorithms.MinimumDifferenceBetweenHighestAndLowestOfKScores;

public abstract class MinimumDifferenceBetweenHighestAndLowestOfKScoresTestsBase<T>
    where T : IMinimumDifferenceBetweenHighestAndLowestOfKScores, new()
{
    [TestMethod]
    [DataRow(new[] { 90 }, 1, 0)]
    [DataRow(new[] { 9, 4, 1, 7 }, 2, 2)]
    [DataRow(new[] { 9, 4, 1, 7 }, 3, 5)]
    [DataRow(new[] { 9, 4, 1, 7 }, 4, 8)]
    [DataRow(new[] { 0 }, 1, 0)]
    [DataRow(new[] { 100000 }, 1, 0)]
    [DataRow(new[] { 5, 5 }, 2, 0)]
    [DataRow(new[] { 5, 5, 5 }, 3, 0)]
    [DataRow(new[] { 1, 100000 }, 2, 99999)]
    [DataRow(new[] { 0, 100000, 50000 }, 2, 50000)]
    [DataRow(new[] { 0, 100000, 50000 }, 3, 100000)]
    [DataRow(new[] { 87063, 61094, 44530, 21297, 95857, 93551, 9918 }, 6, 74560)]
    [DataRow(new[] { 87063, 61094, 44530, 21297, 95857, 93551, 9918 }, 2, 2306)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 2, 1)]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, 3, 2)]
    [DataRow(new[] { 10, 10, 10, 1, 1, 1 }, 3, 0)]
    [DataRow(new[] { 10, 10, 10, 1, 1, 1 }, 4, 9)]
    [DataRow(new[] { 1, 3, 6, 10, 15, 21 }, 4, 9)]
    [DataRow(new[] { 100, 1, 50, 2, 51, 3 }, 3, 2)]
    [DataRow(new[] { 7, 7, 8, 8, 9, 9 }, 5, 2)]
    public void MinimumDifference_WithKSelectedScores_ReturnsMinimumScoreRange(int[] nums, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimumDifference(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}