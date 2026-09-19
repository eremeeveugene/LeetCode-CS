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

using LeetCode.Algorithms.EvenNumberOfKnightMoves;

namespace LeetCode.Tests.Algorithms.EvenNumberOfKnightMoves;

public abstract class EvenNumberOfKnightMovesTestsBase<T> where T : IEvenNumberOfKnightMoves, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 1 }, new[] { 2, 2 }, true)]
    [DataRow(new[] { 4, 5 }, new[] { 6, 6 }, false)]
    [DataRow(new[] { 0, 0 }, new[] { 0, 0 }, true)]
    [DataRow(new[] { 7, 7 }, new[] { 7, 7 }, true)]
    [DataRow(new[] { 0, 7 }, new[] { 0, 7 }, true)]
    [DataRow(new[] { 3, 4 }, new[] { 3, 4 }, true)]
    [DataRow(new[] { 0, 0 }, new[] { 7, 7 }, true)]
    [DataRow(new[] { 0, 7 }, new[] { 7, 0 }, true)]
    [DataRow(new[] { 0, 0 }, new[] { 0, 7 }, false)]
    [DataRow(new[] { 0, 0 }, new[] { 7, 0 }, false)]
    [DataRow(new[] { 7, 7 }, new[] { 0, 7 }, false)]
    [DataRow(new[] { 7, 7 }, new[] { 7, 0 }, false)]
    [DataRow(new[] { 3, 3 }, new[] { 1, 2 }, false)]
    [DataRow(new[] { 3, 3 }, new[] { 1, 4 }, false)]
    [DataRow(new[] { 3, 3 }, new[] { 2, 1 }, false)]
    [DataRow(new[] { 3, 3 }, new[] { 2, 5 }, false)]
    [DataRow(new[] { 3, 3 }, new[] { 4, 1 }, false)]
    [DataRow(new[] { 3, 3 }, new[] { 4, 5 }, false)]
    [DataRow(new[] { 3, 3 }, new[] { 5, 2 }, false)]
    [DataRow(new[] { 3, 3 }, new[] { 5, 4 }, false)]
    [DataRow(new[] { 0, 0 }, new[] { 0, 1 }, false)]
    [DataRow(new[] { 0, 0 }, new[] { 0, 2 }, true)]
    [DataRow(new[] { 0, 0 }, new[] { 1, 1 }, true)]
    [DataRow(new[] { 0, 0 }, new[] { 2, 2 }, true)]
    [DataRow(new[] { 0, 0 }, new[] { 4, 0 }, true)]
    [DataRow(new[] { 0, 0 }, new[] { 0, 4 }, true)]
    [DataRow(new[] { 7, 7 }, new[] { 7, 5 }, true)]
    [DataRow(new[] { 7, 7 }, new[] { 5, 7 }, true)]
    [DataRow(new[] { 2, 5 }, new[] { 6, 1 }, true)]
    [DataRow(new[] { 2, 5 }, new[] { 6, 2 }, false)]
    [DataRow(new[] { 1, 6 }, new[] { 6, 1 }, true)]
    [DataRow(new[] { 1, 6 }, new[] { 6, 0 }, false)]
    public void CanReach_WithStartAndTarget_ReturnsWhetherEvenNumberOfMovesIsPossible(int[] start, int[] target, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CanReach(start, target);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}