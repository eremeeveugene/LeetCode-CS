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

using LeetCode.Algorithms.MinimumOperationsToMakeArrayValuesEqualToK;

namespace LeetCode.Tests.Algorithms.MinimumOperationsToMakeArrayValuesEqualToK;

public abstract class MinimumOperationsToMakeArrayValuesEqualToKTestsBase<T>
    where T : IMinimumOperationsToMakeArrayValuesEqualToK, new()
{
    [TestMethod]
    [DataRow(new[] { 5, 2, 5, 4, 5 }, 2, 2)]
    [DataRow(new[] { 2, 1, 2 }, 2, -1)]
    [DataRow(new[] { 9, 7, 5, 3 }, 1, 4)]
    public void MinOperations_WithArrayAndTargetK_ReturnsMinimumStepsOrMinusOne(int[] nums, int k,
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