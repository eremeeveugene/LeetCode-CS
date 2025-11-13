// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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

public abstract class MaximumNumberOfOperationsToMoveOnesToTheEndTestsBase<T>
    where T : IMaximumNumberOfOperationsToMoveOnesToTheEnd, new()
{
    [TestMethod]
    [DataRow("1001101", 4)]
    [DataRow("00111", 0)]
    public void MaxOperations_WithBinaryStringContainingZerosAndOnes_ReturnsTotalNumberOfValidMoves(string s,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxOperations(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}