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

namespace LeetCode.Tests.Algorithms.LongestSquareStreakInAnArray;

public abstract class LongestSquareStreakInAnArrayTestsBase<T> where T : ILongestSquareStreakInAnArray, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 4 }, 2)]
    [DataRow(new[] { 4, 3, 6, 16, 8, 2 }, 3)]
    [DataRow(new[] { 2, 3, 5, 6, 7 }, -1)]
    [DataRow(new[] { 2, 4, 16, 256, 65536 }, 5)]
    [DataRow(new[] { 3, 9, 81, 6561 }, 4)]
    [DataRow(new[] { 5, 25, 625 }, 3)]
    [DataRow(new[] { 5, 25 }, 2)]
    [DataRow(new[] { 5 }, -1)]
    [DataRow(new[] { 2, 3, 4 }, 2)]
    [DataRow(new[] { 4, 16 }, 2)]
    [DataRow(new[] { 100 }, -1)]
    [DataRow(new[] { 100, 10000 }, 2)]
    [DataRow(new[] { 2, 4, 16 }, 3)]
    [DataRow(new[] { 2, 4, 5, 16 }, 3)]
    [DataRow(new[] { 3, 9, 81 }, 3)]
    [DataRow(new[] { 7, 49 }, 2)]
    [DataRow(new[] { 6, 36 }, 2)]
    [DataRow(new[] { 6, 7, 8 }, -1)]
    [DataRow(new[] { 65536 }, -1)]
    [DataRow(new[] { 10, 100, 10000 }, 3)]
    [DataRow(new[] { 11, 121 }, 2)]
    public void LongestSquareStreak_WithGivenArray_ReturnsLengthOfLongestSquareStreakOrMinusOne(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LongestSquareStreak(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}