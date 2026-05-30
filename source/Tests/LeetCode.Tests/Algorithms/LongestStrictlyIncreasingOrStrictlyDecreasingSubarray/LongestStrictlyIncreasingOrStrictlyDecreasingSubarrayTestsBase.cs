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

using LeetCode.Algorithms.LongestStrictlyIncreasingOrStrictlyDecreasingSubarray;

namespace LeetCode.Tests.Algorithms.LongestStrictlyIncreasingOrStrictlyDecreasingSubarray;

public abstract class LongestStrictlyIncreasingOrStrictlyDecreasingSubarrayTestsBase<T>
    where T : ILongestStrictlyIncreasingOrStrictlyDecreasingSubarray, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 4, 3, 3, 2 }, 2)]
    [DataRow(new[] { 3, 3, 3, 3 }, 1)]
    [DataRow(new[] { 3, 2, 1 }, 3)]
    public void LongestMonotonicSubarray_WithGivenNums_ReturnsLengthOfTheLongestMonotonicSubarray(int[] nums,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LongestMonotonicSubarray(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}