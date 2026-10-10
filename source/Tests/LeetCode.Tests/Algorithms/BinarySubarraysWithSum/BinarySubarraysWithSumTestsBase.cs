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

using LeetCode.Algorithms.BinarySubarraysWithSum;

namespace LeetCode.Tests.Algorithms.BinarySubarraysWithSum;

public abstract class BinarySubarraysWithSumTestsBase<T> where T : IBinarySubarraysWithSum, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 0, 1, 0, 1 }, 2, 4)]
    [DataRow(new[] { 0, 0, 0, 0, 0 }, 0, 15)]
    [DataRow(new[] { 1 }, 1, 1)]
    [DataRow(new[] { 0 }, 0, 1)]
    [DataRow(new[] { 1 }, 0, 0)]
    [DataRow(new[] { 0 }, 1, 0)]
    [DataRow(new[] { 1, 1 }, 2, 1)]
    [DataRow(new[] { 1, 1 }, 1, 2)]
    [DataRow(new[] { 1, 1 }, 0, 0)]
    [DataRow(new[] { 0, 0 }, 0, 3)]
    [DataRow(new[] { 0, 1, 0 }, 1, 4)]
    [DataRow(new[] { 1, 0, 1 }, 1, 4)]
    [DataRow(new[] { 1, 0, 1 }, 2, 1)]
    [DataRow(new[] { 1, 0, 1 }, 0, 1)]
    [DataRow(new[] { 0, 0, 0, 0 }, 0, 10)]
    [DataRow(new[] { 0, 0, 0, 0 }, 1, 0)]
    [DataRow(new[] { 1, 1, 1, 1 }, 2, 3)]
    [DataRow(new[] { 1, 1, 1, 1 }, 4, 1)]
    [DataRow(new[] { 1, 0, 0, 1 }, 1, 6)]
    [DataRow(new[] { 0, 1, 0, 1, 0 }, 2, 4)]
    [DataRow(new[] { 0, 1, 0, 1, 0 }, 1, 8)]
    [DataRow(new[] { 1, 1, 0, 0, 1 }, 0, 3)]
    [DataRow(new[] { 1, 0, 1, 0, 1, 0, 1 }, 2, 8)]
    [DataRow(new[] { 1, 0, 1, 0, 1, 0, 1 }, 3, 4)]
    [DataRow(new[] { 0, 0, 1, 0, 0 }, 1, 9)]
    [DataRow(new[] { 0, 0, 1, 0, 0 }, 0, 6)]
    [DataRow(new[] { 1, 0, 0, 0, 1 }, 1, 8)]
    public void NumSubarraysWithSum_WithBinaryArrayAndTargetSum_ReturnsCountOfMatchingSubarrays(int[] nums, int goal, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumSubarraysWithSum(nums, goal);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}