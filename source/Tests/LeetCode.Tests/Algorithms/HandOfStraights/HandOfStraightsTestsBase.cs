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

using LeetCode.Algorithms.HandOfStraights;

namespace LeetCode.Tests.Algorithms.HandOfStraights;

public abstract class HandOfStraightsTestsBase<T> where T : IHandOfStraights, new()
{
    [TestMethod]
    [DataRow(new int[] { }, 1, true)]
    [DataRow(new[] { 1 }, 1, true)]
    [DataRow(new[] { 1, 2, 3, 6, 2, 3, 4, 7, 8 }, 3, true)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 4, false)]
    [DataRow(new[] { 8, 10, 12 }, 3, false)]
    [DataRow(new[] { 8, 9, 10 }, 3, true)]
    [DataRow(new[] { 8, 7, 4, 3, 2, 6, 3, 2, 1 }, 3, true)]
    [DataRow(new[] { 1, 2, 3 }, 1, true)]
    [DataRow(new[] { 1, 1, 1, 1 }, 4, false)]
    [DataRow(new[] { 1, 1, 1, 1 }, 3, false)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 3, true)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 5, true)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 4, false)]
    [DataRow(new[] { 3, 3, 2, 2, 1, 1 }, 3, true)]
    [DataRow(new[] { 1, 2, 3, 5, 6, 7, 9, 10, 11 }, 3, true)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, 2, true)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, 3, true)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, 6, true)]
    [DataRow(new[] { 1, 2, 3, 3, 4, 5 }, 3, true)]
    [DataRow(new[] { 1, 1, 2, 2, 3, 3 }, 3, true)]
    [DataRow(new[] { 1, 1, 2, 2, 3, 4 }, 3, false)]
    [DataRow(new[] { 1000000000, 999999999, 999999998 }, 3, true)]
    [DataRow(new[] { 0, 0, 1, 1, 2, 2, 3, 3 }, 4, true)]
    [DataRow(new[] { 5, 5, 5, 5 }, 1, true)]
    [DataRow(new[] { 1, 3, 5, 7 }, 2, false)]
    [DataRow(new[] { 2, 1 }, 2, true)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7 }, 7, true)]
    [DataRow(new[] { 1, 2, 3, 7, 8, 9, 4, 5, 6, 10, 11, 12 }, 4, true)]
    [DataRow(new[] { 1, 2, 2, 3, 3, 4 }, 3, true)]
    public void IsNStraightHand_WithCardHandAndGroupSize_ReturnsWhetherHandCanBeDividedIntoConsecutiveGroups(
        int[] hand,
        int groupSize,
        bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.IsNStraightHand(hand, groupSize);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}