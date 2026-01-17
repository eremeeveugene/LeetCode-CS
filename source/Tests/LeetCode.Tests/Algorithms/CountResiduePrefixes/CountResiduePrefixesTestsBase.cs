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

using LeetCode.Algorithms.CountResiduePrefixes;

namespace LeetCode.Tests.Algorithms.CountResiduePrefixes;

public abstract class CountResiduePrefixesTestsBase<T> where T : ICountResiduePrefixes, new()
{
    [TestMethod]
    [DataRow("abc", 2)]
    [DataRow("dd", 1)]
    [DataRow("bob", 2)]
    public void ResiduePrefixes_WithInputString_ReturnsResiduePrefixesCount(string s,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ResiduePrefixes(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}