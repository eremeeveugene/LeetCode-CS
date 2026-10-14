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

using LeetCode.Algorithms.MinimumCostToHireKWorkers;

namespace LeetCode.Tests.Algorithms.MinimumCostToHireKWorkers;

public abstract class MinimumCostToHireKWorkersTestsBase<T> where T : IMinimumCostToHireKWorkers, new()
{
    [TestMethod]
    [DataRow(new[] { 1 }, new[] { 1 }, 1, 1d)]
    [DataRow(new[] { 10, 20, 5 }, new[] { 70, 50, 30 }, 2, 105d)]
    [DataRow(new[] { 3, 1, 10, 10, 1 }, new[] { 4, 8, 2, 2, 7 }, 3, 30.66667)]
    [DataRow(new[] { 3, 5, 8, 10, 9, 5, 1, 2, 4, 1 }, new[] { 8, 8, 6, 9, 5, 6, 8, 7, 5, 8 }, 3, 21.25)]
    [DataRow(new[] { 5, 7, 4, 2, 6, 5, 10, 9, 4, 2 }, new[] { 10, 10, 3, 7, 3, 7, 6, 2, 6, 4 }, 3, 14.25)]
    [DataRow(new[] { 11, 13, 16 }, new[] { 32, 41, 20 }, 1, 20.0d)]
    [DataRow(new[] { 9, 16, 5 }, new[] { 16, 59, 36 }, 2, 92.1875d)]
    [DataRow(new[] { 13, 13, 1 }, new[] { 29, 60, 6 }, 3, 162.0d)]
    [DataRow(new[] { 10, 3, 2, 15 }, new[] { 13, 19, 12, 46 }, 2, 31.666666666666664d)]
    [DataRow(new[] { 19, 16, 16, 2 }, new[] { 51, 19, 46, 55 }, 3, 146.625d)]
    [DataRow(new[] { 3, 19, 15, 8, 19 }, new[] { 31, 35, 58, 13, 58 }, 1, 13.0d)]
    [DataRow(new[] { 1, 2, 11, 13, 14 }, new[] { 23, 5, 50, 58, 33 }, 4, 181.81818181818184d)]
    [DataRow(new[] { 20, 15, 10, 18, 1, 14 }, new[] { 44, 15, 52, 40, 40, 38 }, 3, 117.77777777777779d)]
    [DataRow(new[] { 17, 1, 5, 9, 8, 16 }, new[] { 49, 22, 25, 24, 51, 53 }, 5, 350.625d)]
    [DataRow(new[] { 11, 16, 11, 1, 20, 12, 8 }, new[] { 32, 19, 22, 42, 52, 58, 14 }, 4, 133.8181818181818d)]
    [DataRow(new[] { 19, 13, 11, 5, 11, 4, 11, 11 }, new[] { 48, 60, 50, 40, 50, 34, 47, 18 }, 3, 150.0d)]
    [DataRow(new[] { 13, 19, 1, 4, 5, 15, 6, 7 }, new[] { 50, 53, 36, 43, 53, 35, 29, 32 }, 6, 537.5d)]
    [DataRow(new[] { 8, 18, 17, 4, 17, 15, 19, 6, 11 }, new[] { 37, 56, 53, 46, 43, 16, 36, 27, 19 }, 5, 243.1764705882353d)]
    [DataRow(new[] { 9, 12, 6, 2, 15, 19, 7, 4, 3, 9 }, new[] { 22, 59, 49, 6, 43, 53, 17, 60, 59, 23 }, 7, 358.9166666666667d)]
    [DataRow(new[] { 11, 6, 20, 2, 12, 14, 8, 14, 6, 12 }, new[] { 59, 42, 29, 34, 23, 44, 38, 43, 35, 50 }, 10, 1785.0d)]
    public void MincostToHireWorkers_GivenQualityAndWageArraysAndK_ReturnsMinimumCostWithPrecision(
        int[] quality,
        int[] wage,
        int k,
        double expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MincostToHireWorkers(quality, wage, k);

        // Assert
        Assert.AreEqual(Math.Round(expectedResult, 2), Math.Round(actualResult, 2));
    }
}