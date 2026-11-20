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

using LeetCode.Algorithms.CountConsistentSubarrays1;

namespace LeetCode.Tests.Algorithms.CountConsistentSubarrays1;

public abstract class CountConsistentSubarrays1TestsBase<T> where T : ICountConsistentSubarrays1, new()
{
    [TestMethod]
    [DataRow(new[] { 5, 3, 1, 2 }, 6)]
    [DataRow(new[] { 1, 1, 1 }, 6)]
    [DataRow(new[] { 0 }, 1)]
    [DataRow(new[] { 7 }, 1)]
    [DataRow(new[] { 100 }, 1)]
    [DataRow(new[] { 0, 0 }, 3)]
    [DataRow(new[] { 1, 2 }, 2)]
    [DataRow(new[] { 2, 3 }, 3)]
    [DataRow(new[] { 3, 2 }, 3)]
    [DataRow(new[] { 0, 5 }, 3)]
    [DataRow(new[] { 10, 5 }, 2)]
    [DataRow(new[] { 5, 0, 5 }, 6)]
    [DataRow(new[] { 1, 2, 4 }, 3)]
    [DataRow(new[] { 7, 3, 1 }, 6)]
    [DataRow(new[] { 1, 3, 7 }, 6)]
    [DataRow(new[] { 6, 4, 2 }, 4)]
    [DataRow(new[] { 3, 5, 6 }, 3)]
    [DataRow(new[] { 2, 6, 3 }, 5)]
    [DataRow(new[] { 100, 36, 4 }, 6)]
    [DataRow(new[] { 2, 2, 2, 2 }, 10)]
    [DataRow(new[] { 4, 5, 6, 7 }, 8)]
    [DataRow(new[] { 8, 12, 15, 9 }, 9)]
    [DataRow(new[] { 1, 0, 1, 0 }, 10)]
    [DataRow(new[] { 9, 9, 1, 9 }, 10)]
    [DataRow(new[] { 15, 7, 3, 1, 0 }, 15)]
    public void CountConsistent_WithInputNums_ReturnsConsistentSubarraysCount(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountConsistent(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}