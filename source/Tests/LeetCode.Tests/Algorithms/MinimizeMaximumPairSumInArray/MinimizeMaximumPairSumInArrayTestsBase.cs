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

using LeetCode.Algorithms.MinimizeMaximumPairSumInArray;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MinimizeMaximumPairSumInArray;

public abstract class MinimizeMaximumPairSumInArrayTestsBase<T>
    where T : IMinimizeMaximumPairSumInArray, new()
{
    [TestMethod]
    [DataRow("[3,5,2,3]", 7)]
    [DataRow("[3,5,4,2,4,6]", 8)]
    public void MinPairSum_WithNumsArray_ReturnsMinimizedMaximumPairSum(string numsJson, int expectedResult)
    {
        // Arrange
        var nums = JsonHelper.Parse<int[]>(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.MinPairSum(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}