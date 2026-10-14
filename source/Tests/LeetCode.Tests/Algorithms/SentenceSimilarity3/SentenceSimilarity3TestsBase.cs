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

using LeetCode.Algorithms.SentenceSimilarity3;

namespace LeetCode.Tests.Algorithms.SentenceSimilarity3;

public abstract class SentenceSimilarity3TestsBase<T> where T : ISentenceSimilarity3, new()
{
    [TestMethod]
    [DataRow("My name is Haley", "My Haley", true)]
    [DataRow("of", "A lot of words", false)]
    [DataRow("Eating right now", "Eating", true)]
    [DataRow("A a a a A A A", "A A a a a", false)]
    [DataRow("A B C D B B", "A B B", true)]
    [DataRow("z z z z", "zz z", false)]
    [DataRow("A a a", "Aa a", false)]
    [DataRow("hello racecar", "hello racecar acecar", true)]
    [DataRow("hello", "hr uyello", false)]
    [DataRow("DN PD", "D", false)]
    [DataRow("a", "a", true)]
    [DataRow("a", "b", false)]
    [DataRow("a b", "a", true)]
    [DataRow("a b", "b", true)]
    [DataRow("a b c", "a c", true)]
    [DataRow("a b c", "b", false)]
    [DataRow("a b c d e", "a e", true)]
    [DataRow("a b c d e", "a c e", false)]
    [DataRow("x y z", "x y z", true)]
    [DataRow("x y z", "z y x", false)]
    [DataRow("hello world", "world", true)]
    [DataRow("one two three", "one three", true)]
    [DataRow("a a b", "a b", true)]
    [DataRow("a b a", "a a", true)]
    [DataRow("Hello", "hello", false)]
    [DataRow("a b", "c d", false)]
    public void AreSentencesSimilar_GivenTwoSentences_ReturnsWhetherTheyAreSimilar(string sentence1, string sentence2, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.AreSentencesSimilar(sentence1, sentence2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}