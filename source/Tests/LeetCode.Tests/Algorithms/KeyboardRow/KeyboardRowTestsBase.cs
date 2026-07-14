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

using LeetCode.Algorithms.KeyboardRow;

namespace LeetCode.Tests.Algorithms.KeyboardRow;

public abstract class KeyboardRowTestsBase<T> where T : IKeyboardRow, new()
{
    [TestMethod]
    [DataRow(new[] { "Hello", "Alaska", "Dad", "Peace" }, new[] { "Alaska", "Dad" })]
    [DataRow(new[] { "omk" }, new string[0])]
    [DataRow(new[] { "adsdf", "sfd" }, new[] { "adsdf", "sfd" })]
    public void FilterWordsByKeyboardRow_WithInputWordsArray_ReturnsMatchingWords(string[] words, string[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindWords(words);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}