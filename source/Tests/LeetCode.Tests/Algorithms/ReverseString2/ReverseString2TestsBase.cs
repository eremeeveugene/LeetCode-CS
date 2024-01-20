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

using LeetCode.Algorithms.ReverseString2;

namespace LeetCode.Tests.Algorithms.ReverseString2;

public abstract class ReverseString2TestsBase
{
    [TestMethod]
    [DataRow("abcdefg", 2, "bacdfeg")]
    [DataRow("abcd", 2, "bacd")]
    public void ReverseStr_WithStringAndInterval_ReversesEveryKCharacters(string s, int k, string expectedResult)
    {
        // Arrange
        var solution = GetSolution();

        // Act
        var actualResult = solution.ReverseStr(s, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    protected abstract IReverseString2 GetSolution();
}