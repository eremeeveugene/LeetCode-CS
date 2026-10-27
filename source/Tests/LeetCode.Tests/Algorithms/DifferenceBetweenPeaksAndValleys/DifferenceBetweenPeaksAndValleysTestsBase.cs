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

using LeetCode.Algorithms.DifferenceBetweenPeaksAndValleys;

namespace LeetCode.Tests.Algorithms.DifferenceBetweenPeaksAndValleys;

public abstract class DifferenceBetweenPeaksAndValleysTestsBase<T> where T : IDifferenceBetweenPeaksAndValleys, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 5, 2, 4, 1, 3, 0 }, 9)]
    [DataRow(new[] { -5, -6, -1, -2, 5, 3, 2 }, 12)]
    [DataRow(new[] { 6, 5, 2, 5, 5, 3, 6 }, -5)]
    [DataRow(new[] { 1, 2, 3 }, 0)]
    [DataRow(new[] { 3, 2, 1 }, 0)]
    [DataRow(new[] { 1, 3, 1 }, 3)]
    [DataRow(new[] { 3, 1, 3 }, -1)]
    [DataRow(new[] { 5, 5, 5 }, 0)]
    [DataRow(new[] { -100, 100, -100 }, 100)]
    [DataRow(new[] { 100, -100, 100 }, 100)]
    [DataRow(new[] { 1, 2, 2, 1 }, 0)]
    [DataRow(new[] { 0, 0, 0, 0 }, 0)]
    [DataRow(new[] { 1, 3, 2, 4, 3 }, 5)]
    [DataRow(new[] { 2, 1, 2, 1, 2 }, 0)]
    [DataRow(new[] { -1, -3, -1 }, 3)]
    [DataRow(new[] { -3, -1, -3 }, -1)]
    [DataRow(new[] { 0, 10, 0, 10, 0 }, 20)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 4, 3, 2, 1 }, 5)]
    [DataRow(new[] { 5, 4, 3, 2, 1, 2, 3, 4, 5 }, -1)]
    [DataRow(new[] { 7, 7, 8, 7, 7 }, 8)]
    [DataRow(new[] { 4, 2, 2, 4 }, 0)]
    [DataRow(new[] { -50, 0, 50, 0, -50, 0, 50 }, 100)]
    [DataRow(new[] { 10, -10, 10, -10, 10, -10 }, 40)]
    [DataRow(new[] { 0, -1, 0 }, 1)]
    [DataRow(new[] { 1, 0, 1, 0 }, 1)]
    public void PeakValleyDifference_WithNums_ReturnsDifference(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.PeakValleyDifference(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}