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

using LeetCode.Algorithms.UniqueLength3PalindromicSubsequences;

namespace LeetCode.Tests.Algorithms.UniqueLength3PalindromicSubsequences;

public abstract class UniqueLength3PalindromicSubsequencesTestsBase<T> where T : IUniqueLength3PalindromicSubsequences, new()
{
    [TestMethod]
    [DataRow("adc", 0)]
    [DataRow("aabca", 3)]
    [DataRow("bbcbaba", 4)]
    [DataRow("aaa", 1)]
    [DataRow("aaaa", 1)]
    [DataRow("abc", 0)]
    [DataRow("aba", 1)]
    [DataRow("abcba", 3)]
    [DataRow("aabbcc", 0)]
    [DataRow("abcabc", 6)]
    [DataRow("zzzzzzzzzz", 1)]
    [DataRow("abacaba", 5)]
    [DataRow("xyzzyx", 3)]
    [DataRow("aaabaaa", 2)]
    [DataRow("qwertyuiopasdfghjklzxcvbnmmnbvcxzlkjhgfdsapoiuytrewq", 325)]
    [DataRow("aaaaaaaaaabbbbbbbbbb", 2)]
    [DataRow("abcabcabcabcabcabc", 9)]
    [DataRow("abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz", 676)]
    [DataRow("ababababab", 4)]
    [DataRow("aabaa", 2)]
    public void CountPalindromicSubsequence_WithStringInput_ReturnsNumberOfUniquePalindromes(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountPalindromicSubsequence(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}