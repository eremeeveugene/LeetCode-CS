﻿// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.MergeStringsAlternately;

namespace LeetCode.Tests.Algorithms.MergeStringsAlternately;

public abstract class MergeStringsAlternatelyTestsBase<T> where T : IMergeStringsAlternately, new()
{
    [TestMethod]
    [DataRow("abc", "pqr", "apbqcr")]
    [DataRow("ab", "pqrs", "apbqrs")]
    [DataRow("abcd", "pq", "apbqcd")]
    public void MergeAlternately_WithTwoStrings_ReturnsMergedString(string word1, string word2, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MergeAlternately(word1, word2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}