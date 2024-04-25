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

using LeetCode.Algorithms.LongestIdealSubsequence;

namespace LeetCode.Tests.Algorithms.LongestIdealSubsequence;

public abstract class LongestIdealSubsequenceTestsBase<T> where T : ILongestIdealSubsequence, new()
{
    [TestMethod]
    [DataRow("acfgbd", 2, 4)]
    [DataRow("abcd", 3, 4)]
    public void LongestIdealString_GivenStringAndK_ReturnsExpectedLength(string s, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LongestIdealString(s, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}