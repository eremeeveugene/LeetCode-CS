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