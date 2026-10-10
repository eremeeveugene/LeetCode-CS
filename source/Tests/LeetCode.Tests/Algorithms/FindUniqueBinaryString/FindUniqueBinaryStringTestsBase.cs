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

using LeetCode.Algorithms.FindUniqueBinaryString;

namespace LeetCode.Tests.Algorithms.FindUniqueBinaryString;

public abstract class FindUniqueBinaryStringTestsBase<T> where T : IFindUniqueBinaryString, new()
{
    [TestMethod]
    [DataRow(new[] { "01", "10" }, "11")]
    [DataRow(new[] { "00", "01" }, "10")]
    [DataRow(new[] { "111", "011", "001" }, "000")]
    [DataRow(new[] { "0" }, "1")]
    [DataRow(new[] { "1" }, "0")]
    [DataRow(new[] { "00", "11" }, "10")]
    [DataRow(new[] { "01", "11" }, "10")]
    [DataRow(new[] { "10", "00" }, "01")]
    [DataRow(new[] { "000", "001", "010" }, "111")]
    [DataRow(new[] { "101", "110", "011" }, "000")]
    [DataRow(new[] { "111", "110", "101" }, "000")]
    [DataRow(new[] { "0000", "0001", "0010", "0011" }, "1100")]
    [DataRow(new[] { "1111", "1110", "1101", "1011" }, "0010")]
    [DataRow(new[] { "00000", "11111", "01010", "10101", "00110" }, "10111")]
    [DataRow(new[] { "1010", "0101", "1100", "0011" }, "0010")]
    [DataRow(new[] { "01", "00" }, "11")]
    [DataRow(new[] { "10", "11" }, "00")]
    [DataRow(new[] { "001", "010", "100" }, "101")]
    [DataRow(new[] { "011", "101", "110" }, "111")]
    [DataRow(new[] { "0110", "1001", "1111", "0000" }, "1101")]
    [DataRow(new[] { "1000", "0100", "0010", "0001" }, "0000")]
    public void FindDifferentBinaryString_WithUniqueBinaryStrings_ReturnsMissingBinaryString(string[] nums, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindDifferentBinaryString(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}