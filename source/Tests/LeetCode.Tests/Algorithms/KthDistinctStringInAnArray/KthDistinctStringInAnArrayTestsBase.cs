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

using LeetCode.Algorithms.KthDistinctStringInAnArray;

namespace LeetCode.Tests.Algorithms.KthDistinctStringInAnArray;

public abstract class KthDistinctStringInAnArrayTestsBase<T> where T : IKthDistinctStringInAnArray, new()
{
    [TestMethod]
    [DataRow(new[] { "d", "b", "c", "b", "c", "a" }, 2, "a")]
    [DataRow(new[] { "aaa", "aa", "a" }, 1, "aaa")]
    [DataRow(new[] { "a", "b", "a" }, 3, "")]
    [DataRow(new[] { "a" }, 1, "a")]
    [DataRow(new[] { "a" }, 2, "")]
    [DataRow(new[] { "a", "a" }, 1, "")]
    [DataRow(new[] { "a", "b" }, 1, "a")]
    [DataRow(new[] { "a", "b" }, 2, "b")]
    [DataRow(new[] { "a", "b" }, 3, "")]
    [DataRow(new[] { "x", "y", "x", "y" }, 1, "")]
    [DataRow(new[] { "x", "y", "z", "x" }, 2, "z")]
    [DataRow(new[] { "abc", "abd", "abc", "abe" }, 2, "abe")]
    [DataRow(new[] { "d", "b", "c", "b", "c", "a" }, 1, "d")]
    [DataRow(new[] { "d", "b", "c", "b", "c", "a" }, 3, "")]
    [DataRow(new[] { "aa", "a", "aa", "a", "aaa" }, 1, "aaa")]
    [DataRow(new[] { "zz", "yy", "xx", "ww", "vv" }, 5, "vv")]
    [DataRow(new[] { "zz", "yy", "xx", "ww", "vv" }, 6, "")]
    [DataRow(new[] { "hello", "world", "hello", "leet", "code", "leet" }, 2, "code")]
    [DataRow(new[] { "p", "q", "r", "p", "q", "r", "s" }, 1, "s")]
    [DataRow(new[] { "abcde", "abcde", "edcba", "abcde" }, 1, "edcba")]
    public void KthDistinct_GivenArrayAndK_ReturnsKthDistinctStringOrEmpty(string[] arr, int k, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.KthDistinct(arr, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}