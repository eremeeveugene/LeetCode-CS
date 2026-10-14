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

using LeetCode.Algorithms.MinimumPairRemovalToSortArray1;

namespace LeetCode.Tests.Algorithms.MinimumPairRemovalToSortArray1;

public abstract class MinimumPairRemovalToSortArray1TestsBase<T> where T : IMinimumPairRemovalToSortArray1, new()
{
    [TestMethod]
    [DataRow(new[] { 5, 2, 3, 1 }, 2)]
    [DataRow(new[] { 1, 2, 2 }, 0)]
    [DataRow(new[] { 2, 2, -1, 3, -2, 2, 1, 1, 1, 0, -1 }, 9)]
    [DataRow(new[] { 1 }, 0)]
    [DataRow(new[] { -1000 }, 0)]
    [DataRow(new[] { 1, 1 }, 0)]
    [DataRow(new[] { 2, 1 }, 1)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 0)]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, 4)]
    [DataRow(new[] { -1, -2, -3 }, 2)]
    [DataRow(new[] { 1000, -1000 }, 1)]
    [DataRow(new[] { 0, 0, 0, 0 }, 0)]
    [DataRow(new[] { 3, 1, 2 }, 1)]
    [DataRow(new[] { 1, 3, 2, 4 }, 3)]
    [DataRow(new[] { -5, 10, -5, 10 }, 2)]
    [DataRow(new[] { 1000, 1000, -1000, -1000 }, 3)]
    [DataRow(new[] { 4, 3, 2, 1, 0, -1 }, 4)]
    [DataRow(new[] { 1, -1, 1, -1, 1, -1, 1, -1 }, 6)]
    [DataRow(new[] { -10, 6, -9, -5, -3 }, 4)]
    [DataRow(new[] { -9, -6 }, 0)]
    [DataRow(new[] { 1, -3, -7, 0, 4, 1, -2, 2, -2, 1, -3, -4, 1 }, 12)]
    [DataRow(new[] { 0, -3, -1, 6, 3, -3, 8, 4, 3, 5, -8, 4, 8, 1 }, 10)]
    [DataRow(new[] { 8, 0, 10, 4, 2, -8, 5, -10, -4 }, 8)]
    [DataRow(new[] { 7, -5, 9, -10 }, 3)]
    [DataRow(new[] { 6, 5, -6, -7, -7, 2 }, 5)]
    [DataRow(new[] { -8, 4 }, 0)]
    [DataRow(new[] { 7, -1, 2, 6, -3, -5, 7, 6, 1, -8, -3, -1, -1 }, 12)]
    [DataRow(new[] { -664, 689, 282, -349, -208, 853, -25, -312, 782, -96, 601, -849, 550, 858, 715, 630, -443, -29, -709, -764, 385, 8, -202, -230, -969, 720, -468, 900, 981, 517, -811, -412, -869, -916, -78, 830, -879, 934, -478, -676, 685, 23, 157, -15, 786, 999, 20, -912, 24, -874 }, 49)]
    [DataRow(new[] { 1000, 960, 920, 880, 840, 800, 760, 720, 680, 640, 600, 560, 520, 480, 440, 400, 360, 320, 280, 240, 200, 160, 120, 80, 40, 0, -40, -80, -120, -160, -200, -240, -280, -320, -360, -400, -440, -480, -520, -560, -600, -640, -680, -720, -760, -800, -840, -880, -920, -960 }, 49)]
    public void MinimumPairRemoval_WithUnsortedArray_ReturnsMinimumNumberOfOperationsNeededToSort(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinimumPairRemoval(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}