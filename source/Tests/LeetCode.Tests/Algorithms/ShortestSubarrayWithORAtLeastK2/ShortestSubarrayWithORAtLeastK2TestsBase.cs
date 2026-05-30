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

using LeetCode.Algorithms.ShortestSubarrayWithORAtLeastK2;

namespace LeetCode.Tests.Algorithms.ShortestSubarrayWithORAtLeastK2;

public abstract class ShortestSubarrayWithORAtLeastK2TestsBase<T> where T : IShortestSubarrayWithORAtLeastK2, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3 }, 2, 1)]
    [DataRow(new[] { 2, 1, 8 }, 10, 3)]
    [DataRow(new[] { 1, 2 }, 0, 1)]
    public void MinimumSubarrayLength_WithArrayAndTargetSum_ReturnsMinLengthOfSubarray(int[] nums, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimumSubarrayLength(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}