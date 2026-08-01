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
    [DataRow(new[] { 1, 2 }, 100, -1)]
    [DataRow(new[] { 1, 2 }, 3, 2)]
    [DataRow(new[] { 1, 4, 2 }, 5, 2)]
    [DataRow(new[] { 4, 1, 2 }, 7, 3)]
    [DataRow(new[] { 2, 4, 1 }, 7, 3)]
    [DataRow(new[] { 3, 3, 3 }, 10, -1)]
    [DataRow(new[] { 1, 2, 4 }, 100, -1)]
    [DataRow(new[] { 5 }, 0, 1)]
    [DataRow(new[] { 0 }, 0, 1)]
    [DataRow(new[] { 100, 200 }, 0, 1)]
    [DataRow(new[] { 8 }, 8, 1)]
    [DataRow(new[] { 8 }, 9, -1)]
    [DataRow(new[] { 4, 4, 4 }, 4, 1)]
    [DataRow(new[] { 1, 1, 1 }, 2, -1)]
    [DataRow(new[] { 3, 5 }, 7, 2)]
    [DataRow(new[] { 3, 5 }, 3, 1)]
    [DataRow(new[] { 1, 4 }, 5, 2)]
    [DataRow(new[] { 1, 4 }, 4, 1)]
    [DataRow(new[] { 2, 2, 2, 2 }, 2, 1)]
    [DataRow(new[] { 1, 1, 2 }, 3, 2)]
    [DataRow(new[] { 5, 5 }, 5, 1)]
    [DataRow(new[] { 1, 2, 4, 8 }, 15, 4)]
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