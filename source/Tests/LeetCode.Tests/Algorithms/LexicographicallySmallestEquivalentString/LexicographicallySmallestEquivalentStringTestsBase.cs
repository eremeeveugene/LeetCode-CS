// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.LexicographicallySmallestEquivalentString;

namespace LeetCode.Tests.Algorithms.LexicographicallySmallestEquivalentString;

public abstract class LexicographicallySmallestEquivalentStringTestsBase<T>
    where T : ILexicographicallySmallestEquivalentString, new()
{
    [TestMethod]
    [DataRow("parker", "morris", "parser", "makkek")]
    [DataRow("hello", "world", "hold", "hdld")]
    [DataRow("leetcode", "programs", "sourcecode", "aauaaaaada")]
    public void SmallestEquivalentString_WithCharacterEquivalencyMappings_ReturnsLexicographicallySmallestString(
        string s1, string s2, string baseStr, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SmallestEquivalentString(s1, s2, baseStr);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}