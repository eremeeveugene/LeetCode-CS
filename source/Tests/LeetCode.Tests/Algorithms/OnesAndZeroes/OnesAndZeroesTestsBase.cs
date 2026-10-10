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
    [DataRow(new[] { "0" }, 1, 0, 1)]
    [DataRow(new[] { "1" }, 0, 1, 1)]
    [DataRow(new[] { "0" }, 0, 1, 0)]
    [DataRow(new[] { "01" }, 1, 1, 1)]
    [DataRow(new[] { "01" }, 0, 1, 0)]
    [DataRow(new[] { "00", "11" }, 2, 2, 2)]
    [DataRow(new[] { "0", "0", "0", "1" }, 2, 1, 3)]
    [DataRow(new[] { "10", "01", "0011" }, 2, 2, 2)]
    [DataRow(new[] { "111", "000", "10" }, 3, 3, 2)]
    [DataRow(new[] { "1", "1", "1" }, 0, 2, 2)]
    [DataRow(new[] { "0", "00", "000" }, 4, 0, 2)]
    [DataRow(new[] { "10", "0001", "111001", "1", "0" }, 3, 4, 3)]
    [DataRow(new[] { "011", "1", "11", "0", "010", "1", "10", "1", "1", "01", "00", "00", "0111", "10" }, 5, 3, 6)]
    [DataRow(new[] { "0", "1" }, 100, 100, 2)]
    [DataRow(new[] { "0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111" }, 100, 100, 2)]
    [DataRow(new[] { "01", "01", "01", "01", "01" }, 100, 100, 5)]
    [DataRow(new[] { "10", "001", "01111", "1", "1011", "01100", "00011", "01010", "011" }, 2, 2, 2)]
    [DataRow(new[] { "1", "01010", "01", "11", "0" }, 2, 8, 4)]
    [DataRow(new[] { "0", "110", "01110", "1", "10100", "0100", "11", "110" }, 4, 8, 5)]
    [DataRow(new[] { "0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111", "0000000000000000000000000000000000000000000000000011111111111111111111111111111111111111111111111111" }, 100, 100, 2)]
    public void FindMaxForm_WithBinaryStringsAndLimits_ReturnsMaxSubsetSizeWithinZeroAndOneConstraints(
        string[] strs,
        int m,
        int n,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindMaxForm(strs, m, n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}