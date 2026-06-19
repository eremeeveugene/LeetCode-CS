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

using LeetCode.Algorithms.FindTheHighestAltitude;

namespace LeetCode.Tests.Algorithms.FindTheHighestAltitude;

public abstract class FindTheHighestAltitudeTestsBase<T> where T : IFindTheHighestAltitude, new()
{
    [TestMethod]
    [DataRow(new[] { -5, 1, 5, 0, -7 }, 1)]
    [DataRow(new[] { -4, -3, -2, -1, 4, 3, 2 }, 0)]
    [DataRow(new[] { 1, 2, 3 }, 6)]
    [DataRow(new[] { 0 }, 0)]
    [DataRow(new[] { -1 }, 0)]
    [DataRow(new[] { 5 }, 5)]
    [DataRow(new[] { 1, 1, 1, 1, 1 }, 5)]
    [DataRow(new[] { -1, -1, -1 }, 0)]
    [DataRow(new[] { 10, -5, 10 }, 15)]
    [DataRow(new[] { 3, -2, 5, -1 }, 6)]
    [DataRow(new[] { -100, 100 }, 0)]
    [DataRow(new[] { 100, -100 }, 100)]
    [DataRow(new[] { 2, 2, -5, 2 }, 4)]
    [DataRow(new[] { 7 }, 7)]
    [DataRow(new[] { -7 }, 0)]
    [DataRow(new[] { 1, -1, 1, -1, 1 }, 1)]
    [DataRow(new[] { 4, -1, 2, 1 }, 6)]
    [DataRow(new[] { -2, 3, -1, 4 }, 4)]
    [DataRow(new[] { 50, -20, -40, 30 }, 50)]
    [DataRow(new[] { 0, 0, 0 }, 0)]
    [DataRow(new[] { 6, -3, 4, -2, 8 }, 13)]
    [DataRow(new[] { -10, 5, 5, 5 }, 5)]
    [DataRow(new[] { 20, -5, -5, -5, -5 }, 20)]
    [DataRow(new[] { 1, 2, -10, 3, 4 }, 3)]
    public void LargestAltitude_WithNetGainsArray_ReturnsHighestAltitude(int[] gains, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LargestAltitude(gains);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}