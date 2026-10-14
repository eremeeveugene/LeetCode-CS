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

using LeetCode.Algorithms.MakeTheStringGreat;

namespace LeetCode.Tests.Algorithms.MakeTheStringGreat;

public abstract class MakeTheStringGreatTestsBase<T> where T : IMakeTheStringGreat, new()
{
    [TestMethod]
    [DataRow("", "")]
    [DataRow("s", "s")]
    [DataRow("leEeetcode", "leetcode")]
    [DataRow("abBAcC", "")]
    [DataRow("djrDdRJD", "")]
    [DataRow("aA", "")]
    [DataRow("Aa", "")]
    [DataRow("aa", "aa")]
    [DataRow("AA", "AA")]
    [DataRow("abc", "abc")]
    [DataRow("aAbB", "")]
    [DataRow("abBA", "")]
    [DataRow("AbBa", "")]
    [DataRow("aBbA", "")]
    [DataRow("xXyYzZ", "")]
    [DataRow("Pp", "")]
    [DataRow("pPpP", "")]
    [DataRow("aaAA", "")]
    [DataRow("aAaA", "")]
    [DataRow("AaBbCc", "")]
    [DataRow("cCaAbB", "")]
    [DataRow("abcCBA", "")]
    [DataRow("abcCBd", "ad")]
    [DataRow("ZzzZ", "")]
    [DataRow("qwErREWq", "qwEEWq")]
    [DataRow("mMnNmM", "")]
    [DataRow("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "")]
    [DataRow("bAABbbBaAaBAAb", "bABAAb")]
    [DataRow("baaaBbAabB", "baaa")]
    [DataRow("aaaAAabbAa", "aabb")]
    [DataRow("BabBAaaBaB", "BaaBaB")]
    public void MakeGood_WhenGivenStrings_RemovesAdjacentOppositeCasePairs(string s, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MakeGood(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}