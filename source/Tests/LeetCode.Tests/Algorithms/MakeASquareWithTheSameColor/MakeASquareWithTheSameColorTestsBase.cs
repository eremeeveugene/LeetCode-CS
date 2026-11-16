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

using LeetCode.Algorithms.MakeASquareWithTheSameColor;

namespace LeetCode.Tests.Algorithms.MakeASquareWithTheSameColor;

public abstract class MakeASquareWithTheSameColorTestsBase<T> where T : IMakeASquareWithTheSameColor, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void CanMakeSquare_WithGrid_ReturnsTrueIfSameColorSquareCanBeMade(char[][] grid, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CanMakeSquare(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 'B', 'W', 'B' }, new[] { 'B', 'W', 'W' }, new[] { 'B', 'W', 'B' } }, true];

        yield return [new[] { new[] { 'B', 'W', 'B' }, new[] { 'W', 'B', 'W' }, new[] { 'B', 'W', 'B' } }, false];

        yield return [new[] { new[] { 'B', 'W', 'B' }, new[] { 'B', 'W', 'W' }, new[] { 'B', 'W', 'W' } }, true];

        yield return [new[] { new[] { 'B', 'B', 'B' }, new[] { 'B', 'B', 'B' }, new[] { 'B', 'B', 'B' } }, true];

        yield return [new[] { new[] { 'W', 'W', 'W' }, new[] { 'W', 'W', 'W' }, new[] { 'W', 'W', 'W' } }, true];

        yield return [new[] { new[] { 'W', 'B', 'W' }, new[] { 'B', 'W', 'B' }, new[] { 'W', 'B', 'W' } }, false];

        yield return [new[] { new[] { 'B', 'W', 'B' }, new[] { 'B', 'W', 'B' }, new[] { 'B', 'W', 'B' } }, false];

        yield return [new[] { new[] { 'B', 'B', 'B' }, new[] { 'W', 'W', 'W' }, new[] { 'B', 'B', 'B' } }, false];

        yield return [new[] { new[] { 'W', 'W', 'W' }, new[] { 'B', 'B', 'B' }, new[] { 'W', 'W', 'W' } }, false];

        yield return [new[] { new[] { 'W', 'B', 'W' }, new[] { 'W', 'B', 'W' }, new[] { 'W', 'B', 'W' } }, false];

        yield return [new[] { new[] { 'B', 'B', 'W' }, new[] { 'W', 'W', 'B' }, new[] { 'B', 'B', 'W' } }, false];

        yield return [new[] { new[] { 'B', 'W', 'W' }, new[] { 'W', 'B', 'B' }, new[] { 'B', 'W', 'W' } }, false];

        yield return [new[] { new[] { 'B', 'B', 'W' }, new[] { 'B', 'B', 'W' }, new[] { 'W', 'W', 'W' } }, true];

        yield return [new[] { new[] { 'W', 'W', 'B' }, new[] { 'W', 'W', 'B' }, new[] { 'B', 'B', 'B' } }, true];

        yield return [new[] { new[] { 'B', 'W', 'W' }, new[] { 'W', 'W', 'W' }, new[] { 'W', 'W', 'B' } }, true];

        yield return [new[] { new[] { 'B', 'W', 'B' }, new[] { 'W', 'B', 'W' }, new[] { 'B', 'W', 'W' } }, true];

        yield return [new[] { new[] { 'W', 'B', 'W' }, new[] { 'B', 'W', 'B' }, new[] { 'W', 'B', 'B' } }, true];

        yield return [new[] { new[] { 'B', 'W', 'B' }, new[] { 'W', 'W', 'W' }, new[] { 'B', 'W', 'B' } }, true];

        yield return [new[] { new[] { 'W', 'W', 'B' }, new[] { 'B', 'B', 'W' }, new[] { 'W', 'W', 'B' } }, false];

        yield return [new[] { new[] { 'B', 'B', 'W' }, new[] { 'W', 'W', 'B' }, new[] { 'W', 'W', 'B' } }, true];

        yield return [new[] { new[] { 'W', 'B', 'B' }, new[] { 'B', 'W', 'W' }, new[] { 'W', 'B', 'B' } }, false];

        yield return [new[] { new[] { 'B', 'W', 'W' }, new[] { 'B', 'W', 'W' }, new[] { 'B', 'W', 'W' } }, true];

        yield return [new[] { new[] { 'W', 'B', 'W' }, new[] { 'W', 'B', 'W' }, new[] { 'B', 'B', 'B' } }, true];

        yield return [new[] { new[] { 'B', 'B', 'B' }, new[] { 'W', 'W', 'W' }, new[] { 'W', 'W', 'W' } }, true];
    }
}