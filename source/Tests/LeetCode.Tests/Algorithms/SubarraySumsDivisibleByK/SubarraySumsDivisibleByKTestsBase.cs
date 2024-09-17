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

using LeetCode.Algorithms.SubarraySumsDivisibleByK;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.SubarraySumsDivisibleByK;

public abstract class SubarraySumsDivisibleByKTestsBase<T> where T : ISubarraySumsDivisibleByK, new()
{
    [TestMethod]
    [DataRow("[]", 5, 0)]
    [DataRow("[4,5,0,-2,-3,1]", 5, 7)]
    [DataRow("[5]", 9, 0)]
    [DataRow("[0]", 1, 1)]
    [DataRow("[1]", 1, 1)]
    [DataRow("[-1]", 1, 1)]
    [DataRow("[-5,-10,5]", 5, 6)]
    [DataRow("[0,0,0]", 5, 6)]
    [DataRow("[1,2,3,4,5]", 1, 15)]
    public void SubarraysDivByK_GivenArrayAndDivisor_ReturnsCountOfSubarraysDivisibleByK(string numsJsonArray, int k,
        int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.SubarraysDivByK(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}