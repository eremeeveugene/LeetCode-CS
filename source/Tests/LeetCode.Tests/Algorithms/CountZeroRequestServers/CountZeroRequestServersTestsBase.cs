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

using LeetCode.Algorithms.CountZeroRequestServers;

namespace LeetCode.Tests.Algorithms.CountZeroRequestServers;

public abstract class CountZeroRequestServersTestsBase<T> where T : ICountZeroRequestServers, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void CountServers_WithServersLogsIntervalAndQueries_ReturnsServersWithoutRequests(
        int n,
        int[][] logs,
        int x,
        int[] queries,
        int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountServers(n, logs, x, queries);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [3, new[] { new[] { 1, 3 }, new[] { 2, 6 }, new[] { 1, 5 } }, 5, new[] { 10, 11 }, new[] { 1, 2 }];

        yield return [3, new[] { new[] { 2, 4 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 3, 1 } }, 2, new[] { 3, 4 }, new[] { 0, 1 }];

        yield return [1, new[] { new[] { 1, 1 } }, 1, new[] { 2 }, new[] { 0 }];

        yield return [1, new[] { new[] { 1, 1 } }, 1, new[] { 3 }, new[] { 1 }];

        yield return [1, new[] { new[] { 1, 5 } }, 1, new[] { 4 }, new[] { 1 }];

        yield return [1, new[] { new[] { 1, 5 } }, 1, new[] { 5 }, new[] { 0 }];

        yield return [1, new[] { new[] { 1, 5 } }, 1, new[] { 6 }, new[] { 0 }];

        yield return [1, new[] { new[] { 1, 5 } }, 1, new[] { 7 }, new[] { 1 }];

        yield return [5, new[] { new[] { 1, 10 } }, 2, new[] { 10 }, new[] { 4 }];

        yield return [4, new[] { new[] { 1, 2 }, new[] { 2, 2 }, new[] { 3, 2 }, new[] { 4, 2 } }, 1, new[] { 2, 3, 4 }, new[] { 0, 0, 4 }];

        yield return [2, new[] { new[] { 1, 2 }, new[] { 2, 8 } }, 2, new[] { 9, 3, 5 }, new[] { 1, 1, 2 }];

        yield return [3, new[] { new[] { 1, 4 }, new[] { 2, 4 } }, 1, new[] { 5, 5, 2 }, new[] { 1, 1, 3 }];

        yield return [2, new[] { new[] { 1, 1 }, new[] { 1, 2 }, new[] { 1, 3 } }, 1, new[] { 2, 3, 4, 5 }, new[] { 1, 1, 1, 2 }];

        yield return [2, new[] { new[] { 1, 1 }, new[] { 1, 10 } }, 2, new[] { 3, 6, 11 }, new[] { 1, 2, 1 }];

        yield return [3, new[] { new[] { 3, 9 }, new[] { 2, 6 }, new[] { 1, 3 } }, 3, new[] { 4, 7, 10 }, new[] { 2, 2, 2 }];

        yield return [3, new[] { new[] { 1, 1 }, new[] { 2, 2 }, new[] { 3, 3 } }, 100000, new[] { 100001 }, new[] { 0 }];

        yield return [2, new[] { new[] { 1, 1000000 }, new[] { 2, 1 } }, 100000, new[] { 1000000, 100001, 100002 }, new[] { 1, 1, 2 }];

        yield return [5, new[] { new[] { 2, 3 }, new[] { 4, 3 } }, 1, new[] { 3, 4, 5 }, new[] { 3, 3, 5 }];

        yield return [2, new[] { new[] { 1, 5 }, new[] { 1, 5 }, new[] { 1, 5 } }, 1, new[] { 5, 6, 7 }, new[] { 1, 1, 2 }];

        yield return [3, new[] { new[] { 1, 2 }, new[] { 2, 4 }, new[] { 3, 6 } }, 2, new[] { 4, 6, 8 }, new[] { 1, 1, 2 }];

        yield return [2, new[] { new[] { 1, 1 }, new[] { 1, 4 }, new[] { 2, 2 } }, 2, new[] { 3, 5, 6 }, new[] { 0, 1, 1 }];

        yield return [2, new[] { new[] { 1, 100 }, new[] { 2, 200 } }, 5, new[] { 10, 20, 30 }, new[] { 2, 2, 2 }];

        yield return [2, new[] { new[] { 1, 1 }, new[] { 2, 2 } }, 1, new[] { 10, 20 }, new[] { 2, 2 }];

        yield return
        [
            3,
            new[] { new[] { 1, 1 }, new[] { 2, 2 }, new[] { 3, 3 }, new[] { 1, 50 }, new[] { 2, 51 } },
            10,
            new[] { 60, 12, 13 },
            new[] { 1, 1, 2 }
        ];

        yield return [2, new[] { new[] { 1, 5 }, new[] { 2, 10 } }, 4, new[] { 14, 9, 5 }, new[] { 1, 1, 1 }];
    }
}