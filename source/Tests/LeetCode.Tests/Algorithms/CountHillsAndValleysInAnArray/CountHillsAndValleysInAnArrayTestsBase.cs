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

using LeetCode.Algorithms.CountHillsAndValleysInAnArray;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.CountHillsAndValleysInAnArray;

public abstract class CountHillsAndValleysInAnArrayTestsBase<T> where T : ICountHillsAndValleysInAnArray, new()
{
    [TestMethod]
    [DataRow("[2,4,1,1,6,5]", 3)]
    [DataRow("[6,6,5,5,4,1]", 0)]
    public void CountHillValley_WithArrayContainingHillsAndValleys_ReturnsTotalHillValleyCount(string numsJson,
        int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.CountHillValley(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}