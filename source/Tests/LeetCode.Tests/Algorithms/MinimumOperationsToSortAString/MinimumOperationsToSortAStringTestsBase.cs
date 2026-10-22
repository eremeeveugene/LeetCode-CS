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

using LeetCode.Algorithms.MinimumOperationsToSortAString;

namespace LeetCode.Tests.Algorithms.MinimumOperationsToSortAString;

public abstract class MinimumOperationsToSortAStringTestsBase<T> where T : IMinimumOperationsToSortAString, new()
{
    [TestMethod]
    [DataRow("dog", 1)]
    [DataRow("card", 2)]
    [DataRow("gf", -1)]
    [DataRow("a", 0)]
    [DataRow("abc", 0)]
    [DataRow("aab", 0)]
    [DataRow("zz", 0)]
    [DataRow("aaaa", 0)]
    [DataRow("ba", -1)]
    [DataRow("zy", -1)]
    [DataRow("acb", 1)]
    [DataRow("bac", 1)]
    [DataRow("abdc", 1)]
    [DataRow("cbad", 1)]
    [DataRow("hello", 1)]
    [DataRow("edcbaf", 1)]
    [DataRow("bca", 2)]
    [DataRow("cab", 2)]
    [DataRow("baaa", 2)]
    [DataRow("bbba", 2)]
    [DataRow("dcbaa", 2)]
    [DataRow("ddcba", 2)]
    [DataRow("zabcy", 2)]
    [DataRow("zaba", 2)]
    [DataRow("leetcode", 2)]
    [DataRow("cba", 3)]
    [DataRow("zba", 3)]
    [DataRow("dcba", 3)]
    [DataRow("zyxwa", 3)]
    [DataRow("world", 3)]
    public void MinOperations_WithString_ReturnsMinimumOperationsOrMinusOne(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinOperations(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}