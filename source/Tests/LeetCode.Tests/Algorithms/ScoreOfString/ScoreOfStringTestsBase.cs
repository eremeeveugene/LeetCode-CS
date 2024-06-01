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

using LeetCode.Algorithms.ScoreOfString;

namespace LeetCode.Tests.Algorithms.ScoreOfString;

public abstract class ScoreOfStringTestsBase<T> where T : IScoreOfString, new()
{
    [TestMethod]
    [DataRow("hello", 13)]
    [DataRow("zaz", 50)]
    public void ScoreOfString_GivenString_ReturnsCorrectScore(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ScoreOfString(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}