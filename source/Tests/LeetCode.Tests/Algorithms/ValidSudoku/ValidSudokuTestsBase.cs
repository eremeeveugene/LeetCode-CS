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

using LeetCode.Algorithms.ValidSudoku;

namespace LeetCode.Tests.Algorithms.ValidSudoku;

public abstract class ValidSudokuTestsBase<T> where T : IValidSudoku, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void IsValidSudoku_WithPartiallyFilledBoard_ReturnsTrueIfAllRulesSatisfied(char[][] board,
        bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.IsValidSudoku(board);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return
        [
            new[]
            {
                new[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
                new[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
                new[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
                new[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
                new[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
                new[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                new[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
                new[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
                new[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
            },
            true
        ];

        yield return
        [
            new[]
            {
                new[] { '8', '3', '.', '.', '7', '.', '.', '.', '.' },
                new[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
                new[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
                new[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
                new[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
                new[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                new[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
                new[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
                new[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
            },
            false
        ];

        yield return
        [
            new[]
            {
                new[] { '.', '.', '.', '.', '5', '.', '.', '1', '.' },
                new[] { '.', '4', '.', '3', '.', '.', '.', '.', '.' },
                new[] { '.', '.', '.', '.', '.', '3', '.', '.', '1' },
                new[] { '8', '.', '.', '.', '.', '.', '.', '2', '.' },
                new[] { '.', '.', '2', '.', '7', '.', '.', '.', '.' },
                new[] { '.', '1', '5', '.', '.', '.', '.', '.', '.' },
                new[] { '.', '.', '.', '.', '.', '2', '.', '.', '.' },
                new[] { '.', '2', '.', '9', '.', '.', '.', '.', '.' },
                new[] { '.', '.', '4', '.', '.', '.', '.', '.', '.' }
            },
            false
        ];
    }
}