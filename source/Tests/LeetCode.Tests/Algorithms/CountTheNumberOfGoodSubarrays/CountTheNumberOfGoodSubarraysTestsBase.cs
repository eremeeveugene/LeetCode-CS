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

using LeetCode.Algorithms.CountTheNumberOfGoodSubarrays;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.CountTheNumberOfGoodSubarrays;

public abstract class CountTheNumberOfGoodSubarraysTestsBase<T> where T : ICountTheNumberOfGoodSubarrays, new()
{
    [TestMethod]
    [DataRow("[1,1,1,1,1]", 10, 1)]
    [DataRow("[3,1,4,3,2,2,4]", 2, 4)]
    public void CountGood_WithIntegerArrayAndK_ReturnsNumberOfGoodPairs(string numsJson, int k,
        long expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.CountGood(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}