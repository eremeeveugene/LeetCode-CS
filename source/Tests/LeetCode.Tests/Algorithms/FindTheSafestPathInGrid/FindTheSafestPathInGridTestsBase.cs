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

using LeetCode.Algorithms.FindTheSafestPathInGrid;

namespace LeetCode.Tests.Algorithms.FindTheSafestPathInGrid;

public abstract class FindTheSafestPathInGridTestsBase<T> where T : IFindTheSafestPathInGrid, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MaximumSafenessFactor_WithGridInput_ReturnsSafenessFactorForPath(IList<IList<int>> grid, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaximumSafenessFactor(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new IList<int>[] { new[] { 1, 0, 0 }, new[] { 0, 0, 0 }, new[] { 0, 0, 1 } }, 0];

        yield return [new IList<int>[] { new[] { 0, 0, 1 }, new[] { 0, 0, 0 }, new[] { 0, 0, 0 } }, 2];

        yield return [new IList<int>[] { new[] { 0, 0, 0, 1 }, new[] { 0, 0, 0, 0 }, new[] { 0, 0, 0, 0 }, new[] { 1, 0, 0, 0 } }, 2];

        // 1x1 grid with thief - safeness factor is 0 (start == end, and thief is there)
        yield return [new IList<int>[] { new[] { 1 } }, 0];

        // Thief at start (top-left) - safeness factor 0
        yield return [new IList<int>[] { new[] { 1, 0 }, new[] { 0, 0 } }, 0];

        // Thief at end (bottom-right) - safeness factor 0
        yield return [new IList<int>[] { new[] { 0, 0 }, new[] { 0, 1 } }, 0];

        // Thief at top-right - 2x2 grid, best path goes down then right
        yield return [new IList<int>[] { new[] { 0, 1 }, new[] { 0, 0 } }, 1];

        // 5x5 grid with thief at center
        yield return [new IList<int>[] { new[] { 0, 0, 0, 0, 0 }, new[] { 0, 0, 0, 0, 0 }, new[] { 0, 0, 1, 0, 0 }, new[] { 0, 0, 0, 0, 0 }, new[] { 0, 0, 0, 0, 0 } }, 2];

        // 5x5 grid with thief at top-right corner
        yield return [new IList<int>[] { new[] { 0, 0, 0, 0, 1 }, new[] { 0, 0, 0, 0, 0 }, new[] { 0, 0, 0, 0, 0 }, new[] { 0, 0, 0, 0, 0 }, new[] { 0, 0, 0, 0, 0 } }, 4];

        // 5x5 grid with thief at bottom-left corner
        yield return [new IList<int>[] { new[] { 0, 0, 0, 0, 0 }, new[] { 0, 0, 0, 0, 0 }, new[] { 0, 0, 0, 0, 0 }, new[] { 0, 0, 0, 0, 0 }, new[] { 1, 0, 0, 0, 0 } }, 4];

        // 4x4 grid with thief at top-right
        yield return [new IList<int>[] { new[] { 0, 0, 0, 1 }, new[] { 0, 0, 0, 0 }, new[] { 0, 0, 0, 0 }, new[] { 0, 0, 0, 0 } }, 3];

        // 4x4 grid with thieves along anti-diagonal
        yield return [new IList<int>[] { new[] { 0, 1, 0, 0 }, new[] { 0, 0, 1, 0 }, new[] { 0, 0, 0, 1 }, new[] { 0, 0, 0, 0 } }, 1];

        // 3x3 grid with thief in top-middle
        yield return [new IList<int>[] { new[] { 0, 1, 0 }, new[] { 0, 0, 0 }, new[] { 0, 0, 0 } }, 1];

        // 3x3 grid with thief in left-middle
        yield return [new IList<int>[] { new[] { 0, 0, 0 }, new[] { 1, 0, 0 }, new[] { 0, 0, 0 } }, 1];

        // 3x3 grid with thief in right-middle
        yield return [new IList<int>[] { new[] { 0, 0, 0 }, new[] { 0, 0, 1 }, new[] { 0, 0, 0 } }, 1];

        // 3x3 grid with thief in bottom-middle
        yield return [new IList<int>[] { new[] { 0, 0, 0 }, new[] { 0, 0, 0 }, new[] { 0, 1, 0 } }, 1];

        // 3x3 grid with thief at top-left corner only - path goes around
        yield return [new IList<int>[] { new[] { 1, 0, 0 }, new[] { 0, 0, 0 }, new[] { 0, 0, 0 } }, 0];

        // 2x2 grid with thief at bottom-left - best path goes right then down
        yield return [new IList<int>[] { new[] { 0, 0 }, new[] { 1, 0 } }, 1];

        // 4x4 grid with thief at (0,0) - start - safeness 0
        yield return [new IList<int>[] { new[] { 1, 0, 0, 0 }, new[] { 0, 0, 0, 0 }, new[] { 0, 0, 0, 0 }, new[] { 0, 0, 0, 0 } }, 0];

        // 5x5 grid with multiple thieves
        yield return [new IList<int>[] { new[] { 0, 0, 0, 0, 0 }, new[] { 0, 1, 0, 1, 0 }, new[] { 0, 0, 0, 0, 0 }, new[] { 0, 1, 0, 1, 0 }, new[] { 0, 0, 0, 0, 0 } }, 2];
    }
}