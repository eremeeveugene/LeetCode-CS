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
        yield return [new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 0 } }, 0];
        yield return [new[] { new[] { 1, 2, 3 }, new[] { 0, 4, 5 } }, 2];
        yield return [new[] { new[] { 0, 2, 3 }, new[] { 1, 4, 5 } }, 3];
        yield return [new[] { new[] { 4, 1, 3 }, new[] { 0, 2, 5 } }, 4];
        yield return [new[] { new[] { 4, 1, 3 }, new[] { 2, 5, 0 } }, 6];
        yield return [new[] { new[] { 0, 1, 5 }, new[] { 4, 3, 2 } }, 7];
        yield return [new[] { new[] { 4, 2, 3 }, new[] { 5, 1, 0 } }, 8];
        yield return [new[] { new[] { 3, 4, 5 }, new[] { 1, 0, 2 } }, 9];
        yield return [new[] { new[] { 5, 0, 4 }, new[] { 1, 3, 2 } }, 10];
        yield return [new[] { new[] { 1, 0, 5 }, new[] { 3, 2, 4 } }, 12];
        yield return [new[] { new[] { 1, 2, 0 }, new[] { 5, 3, 4 } }, 13];
        yield return [new[] { new[] { 0, 2, 5 }, new[] { 3, 4, 1 } }, 15];
        yield return [new[] { new[] { 1, 4, 5 }, new[] { 2, 0, 3 } }, 17];
        yield return [new[] { new[] { 4, 2, 0 }, new[] { 1, 3, 5 } }, 19];
        yield return [new[] { new[] { 3, 2, 1 }, new[] { 5, 4, 0 } }, 20];
        yield return [new[] { new[] { 4, 5, 0 }, new[] { 1, 2, 3 } }, 21];
        yield return [new[] { new[] { 4, 3, 0 }, new[] { 5, 1, 2 } }, -1];
    }
}