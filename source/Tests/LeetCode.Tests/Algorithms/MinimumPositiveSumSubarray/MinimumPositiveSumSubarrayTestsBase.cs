// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.MinimumPositiveSumSubarray;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MinimumPositiveSumSubarray;

public abstract class MinimumPositiveSumSubarrayTestsBase<T> where T : IMinimumPositiveSumSubarray, new()
{
    [TestMethod]
    [DataRow("[3, -2, 1, 4]", 2, 3, 1)]
    [DataRow("[-2, 2, -3, 1]", 2, 3, -1)]
    [DataRow("[1, 2, 3, 4]", 2, 4, 3)]
    public void MinimumSumSubarray_WithLengthInRangeAndPositiveSum_ReturnsMinimumSumOrMinusOne(string numsJson, int l,
        int r, int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.MinimumSumSubarray(nums, l, r);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}