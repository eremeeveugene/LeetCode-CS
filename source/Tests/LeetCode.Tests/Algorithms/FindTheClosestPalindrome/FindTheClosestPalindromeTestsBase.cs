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

using LeetCode.Algorithms.FindTheClosestPalindrome;

namespace LeetCode.Tests.Algorithms.FindTheClosestPalindrome;

public abstract class FindTheClosestPalindromeTestsBase<T> where T : IFindTheClosestPalindrome, new()
{
    [TestMethod]
    [DataRow("1", "0")]
    [DataRow("11", "9")]
    [DataRow("101", "99")]
    [DataRow("123", "121")]
    [DataRow("1111", "1001")]
    [DataRow("11011", "11111")]
    [DataRow("11579", "11611")]
    [DataRow("12345", "12321")]
    [DataRow("1837722381", "1837667381")]
    [DataRow("1805170081", "1805115081")]
    [DataRow("1000000000000000", "999999999999999")]
    [DataRow("807045053224792883", "807045053350540708")]
    [DataRow("999999999999999999", "1000000000000000001")]
    public void NearestPalindromic_WithVariousNumbers_ReturnsClosestPalindrome(string n, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NearestPalindromic(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}