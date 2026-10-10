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

using LeetCode.Algorithms.RelativeRanks;

namespace LeetCode.Tests.Algorithms.RelativeRanks;

public abstract class RelativeRanksTestsBase<T> where T : IRelativeRanks, new()
{
    [TestMethod]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, new[] { "Gold Medal", "Silver Medal", "Bronze Medal", "4", "5" })]
    [DataRow(new[] { 10, 3, 8, 9, 4 }, new[] { "Gold Medal", "5", "Bronze Medal", "Silver Medal", "4" })]
    [DataRow(new[] { 1 }, new[] { "Gold Medal" })]
    [DataRow(new[] { 1000000 }, new[] { "Gold Medal" })]
    [DataRow(new[] { 0 }, new[] { "Gold Medal" })]
    [DataRow(new[] { 1, 2 }, new[] { "Silver Medal", "Gold Medal" })]
    [DataRow(new[] { 2, 1 }, new[] { "Gold Medal", "Silver Medal" })]
    [DataRow(new[] { 0, 1000000 }, new[] { "Silver Medal", "Gold Medal" })]
    [DataRow(new[] { 1, 2, 3 }, new[] { "Bronze Medal", "Silver Medal", "Gold Medal" })]
    [DataRow(new[] { 3, 2, 1 }, new[] { "Gold Medal", "Silver Medal", "Bronze Medal" })]
    [DataRow(new[] { 2, 3, 1 }, new[] { "Silver Medal", "Gold Medal", "Bronze Medal" })]
    [DataRow(new[] { 1, 3, 2 }, new[] { "Bronze Medal", "Gold Medal", "Silver Medal" })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, new[] { "5", "4", "Bronze Medal", "Silver Medal", "Gold Medal" })]
    [DataRow(new[] { 10, 3, 8, 9, 4, 7 }, new[] { "Gold Medal", "6", "Bronze Medal", "Silver Medal", "5", "4" })]
    [DataRow(new[] { 100, 200, 300, 400 }, new[] { "4", "Bronze Medal", "Silver Medal", "Gold Medal" })]
    [DataRow(new[] { 400, 300, 200, 100 }, new[] { "Gold Medal", "Silver Medal", "Bronze Medal", "4" })]
    [DataRow(new[] { 0, 5, 10, 15, 20, 25, 30 }, new[] { "7", "6", "5", "4", "Bronze Medal", "Silver Medal", "Gold Medal" })]
    [DataRow(new[] { 999999, 1000000, 0, 500000 }, new[] { "Silver Medal", "Gold Medal", "4", "Bronze Medal" })]
    [DataRow(new[] { 7, 1, 9, 3, 5, 2 }, new[] { "Silver Medal", "6", "Gold Medal", "4", "Bronze Medal", "5" })]
    [DataRow(new[] { 50, 40, 30, 20, 10, 60, 70, 80, 90, 100, 110, 120 }, new[] { "8", "9", "10", "11", "12", "7", "6", "5", "4", "Bronze Medal", "Silver Medal", "Gold Medal" })]
    [DataRow(new[] { 6, 5, 4, 3, 2, 1, 0 }, new[] { "Gold Medal", "Silver Medal", "Bronze Medal", "4", "5", "6", "7" })]
    public void FindRelativeRanks_GivenScores_ReturnsCorrespondingMedalsAndPositions(int[] score, string[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindRelativeRanks(score);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void FindRelativeRanks_WithMaxLengthScores_ReturnsCorrespondingMedalsAndPositions()
    {
        // Arrange
        var solution = new T();

        var score = new int[10000];
        var expectedResult = new string[10000];

        for (var i = 0; i < score.Length; i++)
        {
            score[i] = i;
            expectedResult[i] = (10000 - i).ToString();
        }

        expectedResult[9999] = "Gold Medal";
        expectedResult[9998] = "Silver Medal";
        expectedResult[9997] = "Bronze Medal";

        // Act
        var actualResult = solution.FindRelativeRanks(score);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}