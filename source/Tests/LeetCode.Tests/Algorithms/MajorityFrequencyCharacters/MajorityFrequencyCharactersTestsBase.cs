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

using LeetCode.Algorithms.MajorityFrequencyCharacters;

namespace LeetCode.Tests.Algorithms.MajorityFrequencyCharacters;

public abstract class MajorityFrequencyCharactersTestsBase<T> where T : IMajorityFrequencyCharacters, new()
{
    [TestMethod]
    [DataRow("aaabbbccdddde", "ab")]
    [DataRow("abcd", "abcd")]
    [DataRow("pfpfgi", "pf")]
    [DataRow("a", "a")]
    [DataRow("aa", "a")]
    [DataRow("aabb", "ab")]
    [DataRow("aaabb", "a")]
    [DataRow("aabbcc", "abc")]
    [DataRow("aaabbbccc", "abc")]
    [DataRow("aaaabbbbcccc", "abc")]
    [DataRow("aaabbbccdddd", "ab")]
    [DataRow("aabbccdd", "abcd")]
    [DataRow("zzzzz", "z")]
    [DataRow("xxyyzz", "xyz")]
    [DataRow("aabbbcccc", "c")]
    [DataRow("aaabbbcccc", "ab")]
    [DataRow("mmmnnnoooo", "mn")]
    [DataRow("qqrrrsssst", "s")]
    public void MajorityFrequencyGroup_WithInputString_ReturnsCharactersFromTheLargestDistinctCharactersGroup(string s, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MajorityFrequencyGroup(s);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult, SequenceOrder.InAnyOrder);
    }
}