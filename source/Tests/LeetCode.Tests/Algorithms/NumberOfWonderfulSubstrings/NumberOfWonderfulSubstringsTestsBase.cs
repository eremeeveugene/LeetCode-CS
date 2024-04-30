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

using LeetCode.Algorithms.NumberOfWonderfulSubstrings;

namespace LeetCode.Tests.Algorithms.NumberOfWonderfulSubstrings;

public abstract class NumberOfWonderfulSubstringsTestsBase<T> where T : INumberOfWonderfulSubstrings, new()
{
    [TestMethod]
    [DataRow("aba", 4)]
    [DataRow("aabb", 9)]
    [DataRow("he", 2)]
    public void WonderfulSubstrings_WithDifferentWords_ReturnsExpectedCounts(string word, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.WonderfulSubstrings(word);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}