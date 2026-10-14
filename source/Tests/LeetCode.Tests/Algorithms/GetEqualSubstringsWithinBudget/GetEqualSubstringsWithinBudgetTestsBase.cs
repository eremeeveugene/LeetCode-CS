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

using LeetCode.Algorithms.GetEqualSubstringsWithinBudget;

namespace LeetCode.Tests.Algorithms.GetEqualSubstringsWithinBudget;

public abstract class GetEqualSubstringsWithinBudgetTestsBase<T> where T : IGetEqualSubstringsWithinBudget, new()
{
    [TestMethod]
    [DataRow("abcd", "bcdf", 3, 3)]
    [DataRow("abcd", "cdef", 3, 1)]
    [DataRow("abcd", "acde", 0, 1)]
    [DataRow("krrgw", "zjxss", 19, 2)]
    [DataRow("pxezla", "loewbi", 25, 4)]
    [DataRow("ujteygggjwxnfl", "nstsenrzttikoy", 43, 5)]
    [DataRow("a", "a", 0, 1)]
    [DataRow("a", "z", 0, 0)]
    [DataRow("a", "z", 25, 1)]
    [DataRow("a", "z", 24, 0)]
    [DataRow("abc", "abc", 0, 3)]
    [DataRow("abc", "xyz", 1000000, 3)]
    [DataRow("abc", "bcd", 2, 2)]
    [DataRow("abcd", "bcde", 4, 4)]
    [DataRow("aaaa", "zzzz", 50, 2)]
    [DataRow("aaaa", "zzzz", 75, 3)]
    [DataRow("zzzz", "aaaa", 100, 4)]
    [DataRow("abcdef", "abcdeg", 0, 5)]
    [DataRow("abcdef", "fedcba", 6, 3)]
    [DataRow("mmmmmm", "nnnnnn", 3, 3)]
    [DataRow("hello", "world", 10, 2)]
    [DataRow("abababab", "babababa", 3, 3)]
    [DataRow("aaaaabbbbb", "bbbbbaaaaa", 5, 5)]
    public void EqualSubstring_WithSourceTargetAndMaxCost_ReturnsMaxLengthOfTransformableSubstringWithinBudget(
        string s,
        string t,
        int maxCost,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.EqualSubstring(s, t, maxCost);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}