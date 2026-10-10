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

using LeetCode.Algorithms.LongestIdealSubsequence;

namespace LeetCode.Tests.Algorithms.LongestIdealSubsequence;

public abstract class LongestIdealSubsequenceTestsBase<T> where T : ILongestIdealSubsequence, new()
{
    [TestMethod]
    [DataRow("acfgbd", 2, 4)]
    [DataRow("abcd", 3, 4)]
    [DataRow("a", 0, 1)]
    [DataRow("a", 25, 1)]
    [DataRow("aaaa", 0, 4)]
    [DataRow("abc", 0, 1)]
    [DataRow("zyxw", 1, 4)]
    [DataRow("az", 25, 2)]
    [DataRow("az", 24, 1)]
    [DataRow("abcdefghijklmnopqrstuvwxyz", 1, 26)]
    [DataRow("zyxwvutsrqponmlkjihgfedcba", 0, 1)]
    [DataRow("acegikmoqsuwy", 2, 13)]
    [DataRow("abababab", 0, 4)]
    [DataRow("azazazaz", 25, 8)]
    [DataRow("lkpkxcnudpoeptsxwtibaz", 3, 9)]
    [DataRow("pvjcci", 4, 2)]
    [DataRow("eduktdb", 15, 5)]
    [DataRow("jxhwtafkdgs", 9, 7)]
    [DataRow("dbca", 1, 2)]
    [DataRow("tixlzwxuqaoyhubfdlphmrdshaxgnifymfyzcettoeeaagygffjkgrvugfwgmjalnfeickjtsatvwkcjljpwkfppwfbiaxlmarzn", 5, 49)]
    [DataRow("cxyaxazbybabxcycycxayzccaxabcyycbcczyaczccbazbzzcxbzaayyxabz", 2, 34)]
    public void LongestIdealString_WithInputStringAndMaxCharDiff_ReturnsLengthOfLongestValidSubsequence(string s, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LongestIdealString(s, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}