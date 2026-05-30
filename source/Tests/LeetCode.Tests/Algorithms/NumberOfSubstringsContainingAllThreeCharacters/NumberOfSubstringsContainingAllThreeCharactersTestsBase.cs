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

using LeetCode.Algorithms.NumberOfSubstringsContainingAllThreeCharacters;

namespace LeetCode.Tests.Algorithms.NumberOfSubstringsContainingAllThreeCharacters;

public abstract class NumberOfSubstringsContainingAllThreeCharactersTestsBase<T> where T : INumberOfSubstringsContainingAllThreeCharacters, new()
{
    [TestMethod]
    [DataRow("abcabc", 10)]
    [DataRow("aaacb", 3)]
    [DataRow("abc", 1)]
    public void NumberOfSubstrings_WithGivenString_ReturnsNumberOfSubstringsContainingAllThreeCharacters(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumberOfSubstrings(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}