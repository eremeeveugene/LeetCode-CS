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

using LeetCode.Algorithms.CheckIfOneStringSwapCanMakeStringsEqual;

namespace LeetCode.Tests.Algorithms.CheckIfOneStringSwapCanMakeStringsEqual;

public abstract class CheckIfOneStringSwapCanMakeStringsEqualTestsBase<T> where T : ICheckIfOneStringSwapCanMakeStringsEqual, new()
{
    [TestMethod]
    [DataRow("bank", "kanb", true)]
    [DataRow("attack", "defend", false)]
    [DataRow("kelb", "kelb", true)]
    [DataRow("ab", "ca", false)]
    [DataRow("abc", "abd", false)]
    [DataRow("abcd", "abdc", true)]
    [DataRow("abcd", "dcba", false)]
    [DataRow("aa", "aa", true)]
    [DataRow("ab", "ba", true)]
    [DataRow("abcde", "abcde", true)]
    [DataRow("converse", "conserve", true)]
    [DataRow("abcd", "abce", false)]
    [DataRow("abcd", "badc", false)]
    [DataRow("ta", "at", true)]
    [DataRow("abac", "abca", true)]
    [DataRow("abcc", "abcd", false)]
    [DataRow("xy", "yx", true)]
    [DataRow("xy", "yz", false)]
    [DataRow("aabb", "bbaa", false)]
    [DataRow("caa", "aac", true)]
    [DataRow("one", "neo", false)]
    public void AreAlmostEqual_WithTwoStrings_ReturnsIfTheyCanBeMadeEqualByOneSwap(string s1, string s2, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.AreAlmostEqual(s1, s2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}