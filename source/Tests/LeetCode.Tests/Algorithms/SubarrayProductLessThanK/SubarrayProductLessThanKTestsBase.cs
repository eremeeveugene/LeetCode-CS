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

using LeetCode.Algorithms.SubarrayProductLessThanK;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.SubarrayProductLessThanK;

public abstract class SubarrayProductLessThanKTestsBase<T> where T : ISubarrayProductLessThanK, new()
{
    [TestMethod]
    [DataRow("[10,5,2,6]", 100, 8)]
    [DataRow("[1,2,3]", 0, 0)]
    [DataRow("[1,1,1]", 2, 6)]
    public void NumSubarrayProductLessThanK_GivenArrayAndThreshold_ReturnsCount(string numsJsonArray, int k,
        int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.NumSubarrayProductLessThanK(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}