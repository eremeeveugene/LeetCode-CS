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

using LeetCode.Algorithms.LongestSquareStreakInAnArray;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.LongestSquareStreakInAnArray;

public abstract class LongestSquareStreakInAnArrayTestsBase<T>
    where T : ILongestSquareStreakInAnArray, new()
{
    [TestMethod]
    [DataRow("[2,4]", 2)]
    [DataRow("[4,3,6,16,8,2]", 3)]
    [DataRow("[2,3,5,6,7]", -1)]
    public void LongestSquareStreak_WithGivenArray_ReturnsLengthOfLongestSquareStreakOrMinusOne(string numsJson,
        int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.LongestSquareStreak(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}