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

using LeetCode.Algorithms.FinalArrayStateAfterKMultiplicationOperations;

namespace LeetCode.Tests.Algorithms.FinalArrayStateAfterKMultiplicationOperations;

public abstract class FinalArrayStateAfterKMultiplicationOperationsTestsBase<T> where T : IFinalArrayStateAfterKMultiplicationOperations, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 1, 3, 5, 6 }, 5, 2, new[] { 8, 4, 6, 5, 6 })]
    [DataRow(new[] { 1, 2 }, 3, 4, new[] { 16, 8 })]
    [DataRow(new[] { 1 }, 1, 1, new[] { 1 })]
    [DataRow(new[] { 1 }, 10, 5, new[] { 9765625 })]
    [DataRow(new[] { 5 }, 3, 2, new[] { 40 })]
    [DataRow(new[] { 1, 1 }, 1, 2, new[] { 2, 1 })]
    [DataRow(new[] { 1, 1 }, 2, 2, new[] { 2, 2 })]
    [DataRow(new[] { 1, 1 }, 3, 2, new[] { 4, 2 })]
    [DataRow(new[] { 3, 2, 1 }, 3, 2, new[] { 3, 4, 4 })]
    [DataRow(new[] { 100, 100, 100 }, 4, 5, new[] { 2500, 500, 500 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 10, 2, new[] { 16, 8, 12, 8, 10 })]
    [DataRow(new[] { 2, 2, 2, 2 }, 6, 3, new[] { 18, 18, 6, 6 })]
    [DataRow(new[] { 7, 3, 9, 3 }, 5, 2, new[] { 14, 12, 9, 12 })]
    [DataRow(new[] { 10, 20, 30 }, 1, 5, new[] { 50, 20, 30 })]
    [DataRow(new[] { 4, 1, 4, 1 }, 4, 3, new[] { 4, 9, 4, 9 })]
    [DataRow(new[] { 1, 100 }, 10, 5, new[] { 15625, 62500 })]
    [DataRow(new[] { 50, 25, 12, 6 }, 8, 2, new[] { 50, 50, 96, 96 })]
    [DataRow(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 }, 9, 4, new[] { 9, 32, 28, 24, 20, 16, 12, 8, 16 })]
    [DataRow(new[] { 6, 6, 6, 1 }, 7, 5, new[] { 150, 30, 30, 125 })]
    [DataRow(new[] { 2, 4, 6, 8, 10 }, 10, 3, new[] { 54, 36, 54, 72, 30 })]
    public void GetFinalState_WithArrayKAndMultiplier_ReturnsTransformedArray(int[] nums, int k, int multiplier, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.GetFinalState(nums, k, multiplier);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}