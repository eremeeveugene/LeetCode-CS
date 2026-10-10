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

using LeetCode.Algorithms.NumberOfWonderfulSubstrings;

namespace LeetCode.Tests.Algorithms.NumberOfWonderfulSubstrings;

public abstract class NumberOfWonderfulSubstringsTestsBase<T> where T : INumberOfWonderfulSubstrings, new()
{
    [TestMethod]
    [DataRow("aba", 4)]
    [DataRow("aabb", 9)]
    [DataRow("he", 2)]
    [DataRow("a", 1)]
    [DataRow("j", 1)]
    [DataRow("aa", 3)]
    [DataRow("ab", 2)]
    [DataRow("abc", 3)]
    [DataRow("aaa", 6)]
    [DataRow("abab", 7)]
    [DataRow("abcabc", 9)]
    [DataRow("jjjj", 10)]
    [DataRow("abcdefghij", 10)]
    [DataRow("aabbcc", 18)]
    [DataRow("ajaj", 7)]
    [DataRow("aaaaaaaaaa", 55)]
    [DataRow("jihgfedcba", 10)]
    [DataRow("abacabadaba", 20)]
    [DataRow("afgdcffceahbgcbfjaefhgechdjegcg", 43)]
    [DataRow("egfdjhcfdjddgjdgejbb", 35)]
    [DataRow("gdcieffadcbebdiggbjcacbjehaacgibgd", 54)]
    [DataRow("dehegjbegihghfgcdfjafjjjibjjdacaijdbajehfbjcdheaecjhjbjjgjaggdadicheacaiaejbecfiejigibidhfjbgfcjhhff", 185)]
    public void WonderfulSubstrings_WithAlphabetSubsetWord_ReturnsCountOfWonderfulSubstrings(string word, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.WonderfulSubstrings(word);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}