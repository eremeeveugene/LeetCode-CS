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

using LeetCode.Algorithms.TwoFurthestHousesWithDifferentColors;

namespace LeetCode.Tests.Algorithms.TwoFurthestHousesWithDifferentColors;

public abstract class TwoFurthestHousesWithDifferentColorsTestsBase<T> where T : ITwoFurthestHousesWithDifferentColors, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 8, 3, 8, 3 }, 4)]
    [DataRow(new[] { 0, 1 }, 1)]
    [DataRow(new[] { 0, 0, 0, 0, 0, 1 }, 5)]
    [DataRow(new[] { 1, 0, 0, 0, 0, 0 }, 5)]
    [DataRow(new[] { 0, 1, 0, 1, 0, 1 }, 5)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, 5)]
    [DataRow(new[] { 1, 1, 1, 1, 1, 2 }, 5)]
    [DataRow(new[] { 2, 1, 1, 1, 1, 1 }, 5)]
    [DataRow(new[] { 1, 2, 1, 2, 1, 2 }, 5)]
    [DataRow(new[] { 0, 1, 2, 3, 4, 5 }, 5)]
    [DataRow(new[] { 0, 0, 0, 1, 0, 0 }, 3)]
    [DataRow(new[] { 1, 2, 3, 2, 1, 2, 3 }, 6)]
    [DataRow(new[] { 1, 1, 1, 1, 2, 1, 1 }, 4)]
    [DataRow(new[] { 3, 3, 3, 3, 3, 3, 5 }, 6)]
    [DataRow(new[] { 5, 3, 3, 3, 3, 3, 3 }, 6)]
    [DataRow(new[] { 1, 2, 1, 1, 1, 1, 1 }, 5)]
    [DataRow(new[] { 0, 0, 1, 0, 0, 0, 0 }, 4)]
    [DataRow(new[] { 1, 2, 3, 4, 3, 2, 1 }, 5)]
    [DataRow(new[] { 1, 1, 1, 2, 1, 1, 1 }, 3)]
    [DataRow(new[] { 0, 1, 2, 1, 0, 1, 2 }, 6)]
    [DataRow(new[] { 1, 2, 1, 2, 1, 2, 1, 2 }, 7)]
    public void MaxDistance_WithColors_ReturnsMaxDistanceBetweenDifferentColorHouses(int[] colors, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxDistance(colors);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}