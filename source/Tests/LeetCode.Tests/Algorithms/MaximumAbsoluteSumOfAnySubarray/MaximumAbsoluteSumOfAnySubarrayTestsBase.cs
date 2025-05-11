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

using LeetCode.Algorithms.MaximumAbsoluteSumOfAnySubarray;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MaximumAbsoluteSumOfAnySubarray;

public abstract class MaximumAbsoluteSumOfAnySubarrayTestsBase<T> where T : IMaximumAbsoluteSumOfAnySubarray, new()
{
    [TestMethod]
    [DataRow("[1,-3,2,3,-4]", 5)]
    [DataRow("[2,-5,1,-4,3,-2]", 8)]
    public void MaxAbsoluteSum_GivenArrayOfIntegers_ReturnsMaxAbsoluteSubarraySum(string numsJson,
        double expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.MaxAbsoluteSum(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}