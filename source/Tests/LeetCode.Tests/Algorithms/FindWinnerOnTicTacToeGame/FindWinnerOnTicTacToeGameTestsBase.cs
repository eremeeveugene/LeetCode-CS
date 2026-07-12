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

using LeetCode.Algorithms.FindWinnerOnTicTacToeGame;

namespace LeetCode.Tests.Algorithms.FindWinnerOnTicTacToeGame;

public abstract class FindWinnerOnTicTacToeGameTestsBase<T> where T : IFindWinnerOnTicTacToeGame, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void Tictactoe_WithMoveSequence_ReturnsGameOutcome(int[][] moves, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.Tictactoe(moves);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 0, 0 }, new[] { 2, 0 }, new[] { 1, 1 }, new[] { 2, 1 }, new[] { 2, 2 } }, "A"];

        yield return [new[] { new[] { 0, 0 }, new[] { 1, 1 }, new[] { 0, 1 }, new[] { 0, 2 }, new[] { 1, 0 }, new[] { 2, 0 } }, "B"];

        yield return
        [
            new[]
            {
                new[] { 0, 0 },
                new[] { 1, 1 },
                new[] { 2, 0 },
                new[] { 1, 0 },
                new[] { 1, 2 },
                new[] { 2, 1 },
                new[] { 0, 1 },
                new[] { 0, 2 },
                new[] { 2, 2 }
            },
            "Draw"
        ];
    }
}