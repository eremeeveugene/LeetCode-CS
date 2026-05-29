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

public abstract class MaximumMatchingOfPlayersWithTrainersTestsBase<T>
    where T : IMaximumMatchingOfPlayersWithTrainers, new()
{
    [TestMethod]
    [DataRow(new[] { 4, 7, 9 }, new[] { 8, 2, 5, 8 }, 2L)]
    [DataRow(new[] { 1, 1, 1 }, new[] { 10 }, 1L)]
    public void MatchPlayersAndTrainers_WithPlayerAbilitiesAndTrainerCapacities_ReturnsMaximumMatchingCount(
        int[] players, int[] trainers, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MatchPlayersAndTrainers(players, trainers);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}