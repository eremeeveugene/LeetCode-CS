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