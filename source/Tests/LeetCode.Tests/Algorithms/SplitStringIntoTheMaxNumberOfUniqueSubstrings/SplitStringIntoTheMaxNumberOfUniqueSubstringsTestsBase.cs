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

using LeetCode.Algorithms.SplitStringIntoTheMaxNumberOfUniqueSubstrings;

namespace LeetCode.Tests.Algorithms.SplitStringIntoTheMaxNumberOfUniqueSubstrings;

public abstract class SplitStringIntoTheMaxNumberOfUniqueSubstringsTestsBase<T> where T : ISplitStringIntoTheMaxNumberOfUniqueSubstrings, new()
{
    [TestMethod]
    [DataRow("ababccc", 5)]
    [DataRow("aba", 2)]
    [DataRow("aa", 1)]
    [DataRow("a", 1)]
    [DataRow("ab", 2)]
    [DataRow("abc", 3)]
    [DataRow("aaa", 2)]
    [DataRow("abab", 3)]
    [DataRow("abcabc", 4)]
    [DataRow("aaaaaaaaaaaaaaaa", 5)]
    [DataRow("abcdefghijklmnop", 16)]
    [DataRow("zzzzzzzzyyyyyyyy", 7)]
    [DataRow("abacabadabacaba", 8)]
    [DataRow("wwwzfvedwfvhsww", 11)]
    [DataRow("bbbbbbbbbbbbbbb", 5)]
    [DataRow("aabbaabbaabbaabb", 8)]
    [DataRow("qwertyuiopasdfgh", 16)]
    [DataRow("ababababababab", 6)]
    [DataRow("ababc", 4)]
    [DataRow("abcabcabcabcabca", 8)]
    public void MaxUniqueSplit_GivenString_ReturnsMaxNumberOfUniqueSplits(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxUniqueSplit(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}