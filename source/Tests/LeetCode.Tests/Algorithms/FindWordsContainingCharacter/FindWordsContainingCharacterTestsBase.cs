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

namespace LeetCode.Tests.Algorithms.FindWordsContainingCharacter;

public abstract class FindWordsContainingCharacterTestsBase<T> where T : IFindWordsContainingCharacter, new()
{
    [TestMethod]
    [DataRow(new[] { "leet", "code" }, 'e', new[] { 0, 1 })]
    [DataRow(new[] { "abc", "bcd", "aaaa", "cbc" }, 'a', new[] { 0, 2 })]
    [DataRow(new[] { "abc", "bcd", "aaaa", "cbc" }, 'z', new int[] { })]
    public void FindWordsContaining_WithArrayOfWordsAndChar_ReturnsIndicesOfWordsContainingChar(string[] words, char x,
        IList<int> expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindWordsContaining(words, x);

        // Assert
        CollectionAssert.AreEqual(expectedResult.ToArray(), actualResult.ToArray());
    }
}