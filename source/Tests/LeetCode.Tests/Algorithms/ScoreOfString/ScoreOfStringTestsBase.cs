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

using LeetCode.Algorithms.ScoreOfString;

namespace LeetCode.Tests.Algorithms.ScoreOfString;

public abstract class ScoreOfStringTestsBase<T> where T : IScoreOfString, new()
{
    [TestMethod]
    [DataRow("hello", 13)]
    [DataRow("zaz", 50)]
    [DataRow("ab", 1)]
    [DataRow("aa", 0)]
    [DataRow("az", 25)]
    [DataRow("za", 25)]
    [DataRow("abc", 2)]
    [DataRow("zyx", 2)]
    [DataRow("azazaz", 125)]
    [DataRow("leetcode", 63)]
    [DataRow("aaaaaaaaaa", 0)]
    [DataRow("abcdefghijklmnopqrstuvwxyz", 25)]
    [DataRow("zyxwvutsrqponmlkjihgfedcba", 25)]
    [DataRow("zazazazaza", 225)]
    [DataRow("mnbvcxz", 75)]
    [DataRow("qqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqq", 0)]
    [DataRow("azazazazazazazazazazazazazazazazazazazazazazazazazazazazazazazazazazazazazazazazazazazazazazazazazaz", 2475)]
    [DataRow("helloworld", 46)]
    [DataRow("abcabc", 6)]
    [DataRow("pppq", 1)]
    public void ScoreOfString_WithInputString_ReturnsSumOfAbsoluteAsciiDifferencesBetweenAdjacentCharacters(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ScoreOfString(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}