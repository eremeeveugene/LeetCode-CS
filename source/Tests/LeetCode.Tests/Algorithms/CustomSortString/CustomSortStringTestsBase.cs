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

using LeetCode.Algorithms.CustomSortString;

namespace LeetCode.Tests.Algorithms.CustomSortString;

public abstract class CustomSortStringTestsBase<T> where T : ICustomSortString, new()
{
    [TestMethod]
    [DataRow("cba", "abcd", "cbad")]
    [DataRow("bcafg", "abcd", "bcad")]
    [DataRow("abcdefghijklmnopqrstuvwxyz", "abcde", "abcde")]
    [DataRow("xyz", "xyzab", "xyzab")]
    [DataRow("pqrs", "pqrstuvwx", "pqrstuvwx")]
    [DataRow("aeiou", "hello", "eohll")]
    public void CustomSortString_GivenOrderAndString_ReturnsCustomSortedString(string order, string s,
        string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CustomSortString(order, s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}