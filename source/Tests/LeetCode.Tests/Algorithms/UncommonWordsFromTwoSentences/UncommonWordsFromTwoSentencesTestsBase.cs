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

using LeetCode.Algorithms.UncommonWordsFromTwoSentences;

namespace LeetCode.Tests.Algorithms.UncommonWordsFromTwoSentences;

public abstract class UncommonWordsFromTwoSentencesTestsBase<T> where T : IUncommonWordsFromTwoSentences, new()
{
    [TestMethod]
    [DataRow("this apple is sweet", "this apple is sour", new[] { "sweet", "sour" })]
    [DataRow("apple apple", "banana", new[] { "banana" })]
    [DataRow("abcd def abcd xyz", "ijk def ijk", new[] { "xyz" })]
    [DataRow("s z z z s", "s z ejt", new[] { "ejt" })]
    public void UncommonFromSentences_GivenTwoStrings_ReturnsUncommonWords(string s1, string s2,
        string[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.UncommonFromSentences(s1, s2);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}