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

using LeetCode.Algorithms.FindLongestSpecialSubstringThatOccursThrice1;

namespace LeetCode.Tests.Algorithms.FindLongestSpecialSubstringThatOccursThrice1;

public abstract class FindLongestSpecialSubstringThatOccursThrice1TestsBase<T> where T : IFindLongestSpecialSubstringThatOccursThrice1, new()
{
    [TestMethod]
    [DataRow("aaaa", 2)]
    [DataRow("abcdef", -1)]
    [DataRow("abcaba", 1)]
    [DataRow("aaa", 1)]
    [DataRow("abc", -1)]
    [DataRow("aab", -1)]
    [DataRow("aaaaa", 3)]
    [DataRow("aaaaaaaaaa", 8)]
    [DataRow("abababab", 1)]
    [DataRow("aabbaabbaabb", 2)]
    [DataRow("zzzyzzzyzzz", 3)]
    [DataRow("abcabcabc", 1)]
    [DataRow("aaabaaabaaab", 3)]
    [DataRow("aabaabaab", 2)]
    [DataRow("xxyyzz", -1)]
    [DataRow("abbbbbbc", 4)]
    [DataRow("aaaabaaaa", 3)]
    [DataRow("aabaaba", 1)]
    [DataRow("bababaabbb", 1)]
    [DataRow("aaabbbabb", 2)]
    [DataRow("abbabababbbbbabbbab", 3)]
    [DataRow("bbaabbabbaaabaabaaab", 2)]
    [DataRow("abbabaaaaaaaba", 5)]
    public void MaximumLength_WithInputString_ReturnsLengthOfTheLongestSpecialSubstring(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaximumLength(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}