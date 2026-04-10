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
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MaximumMatchingOfPlayersWithTrainers;

public abstract class MaximumMatchingOfPlayersWithTrainersTestsBase<T>
    where T : IMaximumMatchingOfPlayersWithTrainers, new()
{
    [TestMethod]
    [DataRow("[4,7,9]", "[8,2,5,8]", 2)]
    [DataRow("[1,1,1]", "[10]", 1)]
    public void MatchPlayersAndTrainers_WithPlayerAbilitiesAndTrainerCapacities_ReturnsMaximumMatchingCount(
        string playersJson, string trainersJson, long expectedResult)
    {
        // Arrange
        var players = JsonHelper.Parse<int[]>(playersJson);
        var trainers = JsonHelper.Parse<int[]>(trainersJson);

        var solution = new T();

        // Act
        var actualResult = solution.MatchPlayersAndTrainers(players, trainers);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}