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

using LeetCode.Algorithms.UniqueLength3PalindromicSubsequences;

namespace LeetCode.Tests.Algorithms.UniqueLength3PalindromicSubsequences;

public abstract class UniqueLength3PalindromicSubsequencesTestsBase<T>
    where T : IUniqueLength3PalindromicSubsequences, new()
{
    [TestMethod]
    [DataRow("adc", 0)]
    [DataRow("aabca", 3)]
    [DataRow("bbcbaba", 4)]
    public void CountPalindromicSubsequence_WithStringInput_ReturnsNumberOfUniquePalindromes(string s,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountPalindromicSubsequence(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}