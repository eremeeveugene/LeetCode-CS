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

using LeetCode.Algorithms.FindTheNumberOfDistinctColorsAmongTheBalls;

namespace LeetCode.Tests.Algorithms.FindTheNumberOfDistinctColorsAmongTheBalls;

public abstract class FindTheNumberOfDistinctColorsAmongTheBallsTestsBase<T> where T : IFindTheNumberOfDistinctColorsAmongTheBalls, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void QueryResults_WithLimitAndQueries_ReturnsQueryResults(int limit, int[][] queries, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.QueryResults(limit, queries);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [4, new[] { new[] { 1, 4 }, new[] { 2, 5 }, new[] { 1, 3 }, new[] { 3, 4 } }, new[] { 1, 2, 2, 3 }];

        yield return [4, new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 2, 2 }, new[] { 3, 4 }, new[] { 4, 5 } }, new[] { 1, 2, 2, 3, 4 }];

        yield return [4, new[] { new[] { 1, 4 }, new[] { 2, 4 }, new[] { 1, 3 } }, new[] { 1, 1, 2 }];

        yield return [5, new[] { new[] { 0, 1 } }, new[] { 1 }];

        yield return [5, new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 0, 3 } }, new[] { 1, 1, 1 }];

        yield return [5, new[] { new[] { 0, 1 }, new[] { 1, 1 }, new[] { 2, 1 } }, new[] { 1, 1, 1 }];

        yield return [8, new[] { new[] { 0, 1 }, new[] { 1, 1 }, new[] { 2, 2 }, new[] { 0, 2 } }, new[] { 1, 1, 2, 2 }];

        yield return [6, new[] { new[] { 0, 5 }, new[] { 1, 5 }, new[] { 2, 5 }, new[] { 0, 6 } }, new[] { 1, 1, 1, 2 }];

        yield return [3, new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 0, 3 }, new[] { 0, 1 } }, new[] { 1, 1, 1, 1 }];

        yield return [10, new[] { new[] { 1, 1 }, new[] { 2, 2 }, new[] { 3, 3 }, new[] { 4, 4 }, new[] { 5, 5 } }, new[] { 1, 2, 3, 4, 5 }];

        yield return [10, new[] { new[] { 1, 1 }, new[] { 2, 1 }, new[] { 3, 1 }, new[] { 4, 1 }, new[] { 5, 1 } }, new[] { 1, 1, 1, 1, 1 }];

        yield return [7, new[] { new[] { 0, 2 }, new[] { 1, 3 }, new[] { 2, 2 }, new[] { 0, 3 } }, new[] { 1, 2, 2, 2 }];

        yield return [6, new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 0, 2 }, new[] { 1, 1 } }, new[] { 1, 2, 1, 2 }];

        yield return [9, new[] { new[] { 0, 9 }, new[] { 1, 9 }, new[] { 2, 9 }, new[] { 0, 8 }, new[] { 1, 8 } }, new[] { 1, 1, 1, 2, 2 }];

        yield return [4, new[] { new[] { 0, 1 } }, new[] { 1 }];

        yield return [4, new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 0, 1 }, new[] { 0, 2 } }, new[] { 1, 1, 1, 1 }];

        yield return [10, new[] { new[] { 0, 3 }, new[] { 1, 3 }, new[] { 2, 3 }, new[] { 3, 3 }, new[] { 0, 4 } }, new[] { 1, 1, 1, 1, 2 }];

        yield return [5, new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 }, new[] { 4, 5 } }, new[] { 1, 2, 3, 4, 5 }];

        yield return [2, new[] { new[] { 0, 1 }, new[] { 1, 1 } }, new[] { 1, 1 }];

        yield return [10, new[] { new[] { 5, 5 }, new[] { 6, 5 }, new[] { 7, 6 }, new[] { 5, 6 }, new[] { 6, 6 } }, new[] { 1, 1, 2, 2, 1 }];

        yield return [8, new[] { new[] { 0, 7 }, new[] { 1, 7 }, new[] { 2, 8 }, new[] { 0, 8 }, new[] { 1, 8 } }, new[] { 1, 1, 2, 2, 1 }];
    }
}