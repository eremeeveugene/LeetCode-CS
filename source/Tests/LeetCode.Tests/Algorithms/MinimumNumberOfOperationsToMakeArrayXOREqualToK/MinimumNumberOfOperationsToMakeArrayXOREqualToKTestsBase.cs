// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.MinimumNumberOfOperationsToMakeArrayXOREqualToK;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MinimumNumberOfOperationsToMakeArrayXOREqualToK;

public abstract class MinimumNumberOfOperationsToMakeArrayXOREqualToKTestsBase<T>
    where T : IMinimumNumberOfOperationsToMakeArrayXOREqualToK, new()
{
    [TestMethod]
    [DataRow("[2,1,3,4]", 1, 2)]
    [DataRow("[2,0,2,0]", 0, 0)]
    public void MinOperations_WithNumsArrayAndK_ReturnsMinOperationsCount(string numsJsonArray, int k,
        int expectedResult)
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