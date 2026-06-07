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

using LeetCode.Algorithms.RepeatedSubstringPattern;

namespace LeetCode.Tests.Algorithms.RepeatedSubstringPattern;

public abstract class RepeatedSubstringPatternTestsBase<T> where T : IRepeatedSubstringPattern, new()
{
    [TestMethod]
    [DataRow("abab", true)]
    [DataRow("aba", false)]
    [DataRow("abcabcabcabc", true)]
    [DataRow("a", false)]
    [DataRow("aa", true)]
    [DataRow("aaa", true)]
    [DataRow("ab", false)]
    [DataRow("aaaa", true)]
    [DataRow("abcabc", true)]
    [DataRow("xyzxyzxyz", true)]
    [DataRow("abcde", false)]
    [DataRow("abaaba", true)]
    [DataRow("abababab", true)]
    [DataRow("abcdabcd", true)]
    [DataRow("abcabcabc", true)]
    [DataRow("aabaabaab", true)]
    [DataRow("abacabac", true)]
    [DataRow("zz", true)]
    [DataRow("zzz", true)]
    [DataRow("abba", false)]
    public void RepeatedSubstringPattern_GivenString_EvaluatesStringPatternRepetition(string s, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RepeatedSubstringPattern(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}