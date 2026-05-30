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

using LeetCode.Algorithms.MinimumOperationsToMakeArraySumDivisibleByK;

namespace LeetCode.Tests.Algorithms.MinimumOperationsToMakeArraySumDivisibleByK;

public abstract class MinimumOperationsToMakeArraySumDivisibleByKTestsBase<T>
    where T : IMinimumOperationsToMakeArraySumDivisibleByK, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 9, 7 }, 5, 4)]
    [DataRow(new[] { 4, 1, 3 }, 4, 0)]
    [DataRow(new[] { 3, 2 }, 6, 5)]
    public void MinOperations_WithNumArrayAndTargetValueK_ReturnsMinimumOperationCount(int[] nums, int k,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinOperations(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}