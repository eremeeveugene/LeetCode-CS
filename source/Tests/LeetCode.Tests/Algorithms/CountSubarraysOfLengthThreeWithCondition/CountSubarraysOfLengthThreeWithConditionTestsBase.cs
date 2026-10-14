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

using LeetCode.Algorithms.CountSubarraysOfLengthThreeWithCondition;

namespace LeetCode.Tests.Algorithms.CountSubarraysOfLengthThreeWithCondition;

public abstract class CountSubarraysOfLengthThreeWithConditionTestsBase<T> where T : ICountSubarraysOfLengthThreeWithCondition, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 1, 4, 1 }, 1)]
    [DataRow(new[] { 1, 1, 1 }, 0)]
    [DataRow(new[] { -1, -4, -1, 4 }, 1)]
    [DataRow(new[] { 0, 0, 0 }, 1)]
    [DataRow(new[] { 1, 4, 1 }, 1)]
    [DataRow(new[] { 2, 8, 2 }, 1)]
    [DataRow(new[] { -1, -4, -1 }, 1)]
    [DataRow(new[] { 1, 2, 3 }, 0)]
    [DataRow(new[] { 0, 0, 0, 0, 0 }, 3)]
    [DataRow(new[] { 3, 12, 3, 12, 3 }, 2)]
    [DataRow(new[] { 100, -100, 100, -100 }, 0)]
    [DataRow(new[] { -100, 100, -100 }, 0)]
    [DataRow(new[] { 1, 2, 1, 4, 1, 4, 1 }, 2)]
    [DataRow(new[] { 1, 1, 1, 1 }, 0)]
    [DataRow(new[] { 5, 10, 0 }, 1)]
    [DataRow(new[] { -3, -6, 0, 6, 3 }, 3)]
    [DataRow(new[] { 0, 2, 1 }, 1)]
    [DataRow(new[] { 1, 6, 2, 12, 4, 24 }, 2)]
    [DataRow(new[] { 0, -6, 2 }, 0)]
    [DataRow(new[] { 4, 3, -5 }, 0)]
    [DataRow(new[] { -4, 0, -5, -6, 4 }, 0)]
    [DataRow(new[] { 1, -5, 2, -6, -4, 4, 3, 5 }, 1)]
    public void CountSubarrays_WithArrayContainingRepeatedElements_ReturnsNumberOfSubarraysLengthThree(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountSubarrays(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}