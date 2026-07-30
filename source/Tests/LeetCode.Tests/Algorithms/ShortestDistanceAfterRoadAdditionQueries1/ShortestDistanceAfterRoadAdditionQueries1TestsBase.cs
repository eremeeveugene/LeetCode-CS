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

using LeetCode.Algorithms.ShortestDistanceAfterRoadAdditionQueries1;

namespace LeetCode.Tests.Algorithms.ShortestDistanceAfterRoadAdditionQueries1;

public abstract class ShortestDistanceAfterRoadAdditionQueries1TestsBase<T> where T : IShortestDistanceAfterRoadAdditionQueries1, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void ShortestDistanceAfterQueries_WithNumberOfNodesAndQueryRanges_ReturnsShortestDistances(int n, int[][] queries, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ShortestDistanceAfterQueries(n, queries);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [5, new[] { new[] { 2, 4 }, new[] { 0, 2 }, new[] { 0, 4 } }, new[] { 3, 2, 1 }];

        yield return [4, new[] { new[] { 0, 3 }, new[] { 0, 2 } }, new[] { 1, 1 }];

        yield return [5, new[] { new[] { 2, 4 }, new[] { 2, 4 } }, new[] { 3, 3 }];

        yield return [3, new[] { new[] { 0, 2 } }, new[] { 1 }];

        yield return [6, new[] { new[] { 0, 2 }, new[] { 2, 5 }, new[] { 0, 5 } }, new[] { 4, 2, 1 }];

        yield return [7, new[] { new[] { 0, 3 }, new[] { 3, 6 }, new[] { 1, 4 } }, new[] { 4, 2, 2 }];

        yield return [5, new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 } }, new[] { 4, 4, 4, 4 }];

        yield return [8, new[] { new[] { 0, 4 }, new[] { 4, 7 }, new[] { 0, 7 }, new[] { 2, 6 } }, new[] { 4, 2, 1, 1 }];

        yield return [4, new[] { new[] { 1, 3 }, new[] { 0, 2 } }, new[] { 2, 2 }];

        yield return [10, new[] { new[] { 0, 5 }, new[] { 5, 9 }, new[] { 0, 3 }, new[] { 3, 9 } }, new[] { 5, 2, 2, 2 }];

        yield return [6, new[] { new[] { 0, 3 }, new[] { 1, 4 }, new[] { 2, 5 } }, new[] { 3, 3, 3 }];

        yield return [9, new[] { new[] { 0, 8 }, new[] { 0, 4 }, new[] { 4, 8 }, new[] { 2, 6 } }, new[] { 1, 1, 1, 1 }];

        yield return [5, new[] { new[] { 3, 4 }, new[] { 2, 4 }, new[] { 1, 4 }, new[] { 0, 4 } }, new[] { 4, 3, 2, 1 }];

        yield return [7, new[] { new[] { 0, 6 }, new[] { 0, 3 }, new[] { 3, 6 }, new[] { 1, 5 } }, new[] { 1, 1, 1, 1 }];

        yield return [12, new[] { new[] { 0, 11 }, new[] { 5, 11 }, new[] { 0, 5 }, new[] { 2, 8 } }, new[] { 1, 1, 1, 1 }];

        yield return [6, new[] { new[] { 0, 5 }, new[] { 0, 5 } }, new[] { 1, 1 }];

        yield return [8, new[] { new[] { 0, 7 }, new[] { 0, 3 }, new[] { 3, 7 }, new[] { 1, 2 }, new[] { 2, 7 } }, new[] { 1, 1, 1, 1, 1 }];

        yield return [4, new[] { new[] { 0, 3 } }, new[] { 1 }];

        yield return [15, new[] { new[] { 0, 14 }, new[] { 0, 7 }, new[] { 7, 14 }, new[] { 3, 10 } }, new[] { 1, 1, 1, 1 }];

        yield return [6, new[] { new[] { 0, 2 }, new[] { 1, 3 }, new[] { 3, 5 }, new[] { 0, 5 } }, new[] { 4, 4, 3, 1 }];

        yield return [10, new[] { new[] { 0, 9 }, new[] { 2, 7 }, new[] { 0, 4 }, new[] { 4, 9 } }, new[] { 1, 1, 1, 1 }];

        yield return [5, new[] { new[] { 0, 4 }, new[] { 1, 4 }, new[] { 2, 4 }, new[] { 3, 4 } }, new[] { 1, 1, 1, 1 }];

        yield return [11, new[] { new[] { 0, 10 }, new[] { 0, 5 }, new[] { 5, 10 }, new[] { 2, 8 }, new[] { 8, 10 } }, new[] { 1, 1, 1, 1, 1 }];

        yield return [7, new[] { new[] { 2, 6 }, new[] { 0, 6 }, new[] { 0, 2 }, new[] { 1, 4 } }, new[] { 3, 1, 1, 1 }];

        yield return [3, new[] { new[] { 0, 1 } }, new[] { 2 }];
    }
}