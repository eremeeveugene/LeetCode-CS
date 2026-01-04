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

using LeetCode.Algorithms.GoatLatin;

namespace LeetCode.Tests.Algorithms.GoatLatin;

public abstract class GoatLatinTestsBase<T> where T : IGoatLatin, new()
{
    [TestMethod]
    [DataRow("I speak Goat Latin", "Imaa peaksmaaa oatGmaaaa atinLmaaaaa")]
    [DataRow("The quick brown fox jumped over the lazy dog",
        "heTmaa uickqmaaa rownbmaaaa oxfmaaaaa umpedjmaaaaaa overmaaaaaaa hetmaaaaaaaa azylmaaaaaaaaa ogdmaaaaaaaaaa")]
    public void ToGoatLatin_WithSentenceContainingWords_ReturnsConvertedGoatLatinSentence(string sentence,
        string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ToGoatLatin(sentence);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}