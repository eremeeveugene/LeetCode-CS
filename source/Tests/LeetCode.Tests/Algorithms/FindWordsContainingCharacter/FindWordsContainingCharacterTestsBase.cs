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

using LeetCode.Algorithms.FindWordsContainingCharacter;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindWordsContainingCharacter;

public abstract class FindWordsContainingCharacterTestsBase<T> where T : IFindWordsContainingCharacter, new()
{
    [TestMethod]
    [DataRow("[\"leet\", \"code\"]", 'e', "[0, 1]")]
    [DataRow("[\"abc\", \"bcd\", \"aaaa\", \"cbc\"]", 'a', "[0, 2]")]
    [DataRow("[\"abc\", \"bcd\", \"aaaa\", \"cbc\"]", 'z', "[]")]
    public void FindWordsContaining_WithArrayOfWordsAndChar_ReturnsIndicesOfWordsContainingChar(string wordsJsonArray,
        char x, string expectedResultJsonArray)
    {
        // Arrange
        var words = JsonHelper<string>.DeserializeToArray(wordsJsonArray);
        var expectedResult = JsonHelper<int>.DeserializeToList(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.FindWordsContaining(words, x);

        // Assert
        CollectionAssert.AreEqual(expectedResult.ToArray(), actualResult.ToArray());
    }
}