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

using LeetCode.Algorithms.CheckIfStringsCanBeMadeEqualWithOperations2;

namespace LeetCode.Tests.Algorithms.CheckIfStringsCanBeMadeEqualWithOperations2;

public abstract class CheckIfStringsCanBeMadeEqualWithOperations2TestsBase<T>
    where T : ICheckIfStringsCanBeMadeEqualWithOperations2, new()
{
    [TestMethod]
    [DataRow("abcdba", "cabdab", true)]
    [DataRow("abe", "bea", false)]
    [DataRow("a", "a", true)]
    [DataRow("ab", "ab", true)]
    [DataRow("ab", "ba", false)]
    [DataRow("abc", "cba", true)]
    [DataRow("abc", "bac", false)]
    [DataRow("abcd", "cdab", true)]
    [DataRow("abcd", "adcb", false)]
    [DataRow("abcd", "cbad", true)]
    [DataRow("aaabbb", "ababab", true)]
    [DataRow("aaabbb", "bbbaaa", false)]
    [DataRow("zzxy", "xzyz", true)]
    [DataRow("zzxy", "zyxz", false)]
    [DataRow("abab", "baba", true)]
    [DataRow("abab", "abba", false)]
    [DataRow("abcabc", "cbacba", true)]
    [DataRow("abcabc", "acbbca", false)]
    public void CheckStrings_WithGivenStrings_ReturnsTrueIfStringsCanBeMadeEqual(string s1, string s2,
        bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CheckStrings(s1, s2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}