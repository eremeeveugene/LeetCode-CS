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
    public void TrimTrailingVowels_WithGivenString_ReturnsStringWithoutTrailingVowels(string s, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.TrimTrailingVowels(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}