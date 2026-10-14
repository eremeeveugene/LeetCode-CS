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

using LeetCode.Algorithms.MostCommonWord;

namespace LeetCode.Tests.Algorithms.MostCommonWord;

public abstract class MostCommonWordTestsBase<T> where T : IMostCommonWord, new()
{
    [TestMethod]
    [DataRow("Bob hit a ball, the hit BALL flew far after it was hit.", new[] { "hit" }, "ball")]
    [DataRow("a.", new string[] { }, "a")]
    [DataRow("a, a, a, a, b,b,b,c, c", new[] { "a" }, "b")]
    [DataRow("a", new string[] { }, "a")]
    [DataRow("Hit hit HIT bob", new string[] { }, "hit")]
    [DataRow("Hit hit HIT bob", new[] { "hit" }, "bob")]
    [DataRow("a b c b c c", new string[] { }, "c")]
    [DataRow("a b c b c c", new[] { "c" }, "b")]
    [DataRow("a b c b c c", new[] { "c", "b" }, "a")]
    [DataRow("Bob. hIt, baLl", new[] { "bob", "hit" }, "ball")]
    [DataRow("x!y?x;y'x", new string[] { }, "x")]
    [DataRow("abc abd abc abd abd", new[] { "abd" }, "abc")]
    [DataRow("One two two three three three", new string[] { }, "three")]
    [DataRow("One two two three three three", new[] { "three" }, "two")]
    [DataRow("One two two three three three", new[] { "three", "two" }, "one")]
    [DataRow("a,b,c,d,e,f,g,a", new string[] { }, "a")]
    [DataRow("Z z Z y y", new[] { "z" }, "y")]
    [DataRow("it's a dog dog", new string[] { }, "dog")]
    [DataRow("hello   world   world", new[] { "hello" }, "world")]
    [DataRow("a;a;a;b;b", new[] { "a" }, "b")]
    public void MostCommonWord_WithParagraphAndBannedWords_ReturnsMostFrequentNonBannedWord(string paragraph, string[] banned, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MostCommonWord(paragraph, banned);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}