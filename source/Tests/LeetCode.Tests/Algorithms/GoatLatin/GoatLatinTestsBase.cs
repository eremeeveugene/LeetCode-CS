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
    [DataRow(
        "The quick brown fox jumped over the lazy dog",
        "heTmaa uickqmaaa rownbmaaaa oxfmaaaaa umpedjmaaaaaa overmaaaaaaa hetmaaaaaaaa azylmaaaaaaaaa ogdmaaaaaaaaaa")]
    [DataRow("a", "amaa")]
    [DataRow("b", "bmaa")]
    [DataRow("A", "Amaa")]
    [DataRow("Z", "Zmaa")]
    [DataRow("I", "Imaa")]
    [DataRow("apple", "applemaa")]
    [DataRow("Banana", "ananaBmaa")]
    [DataRow("a b", "amaa bmaaa")]
    [DataRow("b a", "bmaa amaaa")]
    [DataRow("Eat Ice Out", "Eatmaa Icemaaa Outmaaaa")]
    [DataRow("hello world", "ellohmaa orldwmaaa")]
    [DataRow("AEIOU", "AEIOUmaa")]
    [DataRow("xyz", "yzxmaa")]
    [DataRow("The quick brown fox", "heTmaa uickqmaaa rownbmaaaa oxfmaaaaa")]
    [DataRow("one two three four five six seven eight nine ten", "onemaa wotmaaa hreetmaaaa ourfmaaaaa ivefmaaaaaa ixsmaaaaaaa evensmaaaaaaaa eightmaaaaaaaaa inenmaaaaaaaaaa entmaaaaaaaaaaa")]
    [DataRow("Umbrella Orange Igloo", "Umbrellamaa Orangemaaa Igloomaaaa")]
    [DataRow("sky fly try", "kysmaa lyfmaaa rytmaaaa")]
    [DataRow("Aa Bb Cc Dd", "Aamaa bBmaaa cCmaaaa dDmaaaaa")]
    [DataRow("q w r t y", "qmaa wmaaa rmaaaa tmaaaaa ymaaaaaa")]
    [DataRow("f kVZ tqMnMc", "fmaa VZkmaaa qMnMctmaaaa")]
    [DataRow("OzZU xICGr b Duy", "OzZUmaa ICGrxmaaa bmaaaa uyDmaaaaa")]
    [DataRow("kJlpo l liG xGRJl YAVH YLw", "Jlpokmaa lmaaa iGlmaaaa GRJlxmaaaaa AVHYmaaaaaa LwYmaaaaaaa")]
    [DataRow("a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a a", "amaa amaaa amaaaa amaaaaa amaaaaaa amaaaaaaa amaaaaaaaa amaaaaaaaaa amaaaaaaaaaa amaaaaaaaaaaa amaaaaaaaaaaaa amaaaaaaaaaaaaa amaaaaaaaaaaaaaa amaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa amaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa")]
    [DataRow("bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb", "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbmaa")]
    public void ToGoatLatin_WithSentenceContainingWords_ReturnsConvertedGoatLatinSentence(string sentence, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ToGoatLatin(sentence);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}