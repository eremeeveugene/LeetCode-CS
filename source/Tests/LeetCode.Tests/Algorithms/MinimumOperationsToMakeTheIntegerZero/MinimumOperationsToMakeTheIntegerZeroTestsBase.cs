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