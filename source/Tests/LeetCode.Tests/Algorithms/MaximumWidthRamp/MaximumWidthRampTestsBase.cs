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

using LeetCode.Algorithms.MaximumWidthRamp;

namespace LeetCode.Tests.Algorithms.MaximumWidthRamp;

public abstract class MaximumWidthRampTestsBase<T> where T : IMaximumWidthRamp, new()
{
    [TestMethod]
    [DataRow(new[] { 6, 0, 8, 2, 1, 5 }, 4)]
    [DataRow(new[] { 9, 8, 1, 0, 1, 9, 4, 0, 4, 1 }, 7)]
    [DataRow(new[] { 29, 28, 28, 26, 25, 24, 9, 23, 21, 9, 18, 17, 14, 12, 3, 11, 10, 8, 8, 10, 22, 6, 5, 20, 5, 2, 1, 1, 1, 0 }, 17)]
    [DataRow(new[] { 1 }, 0)]
    [DataRow(new[] { 1, 2 }, 1)]
    [DataRow(new[] { 2, 1 }, 0)]
    [DataRow(new[] { 1, 1 }, 1)]
    [DataRow(new[] { 0, 0 }, 1)]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, 0)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 4)]
    [DataRow(new[] { 3, 3, 3 }, 2)]
    [DataRow(new[] { 0, 1 }, 1)]
    [DataRow(new[] { 1, 0, 2 }, 2)]
    [DataRow(new[] { 2, 1, 0, 3 }, 3)]
    [DataRow(new[] { 5, 5, 5, 5, 5 }, 4)]
    [DataRow(new[] { 100000, 0 }, 0)]
    [DataRow(new[] { 0, 100000 }, 1)]
    [DataRow(new[] { 10, 1, 11, 5, 20 }, 4)]
    public void MaxWidthRamp_WithArrayOfIntegers_ReturnsMaxWidth(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxWidthRamp(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}