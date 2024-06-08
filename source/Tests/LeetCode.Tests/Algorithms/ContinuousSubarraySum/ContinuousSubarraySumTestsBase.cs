// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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
    public void CheckSubarraySum_GivenArrayAndK_ReturnsIfSubarraySumIsMultipleOfK(int[] nums, int k,
        bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CheckSubarraySum(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}