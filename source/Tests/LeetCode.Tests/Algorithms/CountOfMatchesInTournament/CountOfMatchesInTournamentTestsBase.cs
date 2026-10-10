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

using LeetCode.Algorithms.CountOfMatchesInTournament;

namespace LeetCode.Tests.Algorithms.CountOfMatchesInTournament;

public abstract class CountOfMatchesInTournamentTestsBase<T> where T : ICountOfMatchesInTournament, new()
{
    [TestMethod]
    [DataRow(7, 6)]
    [DataRow(14, 13)]
    [DataRow(1, 0)]
    [DataRow(2, 1)]
    [DataRow(3, 2)]
    [DataRow(4, 3)]
    [DataRow(5, 4)]
    [DataRow(6, 5)]
    [DataRow(8, 7)]
    [DataRow(9, 8)]
    [DataRow(10, 9)]
    [DataRow(16, 15)]
    [DataRow(17, 16)]
    [DataRow(31, 30)]
    [DataRow(32, 31)]
    [DataRow(33, 32)]
    [DataRow(64, 63)]
    [DataRow(100, 99)]
    [DataRow(199, 198)]
    [DataRow(200, 199)]
    public void NumberOfMatches_WithNumberOfTeams_ReturnsTotalMatchesInEliminationTournament(int n, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumberOfMatches(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}