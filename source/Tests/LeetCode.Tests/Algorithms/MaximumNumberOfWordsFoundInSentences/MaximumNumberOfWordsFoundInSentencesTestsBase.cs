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

using LeetCode.Algorithms.MaximumNumberOfWordsFoundInSentences;

namespace LeetCode.Tests.Algorithms.MaximumNumberOfWordsFoundInSentences;

public abstract class MaximumNumberOfWordsFoundInSentencesTestsBase<T> where T : IMaximumNumberOfWordsFoundInSentences, new()
{
    [TestMethod]
    [DataRow(new[] { "alice and bob love leetcode", "i think so too", "this is great thanks very much" }, 6)]
    [DataRow(new[] { "please wait", "continue to fight", "continue to win" }, 3)]
    [DataRow(new[] { "a" }, 1)]
    [DataRow(new[] { "a b" }, 2)]
    [DataRow(new[] { "a b c", "d" }, 3)]
    [DataRow(new[] { "one two", "three four five", "six" }, 3)]
    [DataRow(new[] { "hello", "hello", "hello" }, 1)]
    [DataRow(new[] { "a b c d e f g h i j k l m n o p" }, 16)]
    [DataRow(new[] { "x y", "x y", "x y" }, 2)]
    [DataRow(new[] { "i love you", "me too" }, 3)]
    [DataRow(new[] { "abc def", "g", "hi jk lm no pq" }, 5)]
    [DataRow(new[] { "a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a" }, 50)]
    [DataRow(new[] { "a", "b c", "d e f", "g h i j" }, 4)]
    [DataRow(new[] { "the quick brown fox jumps over the lazy dog", "pack my box with five dozen liquor jugs" }, 9)]
    [DataRow(new[] { "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b", "a b" }, 2)]
    [DataRow(new[] { "jfm axw a hwnrgs et f", "ofsh mjntnw f aywod lx", "n dbc uzf kbnk q s pu xv", "ip xmikk jkagx mj cj bfp set oneug", "jbx qgs nqyzfz ctgy a e rvz", "bnepvy sjn am nqzj", "hloi", "dbto fkgkw", "li vzfcaq zoc", "bep" }, 8)]
    [DataRow(new[] { "z" }, 1)]
    [DataRow(new[] { "ab cd ef gh ij", "k l m n o p q", "rs tu" }, 7)]
    [DataRow(new[] { "ue mufzwr zel", "brk g ppkqf yeswty mphrw mattkl du rdxun dgbvfe", "fjds aww bzpej zavdo fnjip" }, 9)]
    [DataRow(new[] { "go", "stop now please", "ok" }, 3)]
    public void MostWordsFound_GivenArrayOfSentences_ReturnsMaxWordCount(string[] sentences, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MostWordsFound(sentences);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}