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

using LeetCode.Algorithms.SumOfAllSubsetXORTotals;

namespace LeetCode.Tests.Algorithms.SumOfAllSubsetXORTotals;

public abstract class SumOfAllSubsetXORTotalsTestsBase<T> where T : ISumOfAllSubsetXORTotals, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 3 }, 6)]
    [DataRow(new[] { 5, 1, 6 }, 28)]
    [DataRow(new[] { 3, 4, 5, 6, 7, 8 }, 480)]
    [DataRow(new[] { 1 }, 1)]
    [DataRow(new[] { 20 }, 20)]
    [DataRow(new[] { 1, 1 }, 2)]
    [DataRow(new[] { 2, 2, 2 }, 8)]
    [DataRow(new[] { 1, 2 }, 6)]
    [DataRow(new[] { 1, 2, 4, 8 }, 120)]
    [DataRow(new[] { 5, 5, 5, 5 }, 40)]
    [DataRow(new[] { 7, 3 }, 14)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 112)]
    [DataRow(new[] { 20, 19, 18, 17 }, 184)]
    [DataRow(new[] { 6, 6, 1 }, 28)]
    [DataRow(new[] { 16, 8, 4, 2, 1 }, 496)]
    [DataRow(new[] { 10, 10, 10, 10, 10, 10 }, 320)]
    [DataRow(new[] { 11, 13, 17, 3, 5, 7, 2, 19 }, 3968)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }, 16252928)]
    [DataRow(new[] { 9, 12, 3 }, 60)]
    [DataRow(new[] { 1, 1, 1, 1, 1, 1, 1 }, 64)]
    public void SubsetXORSum_WithIntegerArray_ReturnsSumOfXORTotalsForAllSubsets(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SubsetXORSum(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}