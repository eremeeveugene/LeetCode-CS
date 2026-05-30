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

using LeetCode.Algorithms.SlidingPuzzle;

namespace LeetCode.Tests.Algorithms.SlidingPuzzle;

public abstract class SlidingPuzzleTestsBase<T> where T : ISlidingPuzzle, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void SlidingPuzzle_WithBoard_ReturnsMinimumMovesToSolve(int[][] board, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SlidingPuzzle(board);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 2, 3 }, new[] { 4, 0, 5 } }, 1];

        yield return [new[] { new[] { 1, 2, 3 }, new[] { 5, 4, 0 } }, -1];

        yield return [new[] { new[] { 4, 1, 2 }, new[] { 5, 0, 3 } }, 5];
    }
}