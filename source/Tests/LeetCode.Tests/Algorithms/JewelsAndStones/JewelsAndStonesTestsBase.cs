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

using LeetCode.Algorithms.JewelsAndStones;

namespace LeetCode.Tests.Algorithms.JewelsAndStones;

public abstract class JewelsAndStonesTestsBase<T> where T : IJewelsAndStones, new()
{
    [TestMethod]
    [DataRow("aA", "aAAbbbb", 3)]
    [DataRow("z", "ZZ", 0)]
    [DataRow("a", "a", 1)]
    [DataRow("a", "b", 0)]
    [DataRow("A", "a", 0)]
    [DataRow("abc", "cba", 3)]
    [DataRow("abc", "ddd", 0)]
    [DataRow("aA", "aAaAaA", 6)]
    [DataRow("xyz", "xxyyzzxyzxyz", 12)]
    [DataRow("b", "bbbbbbbbbb", 10)]
    [DataRow("Zz", "zZzZ", 4)]
    [DataRow("abcdefghijklmnopqrstuvwxyz", "ABCDEFGHIJKLMNOPQRSTUVWXYZ", 0)]
    [DataRow("CJXDZGLmlUEONRgVtjfczPouxYKHAaqQbBThwSvynIdikWFMpr", "fDPrAJfTquWoGsbeKXgzgsyebRanndEyTzAeKOmXRrvftvaAWh", 45)]
    [DataRow("CJXDZGLmlUEONRgVtjfczPoux", "lVWLCDaQOihNAbNFrlKIxmYKRCjScJROYvIwLXURAtCryPfxZZ", 29)]
    [DataRow("ab", "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", 50)]
    [DataRow("q", "abcdefghijklmnopqrstuvwxyzq", 2)]
    [DataRow("Mm", "MississippiMmm", 4)]
    [DataRow("ABC", "abcABCabcABC", 6)]
    [DataRow("e", "e", 1)]
    [DataRow("Pp", "pPpPpPpPpP", 10)]
    [DataRow("hello", "world", 2)]
    public void NumJewelsInStones_WithJewelsAndStones_ReturnsJewelCount(string jewels, string stones, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumJewelsInStones(jewels, stones);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}