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

using LeetCode.Algorithms.MinimumASCIIDeleteSumForTwoStrings;

namespace LeetCode.Tests.Algorithms.MinimumASCIIDeleteSumForTwoStrings;

public abstract class MinimumASCIIDeleteSumForTwoStringsTestsBase<T> where T : IMinimumASCIIDeleteSumForTwoStrings, new()
{
    [TestMethod]
    [DataRow("sea", "eat", 231)]
    [DataRow("delete", "leet", 403)]
    [DataRow("a", "a", 0)]
    [DataRow("a", "b", 195)]
    [DataRow("", "a", 97)]
    [DataRow("a", "", 97)]
    [DataRow("abc", "abc", 0)]
    [DataRow("ab", "ba", 194)]
    [DataRow("abc", "ac", 98)]
    [DataRow("abc", "bc", 97)]
    [DataRow("abc", "ab", 99)]
    [DataRow("abcd", "bd", 196)]
    [DataRow("abc", "def", 597)]
    [DataRow("ba", "ab", 194)]
    [DataRow("aa", "a", 97)]
    [DataRow("aab", "ab", 97)]
    [DataRow("abc", "cba", 390)]
    [DataRow("b", "ab", 97)]
    [DataRow("zz", "z", 122)]
    public void MinimumDeleteSum_WithInputStrings_ReturnsMinimumAsciiDeletionSumToMakeStringsEqual(string s1, string s2, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimumDeleteSum(s1, s2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}