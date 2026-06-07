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

using LeetCode.Algorithms.FindTheDifference;

namespace LeetCode.Tests.Algorithms.FindTheDifference;

public abstract class FindTheDifferenceTestsBase<T> where T : IFindTheDifference, new()
{
    [TestMethod]
    [DataRow("abcd", "abcde", 'e')]
    [DataRow("", "y", 'y')]
    [DataRow("a", "aa", 'a')]
    [DataRow("ae", "aea", 'a')]
    [DataRow("xyz", "xyzz", 'z')]
    [DataRow("abc", "abcd", 'd')]
    [DataRow("aab", "aabb", 'b')]
    [DataRow("zz", "zzz", 'z')]
    [DataRow("abcde", "abcdef", 'f')]
    [DataRow("abcde", "aabcde", 'a')]
    [DataRow("b", "bb", 'b')]
    [DataRow("ba", "bba", 'b')]
    [DataRow("mn", "mno", 'o')]
    [DataRow("hello", "hellox", 'x')]
    [DataRow("world", "wworld", 'w')]
    [DataRow("aaa", "aaaa", 'a')]
    [DataRow("cd", "cde", 'e')]
    public void FindTheDifference_WithTwoStrings_ReturnsExtraCharacter(string s, string t, char expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindTheDifference(s, t);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}