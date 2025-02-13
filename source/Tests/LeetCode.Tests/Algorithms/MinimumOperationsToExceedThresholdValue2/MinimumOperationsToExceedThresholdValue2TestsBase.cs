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

using LeetCode.Algorithms.MinimumOperationsToExceedThresholdValue2;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MinimumOperationsToExceedThresholdValue2;

public abstract class MinimumOperationsToExceedThresholdValue2TestsBase<T>
    where T : IMinimumOperationsToExceedThresholdValue2, new()
{
    [TestMethod]
    [DataRow("[2,11,10,1,3]", 10, 2)]
    [DataRow("[1,1,2,4,9]", 20, 4)]
    public void MinOperations_WithTargetSum_ReturnsMinimumOperations(string numsJsonArray, int k, int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.MinOperations(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}