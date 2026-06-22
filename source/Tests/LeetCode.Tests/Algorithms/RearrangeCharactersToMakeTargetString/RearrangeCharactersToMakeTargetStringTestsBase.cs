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

using LeetCode.Algorithms.RearrangeCharactersToMakeTargetString;

namespace LeetCode.Tests.Algorithms.RearrangeCharactersToMakeTargetString;

public abstract class RearrangeCharactersToMakeTargetStringTestsBase<T> where T : IRearrangeCharactersToMakeTargetString, new()
{
    [TestMethod]
    [DataRow("ilovecodingonleetcode", "code", 2)]
    [DataRow("abcba", "abc", 1)]
    [DataRow("abbaccaddaeea", "aaaaa", 1)]
    [DataRow("a", "a", 1)]
    [DataRow("a", "b", 0)]
    [DataRow("aa", "a", 2)]
    [DataRow("aaa", "a", 3)]
    [DataRow("abc", "abc", 1)]
    [DataRow("abcabc", "abc", 2)]
    [DataRow("aabbcc", "abc", 2)]
    [DataRow("aabbc", "abc", 1)]
    [DataRow("z", "z", 1)]
    [DataRow("xyz", "zyx", 1)]
    [DataRow("aaaaa", "aa", 2)]
    [DataRow("aaaa", "aa", 2)]
    [DataRow("aaabbb", "ab", 3)]
    [DataRow("aaabb", "ab", 2)]
    [DataRow("leetcode", "leet", 1)]
    [DataRow("hello", "lo", 1)]
    [DataRow("aabbccddee", "abcde", 2)]
    [DataRow("abcdefghij", "z", 0)]
    [DataRow("mississippi", "issi", 2)]
    public void RearrangeCharacters_WithSourceAndTarget_ReturnsMaximumCopies(string s, string target, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RearrangeCharacters(s, target);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}