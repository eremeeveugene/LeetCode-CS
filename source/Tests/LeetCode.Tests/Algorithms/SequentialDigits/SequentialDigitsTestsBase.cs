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

using LeetCode.Algorithms.SequentialDigits;

namespace LeetCode.Tests.Algorithms.SequentialDigits;

public abstract class SequentialDigitsTestsBase<T> where T : ISequentialDigits, new()
{
    [TestMethod]
    [DataRow(100, 300, new[] { 123, 234 })]
    [DataRow(1000, 13000, new[] { 1234, 2345, 3456, 4567, 5678, 6789, 12345 })]
    [DataRow(10, 11, new int[] { })]
    [DataRow(12, 12, new[] { 12 })]
    [DataRow(10, 12, new[] { 12 })]
    [DataRow(89, 89, new[] { 89 })]
    [DataRow(90, 122, new int[] { })]
    [DataRow(12, 89, new[] { 12, 23, 34, 45, 56, 67, 78, 89 })]
    [DataRow(13, 88, new[] { 23, 34, 45, 56, 67, 78 })]
    [DataRow(123456789, 1000000000, new[] { 123456789 })]
    [DataRow(234567891, 1000000000, new int[] { })]
    [DataRow(10, 100, new[] { 12, 23, 34, 45, 56, 67, 78, 89 })]
    [DataRow(58, 124, new[] { 67, 78, 89, 123 })]
    [DataRow(800, 2400, new[] { 1234, 2345 })]
    [DataRow(6789, 6789, new[] { 6789 })]
    [DataRow(6790, 12344, new int[] { })]
    [DataRow(100, 299, new[] { 123, 234 })]
    [DataRow(500, 1300, new[] { 567, 678, 789, 1234 })]
    [DataRow(98, 122, new int[] { })]
    [DataRow(22, 23, new[] { 23 })]
    [DataRow(45678, 456789, new[] { 45678, 56789, 123456, 234567, 345678, 456789 })]
    [DataRow(1234567, 23456789, new[] { 1234567, 2345678, 3456789, 12345678, 23456789 })]
    [DataRow(
        10,
        1000000000,
        new[]
        {
            12,
            23,
            34,
            45,
            56,
            67,
            78,
            89,
            123,
            234,
            345,
            456,
            567,
            678,
            789,
            1234,
            2345,
            3456,
            4567,
            5678,
            6789,
            12345,
            23456,
            34567,
            45678,
            56789,
            123456,
            234567,
            345678,
            456789,
            1234567,
            2345678,
            3456789,
            12345678,
            23456789,
            123456789
        })]
    public void SequentialDigits_WithRange_ReturnsSortedSequentialDigitNumbersInRange(int low, int high, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SequentialDigits(low, high);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}