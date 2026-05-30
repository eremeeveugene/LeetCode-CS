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

using LeetCode.Algorithms.LongestBinarySubsequenceLessThanOrEqualToK;

namespace LeetCode.Tests.Algorithms.LongestBinarySubsequenceLessThanOrEqualToK;

public abstract class LongestBinarySubsequenceLessThanOrEqualToKTestsBase<T> where T : ILongestBinarySubsequenceLessThanOrEqualToK, new()
{
    [TestMethod]
    [DataRow("1001010", 5, 5)]
    [DataRow("00101001", 1, 6)]
    public void LongestSubsequence_WithBinaryStringAndLimitK_ReturnsMaxValidSubsequenceLength(string s, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LongestSubsequence(s, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}