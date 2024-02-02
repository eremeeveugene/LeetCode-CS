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

using LeetCode.Algorithms.CountOfMatchesInTournament;

namespace LeetCode.Tests.Algorithms.CountOfMatchesInTournament;

public abstract class CountOfMatchesInTournamentTestsBase<T> where T : ICountOfMatchesInTournament, new()
{
    [TestMethod]
    [DataRow(7, 6)]
    [DataRow(14, 13)]
    public void NumberOfMatches_WithSingleEliminationTournamentInputs_ReturnsExpectedMatchesCount(int n,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumberOfMatches(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}