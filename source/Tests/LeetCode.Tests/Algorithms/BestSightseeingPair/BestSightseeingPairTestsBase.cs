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

using LeetCode.Algorithms.BestSightseeingPair;

namespace LeetCode.Tests.Algorithms.BestSightseeingPair;

public abstract class BestSightseeingPairTestsBase<T> where T : IBestSightseeingPair, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2 }, 2)]
    [DataRow(new[] { 8, 1, 5, 2, 6 }, 11)]
    [DataRow(new[] { 1, 1 }, 1)]
    [DataRow(new[] { 5, 5 }, 9)]
    [DataRow(new[] { 1, 2, 3 }, 4)]
    [DataRow(new[] { 3, 2, 1 }, 4)]
    [DataRow(new[] { 10, 1, 1, 10 }, 17)]
    [DataRow(new[] { 1, 1, 1, 1, 1 }, 1)]
    [DataRow(new[] { 1000, 1000 }, 1999)]
    [DataRow(new[] { 1, 1000 }, 1000)]
    [DataRow(new[] { 1000, 1 }, 1000)]
    [DataRow(new[] { 2, 2, 2 }, 3)]
    [DataRow(new[] { 1, 3, 5, 7, 9 }, 15)]
    [DataRow(new[] { 9, 7, 5, 3, 1 }, 15)]
    [DataRow(new[] { 7, 8, 8, 10 }, 17)]
    [DataRow(new[] { 10, 10, 10, 10 }, 19)]
    [DataRow(new[] { 100, 1, 1, 1, 1, 100 }, 195)]
    [DataRow(new[] { 50, 60 }, 109)]
    [DataRow(new[] { 20, 1, 1, 1, 1, 1, 1, 1, 1, 1, 30 }, 40)]
    [DataRow(new[] { 4, 1, 2, 9, 3 }, 11)]
    [DataRow(new[] { 6, 4 }, 9)]
    [DataRow(new[] { 1, 2, 1, 2, 1, 2 }, 2)]
    public void MaxScoreSightseeingPair_WithValuesArray_ReturnsMaxScore(int[] values, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxScoreSightseeingPair(values);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}