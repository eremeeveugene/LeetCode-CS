// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.MaximumSubstringsWithDistinctStart;

namespace LeetCode.Tests.Algorithms.MaximumSubstringsWithDistinctStart;

public abstract class MaximumSumOfDistinctSubarraysWithLengthKTestsBase<T>
    where T : IMaximumSubstringsWithDistinctStart, new()
{
    [TestMethod]
    [DataRow("aaaa", 1)]
    [DataRow("abab", 2)]
    [DataRow("abcd", 4)]
    public void MaxDistinct_WithStringContainingLowercaseLetters_ReturnsMaxSubstringsWithDistinctStartCharacters(
        string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxDistinct(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}