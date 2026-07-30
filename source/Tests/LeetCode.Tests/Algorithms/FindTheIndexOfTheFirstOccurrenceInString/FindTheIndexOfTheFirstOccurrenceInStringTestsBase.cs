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

using LeetCode.Algorithms.FindTheIndexOfTheFirstOccurrenceInString;

namespace LeetCode.Tests.Algorithms.FindTheIndexOfTheFirstOccurrenceInString;

public abstract class FindTheIndexOfTheFirstOccurrenceInStringTestsBase<T> where T : IFindTheIndexOfTheFirstOccurrenceInString, new()
{
    [TestMethod]
    [DataRow("sadbutsad", "sad", 0)]
    [DataRow("leetcode", "leeto", -1)]
    [DataRow("a", "a", 0)]
    [DataRow("a", "b", -1)]
    [DataRow("aa", "a", 0)]
    [DataRow("aaa", "aa", 0)]
    [DataRow("hello", "ll", 2)]
    [DataRow("hello", "hello", 0)]
    [DataRow("hello", "world", -1)]
    [DataRow("mississippi", "issip", 4)]
    [DataRow("mississippi", "pi", 9)]
    [DataRow("aaaa", "bba", -1)]
    [DataRow("abc", "c", 2)]
    [DataRow("abc", "bc", 1)]
    [DataRow("abcabc", "abc", 0)]
    [DataRow("abcabc", "cab", 2)]
    [DataRow("aabaab", "aab", 0)]
    [DataRow("abcdef", "f", 5)]
    [DataRow("aababab", "ababab", 1)]
    [DataRow("abababab", "ababab", 0)]
    [DataRow("abc", "", 0)]
    [DataRow("", "", 0)]
    [DataRow("", "abc", -1)]
    [DataRow("ab", "abc", -1)]
    public void StrStr_WithHaystackAndNeedle_ReturnsIndexOfFirstOccurrenceOrMinusOne(string haystack, string needle, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.StrStr(haystack, needle);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}