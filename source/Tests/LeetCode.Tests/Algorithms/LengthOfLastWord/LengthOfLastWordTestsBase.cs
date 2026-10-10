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

using LeetCode.Algorithms.LengthOfLastWord;

namespace LeetCode.Tests.Algorithms.LengthOfLastWord;

public abstract class LengthOfLastWordTestsBase<T> where T : ILengthOfLastWord, new()
{
    [TestMethod]
    [DataRow("Hello World", 5)]
    [DataRow("   fly me   to   the moon  ", 4)]
    [DataRow("luffy is still joyboy", 6)]
    [DataRow("a", 1)]
    [DataRow("a ", 1)]
    [DataRow(" a", 1)]
    [DataRow("  a  ", 1)]
    [DataRow("ab cd", 2)]
    [DataRow("ab  cd  ", 2)]
    [DataRow("   ab   ", 2)]
    [DataRow("a b c d e", 1)]
    [DataRow("one", 3)]
    [DataRow("one two three", 5)]
    [DataRow("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", 50)]
    [DataRow("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx y", 1)]
    [DataRow("          hello", 5)]
    [DataRow("hello          ", 5)]
    [DataRow("The quick brown fox", 3)]
    [DataRow("a  bb  ccc  dddd", 4)]
    [DataRow("Today is a nice day  ", 3)]
    public void LengthOfLastWord_GivenString_ReturnsLengthOfLastWord(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LengthOfLastWord(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}