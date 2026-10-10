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

using LeetCode.Algorithms.MinimumOperationsToMakeTheIntegerZero;

namespace LeetCode.Tests.Algorithms.MinimumOperationsToMakeTheIntegerZero;

public abstract class MinimumOperationsToMakeTheIntegerZeroTestsBase<T> where T : IMinimumOperationsToMakeTheIntegerZero, new()
{
    [TestMethod]
    [DataRow(3, -2, 3)]
    [DataRow(5, 7, -1)]
    [DataRow(1, 1, -1)]
    [DataRow(1, 0, 1)]
    [DataRow(2, 0, 1)]
    [DataRow(8, 0, 1)]
    [DataRow(7, 0, 3)]
    [DataRow(1, -1, 1)]
    [DataRow(4, 2, 1)]
    [DataRow(9, 3, 2)]
    [DataRow(100, -5, 4)]
    [DataRow(100, 5, 4)]
    [DataRow(16, 1, 3)]
    [DataRow(10, -10, 3)]
    [DataRow(1000000000, 0, 13)]
    [DataRow(1000000000, 1, 19)]
    [DataRow(1000000000, -1000000000, 12)]
    [DataRow(1000000000, 1000000000, -1)]
    [DataRow(999999999, -1, 17)]
    [DataRow(1, 1000000000, -1)]
    [DataRow(1000000000, -1, 16)]
    [DataRow(63, 0, 6)]
    [DataRow(31, -1, 1)]
    [DataRow(2, 1, 1)]
    public void MakeTheIntegerZero_WithPositiveAndNegativeInputs_ReturnsMinimumOperationsToReachZero(int num1, int num2, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MakeTheIntegerZero(num1, num2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}