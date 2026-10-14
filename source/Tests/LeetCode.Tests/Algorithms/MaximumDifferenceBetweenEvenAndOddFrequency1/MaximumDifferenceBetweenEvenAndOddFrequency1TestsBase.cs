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

using LeetCode.Algorithms.MaximumDifferenceBetweenEvenAndOddFrequency1;

namespace LeetCode.Tests.Algorithms.MaximumDifferenceBetweenEvenAndOddFrequency1;

public abstract class MaximumDifferenceBetweenEvenAndOddFrequency1TestsBase<T> where T : IMaximumDifferenceBetweenEvenAndOddFrequency1, new()
{
    [TestMethod]
    [DataRow("aaaaabbc", 3)]
    [DataRow("abcabcab", 1)]
    [DataRow("aab", -1)]
    [DataRow("aaabb", 1)]
    [DataRow("aaaabcc", -1)]
    [DataRow("abcc", -1)]
    [DataRow("zzzyy", 1)]
    [DataRow("aaaaaaabbbb", 3)]
    [DataRow("abababacc", 1)]
    [DataRow("mmmmmnnnoo", 3)]
    [DataRow("qqqqqqqqqqqrrrr", 7)]
    [DataRow("abbcccddddeeeee", 3)]
    [DataRow("aaabbbbcc", 1)]
    [DataRow("helloworld", 1)]
    [DataRow("zzzzaaa", -1)]
    [DataRow("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaabb", 97)]
    [DataRow("abb", -1)]
    [DataRow("aabbb", 1)]
    [DataRow("aaabbbbbcc", 3)]
    [DataRow("kkkkkll", 3)]
    [DataRow("pqqrrr", 1)]
    [DataRow("zzzzzzzyyyyxx", 5)]
    [DataRow("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaabbc", 95)]
    [DataRow("bbaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", 31)]
    public void MaxDifference_WithGivenString_ReturnMaximumDifferenceBetweenEvenAndOddFrequency(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxDifference(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}