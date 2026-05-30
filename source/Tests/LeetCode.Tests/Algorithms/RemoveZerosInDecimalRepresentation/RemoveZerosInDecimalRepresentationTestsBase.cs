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
    [DataRow(1, 1)]
    [DataRow(1020030, 123)]
    public void RemoveZeros_WithInputNumber_RemovesAllZerosFromNumber(int n, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RemoveZeros(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}