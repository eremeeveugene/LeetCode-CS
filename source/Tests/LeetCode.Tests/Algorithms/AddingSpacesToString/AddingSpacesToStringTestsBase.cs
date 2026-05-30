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

using LeetCode.Algorithms.AddingSpacesToString;

namespace LeetCode.Tests.Algorithms.AddingSpacesToString;

public abstract class AddingSpacesToStringTestsBase<T> where T : IAddingSpacesToString, new()
{
    [TestMethod]
    [DataRow("LeetcodeHelpsMeLearn", new[] { 8, 13, 15 }, "Leetcode Helps Me Learn")]
    [DataRow("icodeinpython", new[] { 1, 5, 7, 9 }, "i code in py thon")]
    [DataRow("spacing", new[] { 0, 1, 2, 3, 4, 5, 6 }, " s p a c i n g")]
    [DataRow("abc", new int[0], "abc")]
    [DataRow("a", new[] { 0 }, " a")]
    [DataRow("abcdef", new[] { 3 }, "abc def")]
    [DataRow("abcdef", new[] { 1, 2, 3, 4, 5 }, "a b c d e f")]
    [DataRow("abc", new[] { 0, 3 }, " abc")]
    [DataRow("abc", new[] { 3 }, "abc")]
    [DataRow("hello", new[] { 0, 5 }, " hello")]
    [DataRow("world", new[] { 2 }, "wo rld")]
    [DataRow("abcdef", new[] { 0, 6 }, " abcdef")]
    [DataRow("abcdef", new[] { 5 }, "abcde f")]
    [DataRow("abcdef", new[] { 2, 4 }, "ab cd ef")]
    [DataRow("abcdef", new[] { 1, 4 }, "a bcd ef")]
    [DataRow("aaaaaa", new[] { 1, 3, 5 }, "a aa aa a")]
    [DataRow("zzzz", new[] { 1, 2, 3 }, "z z z z")]
    [DataRow("edgecase", new[] { 0 }, " edgecase")]
    [DataRow("edgecase", new[] { 7 }, "edgecas e")]
    [DataRow("edgecase", new[] { 8 }, "edgecase")]
    [DataRow("longstringtest", new[] { 4, 10 }, "long string test")]
    [DataRow("123456789", new[] { 3, 6 }, "123 456 789")]
    public void AddSpaces_WithInputStringAndSpaceIndices_ReturnsStringWithInsertedSpaces(string s, int[] spaces, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.AddSpaces(s, spaces);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}