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

using LeetCode.Algorithms.MinimumOperationsToMakeArraySumDivisibleByK;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MinimumOperationsToMakeArraySumDivisibleByK;

public abstract class MinimumOperationsToMakeArraySumDivisibleByKTestsBase<T>
    where T : IMinimumOperationsToMakeArraySumDivisibleByK, new()
{
    [TestMethod]
    [DataRow("[3,9,7]", 5, 4)]
    [DataRow("[4,1,3]", 4, 0)]
    [DataRow("[3,2]", 6, 5)]
    public void MinOperations_WithNumArrayAndTargetValueK_ReturnsMinimumOperationCount(string numsJson, int k,
        int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.MinOperations(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}