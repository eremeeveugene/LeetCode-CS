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

using LeetCode.Algorithms.MaximumMatchingOfPlayersWithTrainers;

namespace LeetCode.Tests.Algorithms.MaximumMatchingOfPlayersWithTrainers;

public abstract class MaximumMatchingOfPlayersWithTrainersTestsBase<T> where T : IMaximumMatchingOfPlayersWithTrainers, new()
{
    [TestMethod]
    [DataRow(new[] { 4, 7, 9 }, new[] { 8, 2, 5, 8 }, 2L)]
    [DataRow(new[] { 1, 1, 1 }, new[] { 10 }, 1L)]
    [DataRow(new[] { 1 }, new[] { 5, 6 }, 1L)]
    [DataRow(new[] { 1, 2 }, new[] { 3, 4, 5 }, 2L)]
    [DataRow(new[] { 5, 6 }, new[] { 1 }, 0L)]
    [DataRow(new[] { 1, 2, 3 }, new[] { 1, 2, 3 }, 3L)]
    [DataRow(new[] { 10, 20 }, new[] { 5, 5 }, 0L)]
    [DataRow(new[] { 1, 1 }, new[] { 1, 1 }, 2L)]
    [DataRow(new[] { 3 }, new[] { 1, 2, 3 }, 1L)]
    [DataRow(new[] { 2, 4, 6 }, new[] { 1, 3, 5, 7 }, 3L)]
    [DataRow(new[] { 5, 5, 5 }, new[] { 5, 5, 5 }, 3L)]
    [DataRow(new[] { 6, 7, 8 }, new[] { 1, 2, 3 }, 0L)]
    [DataRow(new[] { 1 }, new[] { 1 }, 1L)]
    [DataRow(new[] { 2 }, new[] { 1 }, 0L)]
    [DataRow(new[] { 1, 2, 3, 4 }, new[] { 4, 3, 2, 1 }, 4L)]
    [DataRow(new[] { 4, 5, 6, 7 }, new[] { 1, 2, 3 }, 0L)]
    [DataRow(new[] { 1, 1, 1, 1 }, new[] { 1, 1 }, 2L)]
    [DataRow(new[] { 2, 3, 4 }, new[] { 5 }, 1L)]
    [DataRow(new[] { 9 }, new[] { 1, 2, 3, 4, 5 }, 0L)]
    [DataRow(new[] { 1, 2, 3 }, new[] { 2 }, 1L)]
    public void MatchPlayersAndTrainers_WithPlayerAbilitiesAndTrainerCapacities_ReturnsMaximumMatchingCount(
        int[] players,
        int[] trainers,
        long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MatchPlayersAndTrainers(players, trainers);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}