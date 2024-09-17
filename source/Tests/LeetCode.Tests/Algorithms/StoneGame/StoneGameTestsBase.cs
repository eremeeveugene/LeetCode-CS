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

using LeetCode.Algorithms.StoneGame;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.StoneGame;

public abstract class StoneGameTestsBase<T> where T : IStoneGame, new()
{
    [TestMethod]
    [DataRow("[5,3,4,5]", true)]
    [DataRow("[3,7,2,3]", true)]
    public void StoneGame_WithGivenPiles_ReturnsTrueWhenFirstPlayerWins(string pilesJsonArray, bool expectedResult)
    {
        // Arrange
        var piles = JsonHelper<int>.DeserializeToArray(pilesJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.StoneGame(piles);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}