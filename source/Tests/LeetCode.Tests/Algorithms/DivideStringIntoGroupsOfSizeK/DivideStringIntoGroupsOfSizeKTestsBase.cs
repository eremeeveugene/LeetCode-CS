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

using LeetCode.Algorithms.DivideStringIntoGroupsOfSizeK;

namespace LeetCode.Tests.Algorithms.DivideStringIntoGroupsOfSizeK;

public abstract class DivideStringIntoGroupsOfSizeKTestsBase<T> where T : IDivideStringIntoGroupsOfSizeK, new()
{
    [TestMethod]
    [DataRow("abcdefghi", 3, 'x', new[] { "abc", "def", "ghi" })]
    [DataRow("abcdefghij", 3, 'x', new[] { "abc", "def", "ghi", "jxx" })]
    [DataRow("a", 1, 'z', new[] { "a" })]
    [DataRow("a", 5, 'b', new[] { "abbbb" })]
    [DataRow("abc", 3, 'x', new[] { "abc" })]
    [DataRow("abc", 2, 'x', new[] { "ab", "cx" })]
    [DataRow("abcd", 1, 'x', new[] { "a", "b", "c", "d" })]
    [DataRow("abcdef", 4, 'z', new[] { "abcd", "efzz" })]
    [DataRow("hello", 2, 'q', new[] { "he", "ll", "oq" })]
    [DataRow("hello", 10, 'w', new[] { "hellowwwww" })]
    [DataRow("aaaaa", 2, 'a', new[] { "aa", "aa", "aa" })]
    [DataRow("abcdefghijklmnopqrstuvwxyz", 5, 'y', new[] { "abcde", "fghij", "klmno", "pqrst", "uvwxy", "zyyyy" })]
    [DataRow("xy", 2, 'k', new[] { "xy" })]
    [DataRow("xyz", 100, 'm', new[] { "xyzmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm" })]
    [DataRow("abcdefghij", 5, 'z', new[] { "abcde", "fghij" })]
    [DataRow("abcdefghijk", 5, 'z', new[] { "abcde", "fghij", "kzzzz" })]
    [DataRow("leetcode", 3, 'o', new[] { "lee", "tco", "deo" })]
    [DataRow("zzzz", 3, 'a', new[] { "zzz", "zaa" })]
    [DataRow("ab", 1, 'c', new[] { "a", "b" })]
    [DataRow("abcdefg", 7, 't', new[] { "abcdefg" })]
    public void DivideString_WithLengthMultipleOfK_ReturnsGroupsWithoutPadding(string s, int k, char fill, string[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.DivideString(s, k, fill);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}