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

using LeetCode.Algorithms.ContinuousSubarraySum;

namespace LeetCode.Tests.Algorithms.ContinuousSubarraySum;

public abstract class ContinuousSubarraySumTestsBase<T> where T : IContinuousSubarraySum, new()
{
    [TestMethod]
    [DataRow(new[] { 23, 2, 4, 6, 7 }, 6, true)]
    [DataRow(new[] { 23, 2, 6, 4, 7 }, 6, true)]
    [DataRow(new[] { 23, 2, 6, 4, 7 }, 13, false)]
    [DataRow(new[] { 5, 0, 0, 0 }, 3, true)]
    [DataRow(new[] { 0, 0 }, 1, true)]
    [DataRow(new[] { 0 }, 1, false)]
    [DataRow(new[] { 1, 0 }, 2, false)]
    [DataRow(new[] { 1, 2 }, 3, true)]
    [DataRow(new[] { 1, 2 }, 4, false)]
    [DataRow(new[] { 1, 1 }, 2, true)]
    [DataRow(new[] { 5, 2, 4 }, 5, false)]
    [DataRow(new[] { 5, 2, 4 }, 7, true)]
    [DataRow(new[] { 1, 2, 12 }, 6, false)]
    [DataRow(new[] { 23, 2, 4, 6, 6 }, 7, true)]
    [DataRow(new[] { 1, 3 }, 1, true)]
    [DataRow(new[] { 2, 4, 3 }, 6, true)]
    [DataRow(new[] { 6, 1 }, 6, false)]
    [DataRow(new[] { 0, 1, 0 }, 1, true)]
    [DataRow(new[] { 1, 5 }, 5, false)]
    [DataRow(new[] { 100, 200 }, 7, false)]
    [DataRow(new[] { 7, 7 }, 7, true)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 9, true)]
    [DataRow(new[] { 1000000000, 1000000000 }, 1000000000, true)]
    public void CheckSubarraySum_GivenArrayAndK_ReturnsIfSubarraySumIsMultipleOfK(int[] nums, int k, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CheckSubarraySum(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}