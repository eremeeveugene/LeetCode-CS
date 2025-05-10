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

using LeetCode.Algorithms.CountOfInterestingSubarrays;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.CountOfInterestingSubarrays;

public abstract class CountOfInterestingSubarraysTestsBase<T> where T : ICountOfInterestingSubarrays, new()
{
    [TestMethod]
    [DataRow("[3,2,4]", 2, 1, 3)]
    [DataRow("[3,1,9,6]", 3, 0, 2)]
    [DataRow("[11,12,21,31]", 10, 1, 5)]
    public void CountInterestingSubarrays_WithModuloAndTargetRemainder_ReturnsMatchingSubarrayCount(
        string numsJson, int modulo, int k, long expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.CountInterestingSubarrays(nums, modulo, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}