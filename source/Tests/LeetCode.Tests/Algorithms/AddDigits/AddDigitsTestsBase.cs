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

using LeetCode.Algorithms.AddDigits;

namespace LeetCode.Tests.Algorithms.AddDigits;

public abstract class AddDigitsTestsBase<T> where T : IAddDigits, new()
{
    [TestMethod]
    [DataRow(0, 0)]
    [DataRow(38, 2)]
    [DataRow(1, 1)]
    [DataRow(9, 9)]
    [DataRow(10, 1)]
    [DataRow(11, 2)]
    [DataRow(18, 9)]
    [DataRow(19, 1)]
    [DataRow(29, 2)]
    [DataRow(55, 1)]
    [DataRow(98, 8)]
    [DataRow(99, 9)]
    [DataRow(100, 1)]
    [DataRow(123, 6)]
    [DataRow(456, 6)]
    [DataRow(789, 6)]
    [DataRow(999, 9)]
    [DataRow(1999, 1)]
    [DataRow(12345, 6)]
    [DataRow(65536, 7)]
    [DataRow(987654321, 9)]
    [DataRow(2147483647, 1)]
    public void AddDigits_WithNonNegativeInteger_ReturnsRepeatedDigitSum(int num, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.AddDigits(num);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}