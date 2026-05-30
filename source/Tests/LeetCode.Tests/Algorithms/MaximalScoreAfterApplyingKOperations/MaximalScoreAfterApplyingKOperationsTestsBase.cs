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

using LeetCode.Algorithms.MaximalScoreAfterApplyingKOperations;

namespace LeetCode.Tests.Algorithms.MaximalScoreAfterApplyingKOperations;

public abstract class MaximalScoreAfterApplyingKOperationsTestsBase<T>
    where T : IMaximalScoreAfterApplyingKOperations, new()
{
    [TestMethod]
    [DataRow(new[] { 10, 10, 10, 10, 10 }, 5, 50L)]
    [DataRow(new[] { 1, 10, 3, 3, 3 }, 3, 17L)]
    public void MaxKelements_WithArrayAndKOperations_ReturnsMaximumScore(int[] nums, int k, long expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxKelements(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}