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

using LeetCode.Algorithms.TrimTrailingVowels;

namespace LeetCode.Tests.Algorithms.TrimTrailingVowels;

public abstract class TrimTrailingVowelsTestsBase<T> where T : ITrimTrailingVowels, new()
{
    [TestMethod]
    [DataRow("idea", "id")]
    [DataRow("day", "day")]
    [DataRow("aeiou", "")]
    [DataRow("a", "")]
    [DataRow("b", "b")]
    [DataRow("ab", "ab")]
    [DataRow("ba", "b")]
    [DataRow("aa", "")]
    [DataRow("bb", "bb")]
    [DataRow("aeiouaeiou", "")]
    [DataRow("bcdfg", "bcdfg")]
    [DataRow("bcdfgaeiou", "bcdfg")]
    [DataRow("abecidofuu", "abecidof")]
    [DataRow("education", "education")]
    [DataRow("rhythm", "rhythm")]
    [DataRow("queue", "q")]
    [DataRow("sky", "sky")]
    [DataRow("strengthen", "strengthen")]
    [DataRow("eerie", "eer")]
    [DataRow("aaaaab", "aaaaab")]
    [DynamicData(nameof(GetLargeTestData))]
    public void TrimTrailingVowels_WithGivenString_ReturnsStringWithoutTrailingVowels(string s, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.TrimTrailingVowels(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetLargeTestData()
    {
        yield return [new string('b', 100), "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb"];

        yield return [new string('a', 100), ""];

        yield return [new string('b', 50) + new string('e', 50), "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb"];
    }
}