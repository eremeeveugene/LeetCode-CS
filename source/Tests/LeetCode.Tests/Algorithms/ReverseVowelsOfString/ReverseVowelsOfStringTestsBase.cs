// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.ReverseVowelsOfString;

namespace LeetCode.Tests.Algorithms.ReverseVowelsOfString;

public abstract class ReverseVowelsOfStringTestsBase<T> where T : IReverseVowelsOfString, new()
{
    [TestMethod]
    [DataRow("hello", "holle")]
    [DataRow("leetcode", "leotcede")]
    [DataRow("aA", "Aa")]
    [DataRow("Euston saw I was not Sue.", "euston saw I was not SuE.")]
    public void ReverseVowels_GivenStringWithVowels_ReturnsStringWithVowelsReversed(string s, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ReverseVowels(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}