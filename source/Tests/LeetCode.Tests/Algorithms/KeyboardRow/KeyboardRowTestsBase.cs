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
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.KeyboardRow;

public abstract class KeyboardRowTestsBase<T> where T : IKeyboardRow, new()
{
    [TestMethod]
    [DataRow("[\"Hello\",\"Alaska\",\"Dad\",\"Peace\"]", "[\"Alaska\",\"Dad\"]")]
    [DataRow("[\"omk\"]", "[]")]
    [DataRow("[\"adsdf\",\"sfd\"]", "[\"adsdf\",\"sfd\"]")]
    public void FilterWordsByKeyboardRow_WithInputWordsArray_ReturnsMatchingWords(string wordsJson,
        string expectedResultJson)
    {
        // Arrange
        var words = JsonHelper<string[]>.Parse(wordsJson);
        var expectedResult = JsonHelper<string[]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.FindWords(words);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}