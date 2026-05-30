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

using LeetCode.Algorithms.MinimumDominoRotationsForEqualRow;

namespace LeetCode.Tests.Algorithms.MinimumDominoRotationsForEqualRow;

public abstract class MinimumDominoRotationsForEqualRowTestsBase<T> where T : IMinimumDominoRotationsForEqualRow, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 1, 2, 4, 2, 2 }, new[] { 5, 2, 6, 2, 3, 2 }, 2)]
    [DataRow(new[] { 3, 5, 1, 2, 3 }, new[] { 3, 6, 3, 3, 4 }, -1)]
    [DataRow(new[] { 1, 2, 1, 1, 1, 2, 2, 2 }, new[] { 2, 1, 2, 2, 2, 2, 2, 2 }, 1)]
    public void MinDominoRotations_WithTopAndBottomArrays_ReturnsMinimumRotationsOrMinusOne(int[] tops,
        int[] bottoms, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinDominoRotations(tops, bottoms);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}