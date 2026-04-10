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

using LeetCode.Algorithms.MaximumAscendingSubarraySum;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MaximumAscendingSubarraySum;

public abstract class MaximumAscendingSubarraySumTestsBase<T> where T : IMaximumAscendingSubarraySum, new()
{
    [TestMethod]
    [DataRow("[10,20,30,5,10,50]", 65)]
    [DataRow("[10,20,30,40,50]", 150)]
    [DataRow("[12,17,15,13,10,11,12]", 33)]
    public void MaxAscendingSum_GivenIntegerArray_ReturnsMaxSumOfAscendingSubarray(string numsJson,
        double expectedResult)
    {
        // Arrange
        var nums = JsonHelper.Parse<int[]>(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.MaxAscendingSum(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}