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

using LeetCode.Algorithms.FindTheLongestSubstringContainingVowelsInEvenCounts;

namespace LeetCode.Tests.Algorithms.FindTheLongestSubstringContainingVowelsInEvenCounts;

public abstract class FindTheLongestSubstringContainingVowelsInEvenCountsTestsBase<T>
    where T : IFindTheLongestSubstringContainingVowelsInEvenCounts, new()
{
    [TestMethod]
    [DataRow("bcbcbc", 6)]
    [DataRow("leetcodeisgreat", 5)]
    [DataRow("eleetminicoworoep", 13)]
    public void FindTheLongestSubstring_GivenString_ReturnsLongestSubstringLength(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindTheLongestSubstring(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}