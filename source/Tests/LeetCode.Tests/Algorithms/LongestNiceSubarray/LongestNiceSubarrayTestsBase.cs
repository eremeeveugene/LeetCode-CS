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

using LeetCode.Algorithms.LongestNiceSubarray;

namespace LeetCode.Tests.Algorithms.LongestNiceSubarray;

public abstract class LongestNiceSubarrayTestsBase<T> where T : ILongestNiceSubarray, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 3, 8, 48, 10 }, 3)]
    [DataRow(new[] { 3, 1, 5, 11, 13 }, 1)]
    [DataRow(new[] { 8, 4, 2, 1 }, 4)]
    [DataRow(new[] { 1 }, 1)]
    [DataRow(new[] { 7 }, 1)]
    [DataRow(new[] { 1, 2 }, 2)]
    [DataRow(new[] { 3, 3 }, 1)]
    [DataRow(new[] { 1, 2, 4, 8, 16, 32 }, 6)]
    [DataRow(new[] { 5, 5, 5, 5 }, 1)]
    [DataRow(new[] { 1, 1, 2, 2 }, 2)]
    [DataRow(new[] { 1000000000 }, 1)]
    [DataRow(new[] { 1000000000, 1, 1000000000 }, 2)]
    [DataRow(new[] { 1, 2, 3, 4, 8 }, 3)]
    [DataRow(new[] { 16, 8, 4, 2, 1, 1 }, 5)]
    [DataRow(new[] { 6, 9, 6, 9, 6 }, 2)]
    [DataRow(new[] { 1, 2, 4, 1, 2, 4, 8 }, 4)]
    [DataRow(new[] { 2, 3, 4, 5, 6, 7, 8 }, 2)]
    [DataRow(new[] { 1, 3, 8, 48, 10, 16 }, 3)]
    [DataRow(new[] { 536870912, 1073741823, 1, 2 }, 2)]
    [DataRow(new[] { 24, 12, 4, 3, 24, 6, 48, 24, 2 }, 3)]
    [DataRow(new[] { 1, 6, 16, 12, 8, 8, 100, 6, 12, 12, 6, 5, 48, 4, 8 }, 3)]
    [DataRow(new[] { 12, 5, 100, 1, 48, 255, 2, 4 }, 2)]
    [DataRow(new[] { 1, 16, 255, 1, 16, 6, 24, 100, 5, 100, 255, 5, 5, 100, 255 }, 3)]
    [DataRow(new[] { 6, 4, 3, 2, 1, 4, 6, 8, 16, 48, 5, 255, 48, 16, 5 }, 3)]
    public void LongestNiceSubarray_WithGivenIntegerArray_ReturnsLengthOfLongestNiceSubarray(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LongestNiceSubarray(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}