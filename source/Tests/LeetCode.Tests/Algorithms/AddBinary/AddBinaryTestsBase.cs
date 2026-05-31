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

using LeetCode.Algorithms.AddBinary;

namespace LeetCode.Tests.Algorithms.AddBinary;

public abstract class AddBinaryTestsBase<T> where T : IAddBinary, new()
{
    [TestMethod]
    [DataRow("11", "1", "100")]
    [DataRow("1010", "1011", "10101")]
    [DataRow("110", "10", "1000")]
    [DataRow("0", "0", "0")]
    [DataRow("1", "0", "1")]
    [DataRow("0", "1", "1")]
    [DataRow("1", "1", "10")]
    [DataRow("101", "11", "1000")]
    [DataRow("111", "111", "1110")]
    [DataRow("1111", "1111", "11110")]
    [DataRow("10", "10", "100")]
    [DataRow("1000", "111", "1111")]
    [DataRow("1001", "110", "1111")]
    [DataRow("1111", "1", "10000")]
    [DataRow("100", "100", "1000")]
    [DataRow("1", "111", "1000")]
    [DataRow("10101", "101", "11010")]
    [DataRow("11111", "1", "100000")]
    [DataRow("1", "10", "11")]
    [DataRow("1111111", "1", "10000000")]
    public void AddBinary_WithTwoBinaryStrings_ReturnsBinarySumAsString(string a, string b, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.AddBinary(a, b);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}