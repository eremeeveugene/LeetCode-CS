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

using LeetCode.Algorithms.MinimumOperationsToMakeArrayValuesEqualToK;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MinimumOperationsToMakeArrayValuesEqualToK;

public abstract class MinimumOperationsToMakeArrayValuesEqualToKTestsBase<T>
    where T : IMinimumOperationsToMakeArrayValuesEqualToK, new()
{
    [TestMethod]
    [DataRow("[5,2,5,4,5]", 2, 2)]
    [DataRow("[2,1,2]", 2, -1)]
    [DataRow("[9,7,5,3]", 1, 4)]
    public void MinOperations_WithArrayAndTargetK_ReturnsMinimumStepsOrMinusOne(string numsJson, int k,
        int expectedResult)
    {
        // Arrange
        var nums = JsonHelper.Parse<int[]>(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.MinOperations(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}