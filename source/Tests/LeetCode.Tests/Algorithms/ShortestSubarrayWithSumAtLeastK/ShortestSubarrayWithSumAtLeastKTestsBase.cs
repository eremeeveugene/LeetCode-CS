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

using LeetCode.Algorithms.ShortestSubarrayWithSumAtLeastK;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.ShortestSubarrayWithSumAtLeastK;

public abstract class ShortestSubarrayWithSumAtLeastKTestsBase<T> where T : IShortestSubarrayWithSumAtLeastK, new()
{
    [TestMethod]
    [DataRow("[1]", 1, 1)]
    [DataRow("[1,2]", 4, -1)]
    [DataRow("[2,-1,2]", 3, 3)]
    [DataRow("[84,-37,32,40,95]", 167, 3)]
    [DataRow("[-28,81,-20,28,-29]", 89, 3)]
    public void ShortestSubarray_WithGivenArrayAndTargetSum_ReturnsLengthOfShortestValidSubarrayOrMinusOne(
        string numsJson, int k, int expectedResult)
    {
        // Arrange
        var nums = JsonHelper.Parse<int[]>(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.ShortestSubarray(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}