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

using LeetCode.Algorithms.MaximumNumberOfOperationsToMoveOnesToTheEnd;

namespace LeetCode.Tests.Algorithms.MaximumNumberOfOperationsToMoveOnesToTheEnd;

public abstract class MaximumNumberOfOperationsToMoveOnesToTheEndTestsBase<T> where T : IMaximumNumberOfOperationsToMoveOnesToTheEnd, new()
{
    [TestMethod]
    [DataRow("1001101", 4)]
    [DataRow("00111", 0)]
    [DataRow("1100", 2)]
    [DataRow("1", 0)]
    [DataRow("0", 0)]
    [DataRow("11111", 0)]
    [DataRow("00000", 0)]
    [DataRow("10", 1)]
    [DataRow("01", 0)]
    [DataRow("101010", 6)]
    [DataRow("010101", 3)]
    [DataRow("1000000001", 1)]
    [DataRow("111000", 3)]
    [DataRow("000111", 0)]
    [DataRow("1010101010", 15)]
    [DataRow("100100100", 6)]
    [DataRow("11011", 2)]
    [DataRow("0110", 2)]
    [DataRow("10001", 1)]
    [DataRow("1111100000", 5)]
    [DataRow("0000011111", 0)]
    [DataRow("1001", 1)]
    [DataRow("10111", 1)]
    [DataRow("11101", 3)]
    [DataRow("1000", 1)]
    [DataRow("0001", 0)]
    public void MaxOperations_WithBinaryStringContainingZerosAndOnes_ReturnsTotalNumberOfValidMoves(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxOperations(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}