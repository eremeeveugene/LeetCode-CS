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

using LeetCode.Algorithms.AlternatingGroups2;

namespace LeetCode.Tests.Algorithms.AlternatingGroups2;

public abstract class AlternatingGroups2TestsBase<T> where T : IAlternatingGroups2, new()
{
    [TestMethod]
    [DataRow(new[] { 0, 1, 0, 1, 0 }, 3, 3)]
    [DataRow(new[] { 0, 1, 0, 0, 1, 0, 1 }, 6, 2)]
    [DataRow(new[] { 1, 1, 0, 1 }, 4, 0)]
    [DataRow(new[] { 0, 1, 0 }, 3, 1)]
    [DataRow(new[] { 0, 1, 0, 1 }, 3, 4)]
    [DataRow(new[] { 0, 1, 0, 1 }, 4, 4)]
    [DataRow(new[] { 0, 0, 0 }, 3, 0)]
    [DataRow(new[] { 0, 1, 1 }, 3, 1)]
    [DataRow(new[] { 1, 0, 1, 0, 1, 0 }, 3, 6)]
    [DataRow(new[] { 1, 0, 1, 0, 1, 0 }, 6, 6)]
    [DataRow(new[] { 1, 0, 1, 0, 1 }, 5, 1)]
    [DataRow(new[] { 1, 0, 1, 0, 1 }, 4, 2)]
    [DataRow(new[] { 0, 0, 1, 1 }, 3, 0)]
    [DataRow(new[] { 0, 1, 0, 0, 1 }, 3, 3)]
    [DataRow(new[] { 1, 1, 1, 1 }, 3, 0)]
    [DataRow(new[] { 0, 1, 0, 1, 1 }, 3, 3)]
    [DataRow(new[] { 0, 1, 0, 1, 1 }, 4, 2)]
    [DataRow(new[] { 0, 1, 0, 1, 0, 1, 0 }, 7, 1)]
    [DataRow(new[] { 0, 1, 0, 1, 0, 1, 0 }, 3, 5)]
    [DataRow(new[] { 1, 0, 0, 1, 0 }, 3, 3)]
    [DataRow(new[] { 0, 1, 0, 1, 0, 1 }, 5, 6)]
    [DataRow(new[] { 0, 0, 1 }, 3, 1)]
    [DataRow(new[] { 1, 0, 0, 1 }, 4, 0)]
    public void NumberOfAlternatingGroups_WithColorsAndK_ReturnsTheNumberOfAlternatingGroups(int[] colors, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumberOfAlternatingGroups(colors, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}