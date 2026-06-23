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

using LeetCode.Algorithms.NumberOfLaserBeamsInABank;

namespace LeetCode.Tests.Algorithms.NumberOfLaserBeamsInABank;

public abstract class NumberOfLaserBeamsInABankTestsBase<T> where T : INumberOfLaserBeamsInABank, new()
{
    [TestMethod]
    [DataRow(new[] { "011001", "000000", "010100", "001000" }, 8)]
    [DataRow(new[] { "000", "111", "000" }, 0)]
    [DataRow(new[] { "1", "0", "1" }, 1)]
    [DataRow(new[] { "1", "1" }, 1)]
    [DataRow(new[] { "0" }, 0)]
    [DataRow(new[] { "1" }, 0)]
    [DataRow(new[] { "11", "11" }, 4)]
    [DataRow(new[] { "100", "010", "001" }, 2)]
    [DataRow(new[] { "111", "111", "111" }, 18)]
    [DataRow(new[] { "000", "000" }, 0)]
    [DataRow(new[] { "110", "000", "011" }, 4)]
    [DataRow(new[] { "10101", "00000", "10101" }, 9)]
    [DataRow(new[] { "1", "1", "1" }, 2)]
    [DataRow(new[] { "01", "10", "01", "10" }, 3)]
    [DataRow(new[] { "111" }, 0)]
    [DataRow(new[] { "000", "101", "000", "010", "000" }, 2)]
    [DataRow(new[] { "11111", "11111" }, 25)]
    [DataRow(new[] { "10000", "00001" }, 1)]
    [DataRow(new[] { "110011", "000000", "000000", "110011" }, 16)]
    [DataRow(new[] { "0101", "1010", "0101", "1010", "0101" }, 16)]
    [DataRow(new[] { "1001", "0110", "1001" }, 8)]
    [DataRow(new[] { "00100", "00100", "00100" }, 2)]
    [DataRow(new[] { "000", "100", "000", "000", "001", "000" }, 1)]
    public void NumberOfBeams_WithBankFloorPlan_ReturnsTotalLaserBeams(string[] bank, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumberOfBeams(bank);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}