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

using LeetCode.Algorithms.ReverseStringPrefix;

namespace LeetCode.Tests.Algorithms.ReverseStringPrefix;

public abstract class ReverseStringPrefixTestsBase<T>
    where T : IReverseStringPrefix, new()
{
    [TestMethod]
    [DataRow("abcd", 2, "bacd")]
    [DataRow("xyz", 3, "zyx")]
    [DataRow("hey", 1, "hey")]
    public void ReversePrefix_WithKCharacters_ReversesFirstKCharactersOnly(string s, int k, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ReversePrefix(s, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}