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