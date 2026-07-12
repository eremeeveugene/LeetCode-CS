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

using LeetCode.Algorithms.MinimumScoreOfAPathBetweenTwoCities;

namespace LeetCode.Tests.Algorithms.MinimumScoreOfAPathBetweenTwoCities;

public abstract class MinimumScoreOfAPathBetweenTwoCitiesTestsBase<T> where T : IMinimumScoreOfAPathBetweenTwoCities, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MinScore_WithCitiesAndRoads_ReturnsMinimumPossiblePathScore(int n, int[][] roads, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinScore(n, roads);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [4, new[] { new[] { 1, 2, 9 }, new[] { 2, 3, 6 }, new[] { 2, 4, 5 }, new[] { 1, 4, 7 } }, 5];

        yield return [4, new[] { new[] { 1, 2, 2 }, new[] { 1, 3, 4 }, new[] { 3, 4, 7 } }, 2];

        yield return [2, new[] { new[] { 1, 2, 10 } }, 10];

        yield return [2, new[] { new[] { 1, 2, 1 } }, 1];

        yield return [3, new[] { new[] { 1, 2, 5 }, new[] { 2, 3, 3 }, new[] { 1, 3, 1 } }, 1];

        yield return [5, new[] { new[] { 1, 2, 4 }, new[] { 2, 3, 2 }, new[] { 3, 4, 1 }, new[] { 4, 5, 6 } }, 1];

        yield return [5, new[] { new[] { 1, 2, 10 }, new[] { 2, 3, 10 }, new[] { 3, 4, 10 }, new[] { 4, 5, 10 } }, 10];

        yield return [3, new[] { new[] { 1, 2, 100 }, new[] { 1, 3, 1 } }, 1];

        yield return
        [
            6, new[] { new[] { 1, 2, 5 }, new[] { 1, 3, 3 }, new[] { 2, 4, 2 }, new[] { 3, 4, 1 }, new[] { 4, 5, 6 }, new[] { 5, 6, 7 } }, 1
        ];

        yield return [6, new[] { new[] { 1, 2, 5 }, new[] { 2, 4, 3 }, new[] { 1, 4, 10 }, new[] { 5, 6, 1 } }, 3];

        yield return [7, new[] { new[] { 1, 2, 4 }, new[] { 2, 7, 4 }, new[] { 1, 7, 4 }, new[] { 3, 4, 1 }, new[] { 4, 5, 1 } }, 4];

        yield return [5, new[] { new[] { 1, 3, 2 }, new[] { 3, 5, 9 }, new[] { 1, 2, 1 }, new[] { 2, 5, 8 } }, 1];

        yield return [2, new[] { new[] { 1, 2, 10000 } }, 10000];

        yield return [5, new[] { new[] { 1, 2, 3 }, new[] { 1, 3, 7 }, new[] { 1, 4, 2 }, new[] { 1, 5, 9 } }, 2];

        yield return
        [
            8,
            new[]
            {
                new[] { 1, 2, 8 },
                new[] { 2, 3, 7 },
                new[] { 3, 4, 6 },
                new[] { 4, 5, 5 },
                new[] { 5, 6, 4 },
                new[] { 6, 7, 3 },
                new[] { 7, 8, 2 }
            },
            2
        ];

        yield return [6, new[] { new[] { 1, 2, 5 }, new[] { 2, 3, 1 }, new[] { 3, 4, 5 }, new[] { 4, 6, 2 } }, 1];

        yield return [4, new[] { new[] { 1, 2, 10 }, new[] { 2, 3, 10 }, new[] { 3, 4, 10 }, new[] { 4, 1, 1 } }, 1];

        yield return [3, new[] { new[] { 1, 3, 50 }, new[] { 1, 2, 4 }, new[] { 2, 3, 6 } }, 4];

        yield return
        [
            10,
            new[]
            {
                new[] { 1, 2, 9 },
                new[] { 2, 3, 8 },
                new[] { 3, 4, 2 },
                new[] { 4, 5, 7 },
                new[] { 5, 6, 6 },
                new[] { 6, 7, 5 },
                new[] { 7, 8, 4 },
                new[] { 8, 9, 3 },
                new[] { 9, 10, 10 }
            },
            2
        ];

        yield return [2, new[] { new[] { 2, 1, 3 } }, 3];

        yield return [4, new[] { new[] { 1, 3, 6 }, new[] { 1, 2, 5 }, new[] { 2, 4, 1 } }, 1];
    }
}