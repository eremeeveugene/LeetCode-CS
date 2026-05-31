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

using LeetCode.Algorithms.CountOperationsToObtainZero;

namespace LeetCode.Tests.Algorithms.CountOperationsToObtainZero;

public abstract class CountOperationsToObtainZeroTestsBase<T> where T : ICountOperationsToObtainZero, new()
{
    [TestMethod]
    [DataRow(2, 3, 3)]
    [DataRow(10, 10, 1)]
    [DataRow(0, 1, 0)]
    [DataRow(1, 0, 0)]
    [DataRow(1, 1, 1)]
    [DataRow(1, 2, 2)]
    [DataRow(5, 1, 5)]
    [DataRow(1, 5, 5)]
    [DataRow(6, 4, 3)]
    [DataRow(100, 1, 100)]
    [DataRow(1, 100, 100)]
    [DataRow(7, 3, 5)]
    [DataRow(3, 7, 5)]
    [DataRow(15, 5, 3)]
    [DataRow(100, 99, 100)]
    [DataRow(50, 25, 2)]
    [DataRow(12, 8, 3)]
    [DataRow(1000, 999, 1000)]
    public void CountOperations_WithTwoNonNegativeIntegers_ReturnsCountOfSubtractionOperations(int num1, int num2, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountOperations(num1, num2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}