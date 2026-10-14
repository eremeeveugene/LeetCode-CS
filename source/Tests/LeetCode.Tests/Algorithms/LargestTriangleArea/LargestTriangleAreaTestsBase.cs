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

using LeetCode.Algorithms.LargestTriangleArea;

namespace LeetCode.Tests.Algorithms.LargestTriangleArea;

public abstract class LargestTriangleAreaTestsBase<T> where T : ILargestTriangleArea, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void LargestTriangleArea_WithPoints_ReturnsMaximumTriangleArea(int[][] points, double expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LargestTriangleArea(points);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 0, 0 }, new[] { 0, 1 }, new[] { 1, 0 }, new[] { 0, 2 }, new[] { 2, 0 } }, 2.0];

        yield return [new[] { new[] { 1, 0 }, new[] { 0, 0 }, new[] { 0, 1 } }, 0.5];
        yield return [new[] { new[] { 0, 0 }, new[] { 1, 0 }, new[] { 0, 1 } }, 0.5];
        yield return [new[] { new[] { 0, 0 }, new[] { 0, 1 }, new[] { 1, 1 } }, 0.5];
        yield return [new[] { new[] { -50, -50 }, new[] { 50, -50 }, new[] { 0, 50 } }, 5000.0];
        yield return [new[] { new[] { 0, 0 }, new[] { 50, 50 }, new[] { -50, 50 }, new[] { 50, -50 } }, 5000.0];
        yield return [new[] { new[] { 0, 0 }, new[] { 1, 1 }, new[] { 2, 2 }, new[] { 3, 3 }, new[] { 0, 1 } }, 1.5];
        yield return [new[] { new[] { -1, -1 }, new[] { 1, 1 }, new[] { -1, 1 }, new[] { 1, -1 } }, 2.0];
        yield return [new[] { new[] { 0, 0 }, new[] { 4, 0 }, new[] { 0, 3 } }, 6.0];
        yield return [new[] { new[] { 1, 1 }, new[] { 2, 3 }, new[] { 4, 2 }, new[] { 5, 5 } }, 4.0];
        yield return [new[] { new[] { -50, -50 }, new[] { -49, -49 }, new[] { -48, -48 }, new[] { -47, -46 } }, 1.0];
        yield return [new[] { new[] { 0, 0 }, new[] { 10, 0 }, new[] { 5, 1 }, new[] { 5, 10 } }, 50.0];
        yield return [new[] { new[] { 3, 7 }, new[] { -3, 7 }, new[] { 0, -7 } }, 42.0];
        yield return [new[] { new[] { 0, 0 }, new[] { 1, 0 }, new[] { 2, 0 }, new[] { 0, 1 } }, 1.0];
        yield return [new[] { new[] { 50, 50 }, new[] { 49, 50 }, new[] { 50, 49 } }, 0.5];
        yield return [new[] { new[] { 0, 0 }, new[] { 5, 2 }, new[] { 3, 6 }, new[] { 8, 8 }, new[] { -4, 3 } }, 28.5];
        yield return [new[] { new[] { -20, 15 }, new[] { 20, 15 }, new[] { 0, -35 }, new[] { 0, 0 } }, 1000.0];
        yield return [new[] { new[] { 1, 0 }, new[] { 0, 1 }, new[] { -1, 0 }, new[] { 0, -1 } }, 1.0];
        yield return [new[] { new[] { 0, 0 }, new[] { 1, 2 }, new[] { 2, 1 } }, 1.5];

        yield return
        [
            new[] { new[] { -25, -2 }, new[] { 10, 42 }, new[] { -8, -11 }, new[] { -15, 22 }, new[] { 43, -36 }, new[] { 31, -8 } },
            2091.0
        ];
    }
}