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

using LeetCode.Algorithms.TakeKOfEachCharacterFromLeftAndRight;

namespace LeetCode.Tests.Algorithms.TakeKOfEachCharacterFromLeftAndRight;

public abstract class TakeKOfEachCharacterFromLeftAndRightTestsBase<T> where T : ITakeKOfEachCharacterFromLeftAndRight, new()
{
    [TestMethod]
    [DataRow("aabaaaacaabc", 2, 8)]
    [DataRow("a", 1, -1)]
    public void TakeCharacters_WithTargetCountFromEnds_ReturnsMinimumMinutesToCollectKOfEachCharacterOrMinusOne(string s, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.TakeCharacters(s, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}