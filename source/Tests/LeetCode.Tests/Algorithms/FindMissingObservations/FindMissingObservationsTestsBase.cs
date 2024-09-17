// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.FindMissingObservations;

namespace LeetCode.Tests.Algorithms.FindMissingObservations;

public abstract class FindMissingObservationsTestsBase<T> where T : IFindMissingObservations, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 2, 4, 3 }, 4, 2, new[] { 6, 6 })]
    [DataRow(new[] { 1, 5, 6 }, 3, 4, new[] { 2, 3, 2, 2 })]
    [DataRow(new[] { 1, 2, 3, 4 }, 6, 4, new int[] { })]
    [DataRow(new[] { 6, 3, 4, 3, 5, 3 }, 1, 6, new int[] { })]
    [DataRow(
        new[]
        {
            4, 2, 2, 5, 4, 5, 4, 5, 3, 3, 6, 1, 2, 4, 2, 1, 6, 5, 4, 2, 3, 4, 2, 3, 3, 5, 4, 1, 4, 4, 5, 3, 6, 1, 5,
            2, 3, 3, 6, 1, 6, 4, 1, 3
        }, 2, 53, new int[] { })]
    public void MissingRolls_WithRollsMeanAndN_ReturnsMissingRolls(int[] rolls, int mean, int n, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MissingRolls(rolls, mean, n);

        // Assert
        CollectionAssert.AreEquivalent(expectedResult, actualResult);
    }
}