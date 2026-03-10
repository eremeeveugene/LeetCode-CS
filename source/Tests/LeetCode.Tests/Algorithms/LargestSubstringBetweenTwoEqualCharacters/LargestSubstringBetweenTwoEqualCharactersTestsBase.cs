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

using LeetCode.Algorithms.LargestSubstringBetweenTwoEqualCharacters;

namespace LeetCode.Tests.Algorithms.LargestSubstringBetweenTwoEqualCharacters;

public abstract class LargestSubstringBetweenTwoEqualCharactersTestsBase<T>
    where T : ILargestSubstringBetweenTwoEqualCharacters, new()
{
    [TestMethod]
    [DataRow("aa", 0)]
    [DataRow("abca", 2)]
    [DataRow("cbzxy", -1)]
    public void MaxLengthBetweenEqualCharacters_WithGivenString_ReturnsMaxLengthBetweenMatchingCharacters(string s,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxLengthBetweenEqualCharacters(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}