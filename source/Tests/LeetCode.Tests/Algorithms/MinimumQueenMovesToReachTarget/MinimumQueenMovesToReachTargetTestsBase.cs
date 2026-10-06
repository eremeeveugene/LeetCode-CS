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

using LeetCode.Algorithms.MinimumQueenMovesToReachTarget;

namespace LeetCode.Tests.Algorithms.MinimumQueenMovesToReachTarget;

public abstract class MinimumQueenMovesToReachTargetTestsBase<T> where T : IMinimumQueenMovesToReachTarget, new()
{
    [TestMethod]
    [DataRow(new[] { 8, 1 }, new[] { 1, 8 }, 1)]
    [DataRow(new[] { 4, 2 }, new[] { 1, 3 }, 2)]
    [DataRow(new[] { 1, 1 }, new[] { 1, 1 }, 0)]
    [DataRow(new[] { 8, 8 }, new[] { 8, 8 }, 0)]
    [DataRow(new[] { 4, 5 }, new[] { 4, 5 }, 0)]
    [DataRow(new[] { 1, 1 }, new[] { 1, 8 }, 1)]
    [DataRow(new[] { 1, 1 }, new[] { 8, 1 }, 1)]
    [DataRow(new[] { 1, 1 }, new[] { 8, 8 }, 1)]
    [DataRow(new[] { 8, 1 }, new[] { 8, 8 }, 1)]
    [DataRow(new[] { 8, 8 }, new[] { 1, 8 }, 1)]
    [DataRow(new[] { 4, 4 }, new[] { 7, 1 }, 1)]
    [DataRow(new[] { 4, 4 }, new[] { 1, 7 }, 1)]
    [DataRow(new[] { 4, 4 }, new[] { 8, 8 }, 1)]
    [DataRow(new[] { 4, 4 }, new[] { 1, 1 }, 1)]
    [DataRow(new[] { 4, 4 }, new[] { 4, 1 }, 1)]
    [DataRow(new[] { 1, 1 }, new[] { 2, 3 }, 2)]
    [DataRow(new[] { 1, 1 }, new[] { 3, 2 }, 2)]
    [DataRow(new[] { 1, 1 }, new[] { 8, 7 }, 2)]
    [DataRow(new[] { 1, 1 }, new[] { 7, 8 }, 2)]
    [DataRow(new[] { 8, 8 }, new[] { 1, 2 }, 2)]
    [DataRow(new[] { 3, 3 }, new[] { 4, 5 }, 2)]
    [DataRow(new[] { 3, 3 }, new[] { 5, 4 }, 2)]
    [DataRow(new[] { 1, 8 }, new[] { 2, 1 }, 2)]
    [DataRow(new[] { 5, 2 }, new[] { 2, 8 }, 2)]
    public void MinQueenMoves_GivenSourceAndTargetCells_ReturnsMinimumNumberOfMoves(int[] source, int[] target, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinQueenMoves(source, target);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}