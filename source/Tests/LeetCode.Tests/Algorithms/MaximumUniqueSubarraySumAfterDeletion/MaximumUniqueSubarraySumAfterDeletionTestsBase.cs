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

using LeetCode.Algorithms.MaximumUniqueSubarraySumAfterDeletion;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MaximumUniqueSubarraySumAfterDeletion;

public abstract class MaximumUniqueSubarraySumAfterDeletionTestsBase<T>
    where T : IMaximumUniqueSubarraySumAfterDeletion, new()
{
    [TestMethod]
    [DataRow("[1,2,3,4,5]", 15)]
    [DataRow("[1,1,0,1,1]", 1)]
    [DataRow("[1,2,-1,-2,1,0,-1]", 3)]
    public void MaxSum_WithIntegerArray_ReturnsMaximumSubarraySum(string numsJson, int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.MaxSum(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}