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

public abstract class CheckIfStringsCanBeMadeEqualWithOperations2TestsBase<T> where T : ICheckIfStringsCanBeMadeEqualWithOperations2, new()
{
    [TestMethod]
    [DataRow("ab", "ab", true)]
    [DataRow("ab", "ba", false)]
    [DataRow("az", "za", false)]
    [DataRow("aa", "aa", true)]
    [DataRow("abc", "cba", true)]
    [DataRow("abcd", "bacd", false)]
    [DataRow("abcd", "abcd", true)]
    [DataRow("abcde", "cbaed", false)]
    [DataRow("abcde", "abcde", true)]
    [DataRow("aabbcc", "ccbbaa", true)]
    [DataRow("aabbcc", "bbaacc", true)]
    [DataRow("xyzxyz", "zyxzyx", true)]
    [DataRow("xyzxyz", "xyzxyz", true)]
    [DataRow("abcabc", "cbacba", true)]
    [DataRow("abcabc", "abccba", true)]
    [DataRow("zzzzzz", "zzzzzz", true)]
    [DataRow("zzzzzz", "zzzzzy", false)]
    [DataRow("abcdefgh", "cdabghef", true)]
    [DataRow("abcdefgh", "abcdefhg", false)]
    [DataRow("mnopmnop", "opmnopop", false)]
    [DataRow("a", "a", true)]
    [DataRow("aabb", "bbaa", true)]
    [DataRow("aaaa", "aaaa", true)]
    [DataRow("abab", "baba", false)]
    [DataRow("xxyy", "yyxx", true)]
    public void CheckStrings_WithGivenStrings_ReturnsTrueIfStringsCanBeMadeEqual(string s1, string s2, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CheckStrings(s1, s2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}