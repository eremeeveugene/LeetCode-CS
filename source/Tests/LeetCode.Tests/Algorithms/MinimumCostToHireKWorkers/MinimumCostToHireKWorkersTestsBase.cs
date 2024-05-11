// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.MinimumCostToHireKWorkers;

namespace LeetCode.Tests.Algorithms.MinimumCostToHireKWorkers;

public abstract class MinimumCostToHireKWorkersTestsBase<T> where T : IMinimumCostToHireKWorkers, new()
{
    [TestMethod]
    [DataRow(new[] { 1 }, new[] { 1 }, 1, 1)]
    [DataRow(new[] { 10, 20, 5 }, new[] { 70, 50, 30 }, 2, 105)]
    [DataRow(new[] { 3, 1, 10, 10, 1 }, new[] { 4, 8, 2, 2, 7 }, 3, 30.66667)]
    [DataRow(new[] { 3, 5, 8, 10, 9, 5, 1, 2, 4, 1 }, new[] { 8, 8, 6, 9, 5, 6, 8, 7, 5, 8 }, 3, 21.25)]
    [DataRow(new[] { 5, 7, 4, 2, 6, 5, 10, 9, 4, 2 }, new[] { 10, 10, 3, 7, 3, 7, 6, 2, 6, 4 }, 3, 14.25)]
    public void MincostToHireWorkers_GivenQualityAndWageArraysAndK_ReturnsMinimumCostWithPrecision(int[] quality,
        int[] wage, int k, double expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MincostToHireWorkers(quality, wage, k);

        // Assert
        Assert.AreEqual(Math.Round(expectedResult, 2), Math.Round(actualResult, 2));
    }
}