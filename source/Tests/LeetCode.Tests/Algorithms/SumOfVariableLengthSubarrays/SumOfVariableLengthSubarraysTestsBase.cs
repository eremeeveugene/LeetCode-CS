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

using LeetCode.Algorithms.SumOfVariableLengthSubarrays;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.SumOfVariableLengthSubarrays;

public abstract class SumOfVariableLengthSubarraysTestsBase<T> where T : ISumOfVariableLengthSubarrays, new()
{
    [TestMethod]
    [DataRow("[2,3,1]", 11)]
    [DataRow("[3,1,1,2]", 13)]
    public void SubarraySum_WithGivenArray_ReturnsMaximumSum(string numsJson, int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.SubarraySum(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}