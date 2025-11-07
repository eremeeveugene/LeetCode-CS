// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.EqualScoreSubstrings;

namespace LeetCode.Tests.Algorithms.EqualScoreSubstrings;

public abstract class EqualScoreSubstringsTestsBase<T> where T : IEqualScoreSubstrings, new()
{
    [TestMethod]
    [DataRow("adcb", true)]
    [DataRow("bace", false)]
    public void ScoreBalance_WithInputString_ReturnsTrueIfSplitExists(string s, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ScoreBalance(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}