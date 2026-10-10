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

using LeetCode.Algorithms.UncommonWordsFromTwoSentences;

namespace LeetCode.Tests.Algorithms.UncommonWordsFromTwoSentences;

public abstract class UncommonWordsFromTwoSentencesTestsBase<T> where T : IUncommonWordsFromTwoSentences, new()
{
    [TestMethod]
    [DataRow("this apple is sweet", "this apple is sour", new[] { "sweet", "sour" })]
    [DataRow("apple apple", "banana", new[] { "banana" })]
    [DataRow("abcd def abcd xyz", "ijk def ijk", new[] { "xyz" })]
    [DataRow("s z z z s", "s z ejt", new[] { "ejt" })]
    [DataRow("a b", "c d", new[] { "a", "b", "c", "d" })]
    [DataRow("a", "a", new string[] { })]
    [DataRow("hello world", "world hello", new string[] { })]
    [DataRow("a a a", "b", new[] { "b" })]
    [DataRow("x", "y", new[] { "x", "y" })]
    [DataRow("the quick brown fox", "the lazy dog", new[] { "quick", "brown", "fox", "lazy", "dog" })]
    [DataRow("a b c", "a b c d", new[] { "d" })]
    [DataRow("one two two", "three three four", new[] { "one", "four" })]
    [DataRow("z", "z z", new string[] { })]
    [DataRow("a b a", "c b", new[] { "c" })]
    [DataRow("alpha", "beta alpha gamma", new[] { "beta", "gamma" })]
    [DataRow("q w e r t y", "y t r e w q", new string[] { })]
    [DataRow("same same same", "same", new string[] { })]
    [DataRow("cat dog", "dog bird cat fish", new[] { "bird", "fish" })]
    [DataRow("a b c d e f g h i j", "k l m", new[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m" })]
    [DataRow("aa aaa", "aaaa aa", new[] { "aaa", "aaaa" })]
    public void UncommonFromSentences_GivenTwoStrings_ReturnsUncommonWords(string s1, string s2, string[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.UncommonFromSentences(s1, s2);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}