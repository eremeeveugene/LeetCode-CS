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

using LeetCode.Algorithms.OnesAndZeroes;

namespace LeetCode.Tests.Algorithms.OnesAndZeroes;

public abstract class OnesAndZeroesTestsBase<T> where T : IOnesAndZeroes, new()
{
    [TestMethod]
    [DataRow(new[] { "10", "0001", "111001", "1", "0" }, 5, 3, 4)]
    [DataRow(new[] { "10", "0", "1" }, 1, 1, 2)]
    public void FindMaxForm_WithBinaryStringsAndLimits_ReturnsMaxSubsetSizeWithinZeroAndOneConstraints(string[] strs, int m, int n, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindMaxForm(strs, m, n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}