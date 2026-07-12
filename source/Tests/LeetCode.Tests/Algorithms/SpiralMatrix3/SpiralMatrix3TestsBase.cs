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

using LeetCode.Algorithms.SpiralMatrix3;

namespace LeetCode.Tests.Algorithms.SpiralMatrix3;

public abstract class SpiralMatrix3TestsBase<T> where T : ISpiralMatrix3, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void SpiralMatrixIII_WithGridSizeAndStartPosition_ReturnsCoordinatesVisitedInClockwiseSpiralOrder(
        int rows,
        int cols,
        int rStart,
        int cStart,
        int[][] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SpiralMatrixIII(rows, cols, rStart, cStart);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [1, 4, 0, 0, new[] { new[] { 0, 0 }, new[] { 0, 1 }, new[] { 0, 2 }, new[] { 0, 3 } }];

        yield return
        [
            5, 6, 1, 4,
            new[]
            {
                new[] { 1, 4 },
                new[] { 1, 5 },
                new[] { 2, 5 },
                new[] { 2, 4 },
                new[] { 2, 3 },
                new[] { 1, 3 },
                new[] { 0, 3 },
                new[] { 0, 4 },
                new[] { 0, 5 },
                new[] { 3, 5 },
                new[] { 3, 4 },
                new[] { 3, 3 },
                new[] { 3, 2 },
                new[] { 2, 2 },
                new[] { 1, 2 },
                new[] { 0, 2 },
                new[] { 4, 5 },
                new[] { 4, 4 },
                new[] { 4, 3 },
                new[] { 4, 2 },
                new[] { 4, 1 },
                new[] { 3, 1 },
                new[] { 2, 1 },
                new[] { 1, 1 },
                new[] { 0, 1 },
                new[] { 4, 0 },
                new[] { 3, 0 },
                new[] { 2, 0 },
                new[] { 1, 0 },
                new[] { 0, 0 }
            }
        ];
    }
}