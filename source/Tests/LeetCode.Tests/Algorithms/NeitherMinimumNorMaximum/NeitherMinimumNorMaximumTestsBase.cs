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

using LeetCode.Algorithms.NeitherMinimumNorMaximum;

namespace LeetCode.Tests.Algorithms.NeitherMinimumNorMaximum;

public abstract class NeitherMinimumNorMaximumTestsBase<T> where T : INeitherMinimumNorMaximum, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 2, 1, 4 }, 2)]
    [DataRow(new[] { 1, 2 }, -1)]
    [DataRow(new[] { 2, 1, 3 }, 2)]
    [DataRow(new[] { 3, 30, 24 }, 24)]
    [DataRow(new[] { 1 }, -1)]
    [DataRow(new[] { 100 }, -1)]
    [DataRow(new[] { 100, 1 }, -1)]
    [DataRow(new[] { 1, 2, 3 }, 2)]
    [DataRow(new[] { 3, 2, 1 }, 2)]
    [DataRow(new[] { 1, 3, 2 }, 2)]
    [DataRow(new[] { 2, 3, 1 }, 2)]
    [DataRow(new[] { 100, 1, 50 }, 50)]
    [DataRow(new[] { 50, 1, 100 }, 50)]
    [DataRow(new[] { 1, 100, 50 }, 50)]
    [DataRow(new[] { 2, 3, 1, 100, 99, 98 }, 2)]
    [DataRow(new[] { 10, 20, 30, 40 }, 20)]
    [DataRow(new[] { 30, 10, 20, 40, 50, 60 }, 20)]
    [DataRow(new[] { 7, 5, 6 }, 6)]
    [DataRow(new[] { 99, 98, 97, 100 }, 98)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 2)]
    [DataRow(new[] { 3, 1, 2, 5, 4 }, 2)]
    public void FindNonMinOrMax_WithIntArray_ReturnsNonExtremeValue(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindNonMinOrMax(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}