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

using LeetCode.Algorithms.CountTheHiddenSequences;

namespace LeetCode.Tests.Algorithms.CountTheHiddenSequences;

public abstract class CountTheHiddenSequencesTestsBase<T> where T : ICountTheHiddenSequences, new()
{
    [TestMethod]
    [DataRow(new[] { 1, -3, 4 }, 1, 6, 2)]
    [DataRow(new[] { 3, -4, 5, 1, -2 }, -4, 5, 4)]
    [DataRow(new[] { 4, -7, 2 }, 3, 6, 0)]
    [DataRow(new[] { 1 }, 0, 1, 1)]
    [DataRow(new[] { 1 }, 0, 0, 0)]
    [DataRow(new[] { -1 }, 0, 0, 0)]
    [DataRow(new[] { 0 }, 5, 5, 1)]
    [DataRow(new[] { 0 }, -3, 3, 7)]
    [DataRow(new[] { 0, 0, 0 }, 1, 10, 10)]
    [DataRow(new[] { 1, 1, 1 }, 0, 3, 1)]
    [DataRow(new[] { 1, 1, 1 }, 0, 2, 0)]
    [DataRow(new[] { -2, -2 }, -5, 0, 2)]
    [DataRow(new[] { 5, -5 }, -5, 5, 6)]
    [DataRow(new[] { 100000, -100000 }, -100000, 100000, 100001)]
    [DataRow(new[] { 100000 }, -100000, 100000, 100001)]
    [DataRow(new[] { 1, -1, 1, -1 }, 3, 4, 1)]
    [DataRow(new[] { 2, -3, 4, -1 }, -10, 10, 17)]
    [DataRow(new[] { -40, 20, 30 }, -100, 100, 151)]
    [DataRow(new[] { 7 }, 1, 7, 0)]
    [DataRow(new[] { -7 }, 1, 7, 0)]
    public void NumberOfArrays_WithDifferencesAndBounds_ReturnsNumberOfPossibleArrays(int[] differences, int lower, int upper, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumberOfArrays(differences, lower, upper);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}