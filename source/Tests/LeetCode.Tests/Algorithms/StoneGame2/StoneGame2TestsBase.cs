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

using LeetCode.Algorithms.StoneGame2;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.StoneGame2;

public abstract class StoneGame2TestsBase<T> where T : IStoneGame2, new()
{
    [TestMethod]
    [DataRow("[1]", 1)]
    [DataRow("[2,7,9,4,4]", 10)]
    [DataRow("[1,2,3,4,5,100]", 104)]
    [DataRow("[100,10,100,100,100,100]", 300)]
    public void StoneGameII_WithGivenPiles_ReturnsMaxPossibleScore(string pilesJsonArray, int expectedResult)
    {
        // Arrange
        var piles = JsonHelper<int>.DeserializeToArray(pilesJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.StoneGameII(piles);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}