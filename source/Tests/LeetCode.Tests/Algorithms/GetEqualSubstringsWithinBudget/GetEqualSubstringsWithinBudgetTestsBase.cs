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

using LeetCode.Algorithms.GetEqualSubstringsWithinBudget;

namespace LeetCode.Tests.Algorithms.GetEqualSubstringsWithinBudget;

public abstract class GetEqualSubstringsWithinBudgetTestsBase<T> where T : IGetEqualSubstringsWithinBudget, new()
{
    [TestMethod]
    [DataRow("abcd", "bcdf", 3, 3)]
    [DataRow("abcd", "cdef", 3, 1)]
    [DataRow("abcd", "acde", 0, 1)]
    [DataRow("abcd", "cdef", 3, 1)]
    [DataRow("krrgw", "zjxss", 19, 2)]
    [DataRow("pxezla", "loewbi", 25, 4)]
    [DataRow("ujteygggjwxnfl", "nstsenrzttikoy", 43, 5)]
    public void EqualSubstring_WithStringsAndMaxCost_ReturnsExpectedResult(string s, string t, int maxCost,
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