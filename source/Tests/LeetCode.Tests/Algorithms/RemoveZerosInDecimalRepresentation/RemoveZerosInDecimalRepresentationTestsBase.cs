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

using LeetCode.Algorithms.RemoveZerosInDecimalRepresentation;

namespace LeetCode.Tests.Algorithms.RemoveZerosInDecimalRepresentation;

public abstract class RemoveZerosInDecimalRepresentationTestsBase<T> where T : IRemoveZerosInDecimalRepresentation, new()
{
    [TestMethod]
    [DataRow(1L, 1L)]
    [DataRow(1020030L, 123L)]
    [DataRow(10L, 1L)]
    [DataRow(100L, 1L)]
    [DataRow(101L, 11L)]
    [DataRow(1001L, 11L)]
    [DataRow(1000000000000000L, 1L)]
    [DataRow(999999999999999L, 999999999999999L)]
    [DataRow(100000000000001L, 11L)]
    [DataRow(909090909090909L, 99999999L)]
    [DataRow(120L, 12L)]
    [DataRow(1203L, 123L)]
    [DataRow(500L, 5L)]
    [DataRow(5050505L, 5555L)]
    [DataRow(987654321L, 987654321L)]
    [DataRow(1000000007L, 17L)]
    [DataRow(12030040L, 1234L)]
    [DataRow(1000000000000L, 1L)]
    [DataRow(700000000000007L, 77L)]
    [DataRow(9L, 9L)]
    public void RemoveZeros_WithInputNumber_RemovesAllZerosFromNumber(long n, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RemoveZeros(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}