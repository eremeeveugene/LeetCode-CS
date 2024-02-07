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

using LeetCode.Algorithms.JewelsAndStones;

namespace LeetCode.Tests.Algorithms.JewelsAndStones;

public abstract class JewelsAndStonesTestsBase<T> where T : IJewelsAndStones, new()
{
    [TestMethod]
    [DataRow("aA", "aAAbbbb", 3)]
    [DataRow("z", "ZZ", 0)]
    public void NumJewelsInStones_WithJewelsAndStones_ReturnsCorrectCount(string jewels, string stones,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumJewelsInStones(jewels, stones);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}