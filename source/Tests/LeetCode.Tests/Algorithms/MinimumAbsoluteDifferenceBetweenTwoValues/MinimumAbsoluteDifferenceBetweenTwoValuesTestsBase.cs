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

using LeetCode.Algorithms.MinimumAbsoluteDifferenceBetweenTwoValues;

namespace LeetCode.Tests.Algorithms.MinimumAbsoluteDifferenceBetweenTwoValues;

public abstract class MinimumAbsoluteDifferenceBetweenTwoValuesTestsBase<T> where T : IMinimumAbsoluteDifferenceBetweenTwoValues, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 0, 0, 2, 0, 1 }, 2)]
    [DataRow(new[] { 1, 0, 1, 0 }, -1)]
    [DataRow(new[] { 0 }, -1)]
    [DataRow(new[] { 1 }, -1)]
    [DataRow(new[] { 2 }, -1)]
    [DataRow(new[] { 1, 2 }, 1)]
    [DataRow(new[] { 2, 1 }, 1)]
    [DataRow(new[] { 2, 2, 2 }, -1)]
    [DataRow(new[] { 0, 0, 0 }, -1)]
    [DataRow(new[] { 0, 0, 0, 1, 0, 0, 0 }, -1)]
    [DataRow(new[] { 1, 0, 0, 0, 2 }, 4)]
    [DataRow(new[] { 2, 0, 0, 0, 1 }, 4)]
    [DataRow(new[] { 1, 0, 2, 0, 1 }, 2)]
    [DataRow(new[] { 2, 0, 1, 0, 2 }, 2)]
    [DataRow(new[] { 1, 1, 1, 2 }, 1)]
    [DataRow(new[] { 2, 0, 0, 1, 1, 1 }, 3)]
    [DataRow(new[] { 0, 1, 0, 0, 0, 0, 0, 2, 0 }, 6)]
    [DataRow(new[] { 1, 0, 0, 2, 0, 0, 0, 0, 1, 2 }, 1)]
    [DataRow(new[] { 2, 0, 0, 0, 0, 1, 0, 0, 2 }, 3)]
    [DataRow(new[] { 0, 0, 1, 0, 0, 0, 2, 0, 1, 0, 0, 2 }, 2)]
    [DataRow(new[] { 1, 2, 1, 2, 1, 2 }, 1)]
    [DataRow(new[] { 0, 2, 0, 0, 1, 0, 0, 0, 0, 0 }, 3)]
    [DataRow(new[] { 2, 0, 1, 0, 0, 2, 0, 0, 0, 1 }, 2)]
    [DataRow(new[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2 }, 19)]
    public void MinAbsoluteDifference_WithNums_ReturnsMinimumAbsoluteDifference(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinAbsoluteDifference(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}