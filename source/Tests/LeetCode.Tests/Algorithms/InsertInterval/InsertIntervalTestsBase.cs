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

using LeetCode.Algorithms.InsertInterval;

namespace LeetCode.Tests.Algorithms.InsertInterval;

public abstract class InsertIntervalTestsBase<T> where T : IInsertInterval, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void Insert_GivenIntervalsAndNewInterval_MergesOrAddsIntervalAsExpected(int[][] intervals, int[] newInterval, int[][] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.Insert(intervals, newInterval);

        // Assert
        Assert.AreEquivalent(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [Array.Empty<int[]>(), new[] { 2, 5 }, new[] { new[] { 2, 5 } }];

        yield return [new[] { new[] { 1, 3 }, new[] { 6, 9 } }, new[] { 2, 5 }, new[] { new[] { 1, 5 }, new[] { 6, 9 } }];

        yield return
        [
            new[] { new[] { 1, 2 }, new[] { 3, 5 }, new[] { 6, 7 }, new[] { 8, 10 }, new[] { 12, 16 } },
            new[] { 4, 8 },
            new[] { new[] { 1, 2 }, new[] { 3, 10 }, new[] { 12, 16 } }
        ];

        yield return [new[] { new[] { 1, 5 } }, new[] { 6, 8 }, new[] { new[] { 1, 5 }, new[] { 6, 8 } }];

        yield return [new[] { new[] { 1, 5 } }, new[] { 0, 0 }, new[] { new[] { 0, 0 }, new[] { 1, 5 } }];

        yield return [new[] { new[] { 3, 5 }, new[] { 12, 15 } }, new[] { 6, 6 }, new[] { new[] { 3, 5 }, new[] { 6, 6 }, new[] { 12, 15 } }];

        yield return [new[] { new[] { 1, 5 } }, new[] { 2, 3 }, new[] { new[] { 1, 5 } }];

        yield return [new[] { new[] { 1, 5 } }, new[] { 0, 6 }, new[] { new[] { 0, 6 } }];

        yield return [new[] { new[] { 1, 5 } }, new[] { 5, 7 }, new[] { new[] { 1, 7 } }];

        yield return [new[] { new[] { 1, 5 } }, new[] { 0, 1 }, new[] { new[] { 0, 5 } }];

        yield return [new[] { new[] { 1, 5 } }, new[] { 6, 6 }, new[] { new[] { 1, 5 }, new[] { 6, 6 } }];

        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 } }, new[] { 2, 3 }, new[] { new[] { 1, 4 } }];

        yield return [new[] { new[] { 1, 2 }, new[] { 4, 5 } }, new[] { 3, 3 }, new[] { new[] { 1, 2 }, new[] { 3, 3 }, new[] { 4, 5 } }];

        yield return [new[] { new[] { 0, 0 }, new[] { 2, 2 }, new[] { 4, 4 } }, new[] { 1, 3 }, new[] { new[] { 0, 0 }, new[] { 1, 3 }, new[] { 4, 4 } }];

        yield return [new[] { new[] { 1, 2 }, new[] { 3, 5 }, new[] { 6, 7 }, new[] { 8, 10 }, new[] { 12, 16 } }, new[] { 0, 100000 }, new[] { new[] { 0, 100000 } }];

        yield return [new[] { new[] { 100000, 100000 } }, new[] { 100000, 100000 }, new[] { new[] { 100000, 100000 } }];

        yield return [new[] { new[] { 0, 0 } }, new[] { 0, 0 }, new[] { new[] { 0, 0 } }];

        yield return [new[] { new[] { 5, 10 }, new[] { 20, 30 } }, new[] { 11, 19 }, new[] { new[] { 5, 10 }, new[] { 11, 19 }, new[] { 20, 30 } }];

        yield return [new[] { new[] { 5, 10 }, new[] { 20, 30 } }, new[] { 10, 20 }, new[] { new[] { 5, 30 } }];

        yield return [new[] { new[] { 5, 10 }, new[] { 20, 30 } }, new[] { 31, 40 }, new[] { new[] { 5, 10 }, new[] { 20, 30 }, new[] { 31, 40 } }];

        yield return [new[] { new[] { 1, 5 }, new[] { 6, 10 }, new[] { 12, 16 }, new[] { 17, 21 }, new[] { 24, 27 } }, new[] { 11, 20 }, new[] { new[] { 1, 5 }, new[] { 6, 10 }, new[] { 11, 21 }, new[] { 24, 27 } }];

        yield return [new[] { new[] { 1, 1 }, new[] { 4, 8 }, new[] { 9, 12 }, new[] { 14, 15 }, new[] { 18, 21 }, new[] { 25, 25 }, new[] { 26, 27 }, new[] { 29, 30 } }, new[] { 22, 32 }, new[] { new[] { 1, 1 }, new[] { 4, 8 }, new[] { 9, 12 }, new[] { 14, 15 }, new[] { 18, 21 }, new[] { 22, 32 } }];

        yield return [new[] { new[] { 2, 6 }, new[] { 7, 9 }, new[] { 12, 13 }, new[] { 17, 17 }, new[] { 18, 18 }, new[] { 20, 20 }, new[] { 23, 24 }, new[] { 28, 31 }, new[] { 35, 39 }, new[] { 42, 44 }, new[] { 45, 46 }, new[] { 49, 53 } }, new[] { 10, 36 }, new[] { new[] { 2, 6 }, new[] { 7, 9 }, new[] { 10, 39 }, new[] { 42, 44 }, new[] { 45, 46 }, new[] { 49, 53 } }];

        yield return [new[] { new[] { 3, 6 }, new[] { 9, 11 }, new[] { 12, 16 }, new[] { 19, 19 }, new[] { 20, 21 }, new[] { 23, 26 }, new[] { 29, 33 }, new[] { 36, 37 }, new[] { 40, 41 }, new[] { 42, 45 }, new[] { 49, 50 }, new[] { 52, 56 }, new[] { 57, 58 }, new[] { 62, 64 }, new[] { 68, 71 }, new[] { 74, 76 }, new[] { 80, 84 }, new[] { 87, 91 }, new[] { 95, 99 }, new[] { 103, 103 } }, new[] { 27, 58 }, new[] { new[] { 3, 6 }, new[] { 9, 11 }, new[] { 12, 16 }, new[] { 19, 19 }, new[] { 20, 21 }, new[] { 23, 26 }, new[] { 27, 58 }, new[] { 62, 64 }, new[] { 68, 71 }, new[] { 74, 76 }, new[] { 80, 84 }, new[] { 87, 91 }, new[] { 95, 99 }, new[] { 103, 103 } }];

        yield return [new[] { new[] { 0, 0 }, new[] { 2, 2 }, new[] { 4, 4 }, new[] { 6, 6 }, new[] { 8, 8 }, new[] { 10, 10 }, new[] { 12, 12 }, new[] { 14, 14 }, new[] { 16, 16 }, new[] { 18, 18 }, new[] { 20, 20 }, new[] { 22, 22 }, new[] { 24, 24 }, new[] { 26, 26 }, new[] { 28, 28 }, new[] { 30, 30 }, new[] { 32, 32 }, new[] { 34, 34 }, new[] { 36, 36 }, new[] { 38, 38 }, new[] { 40, 40 }, new[] { 42, 42 }, new[] { 44, 44 }, new[] { 46, 46 }, new[] { 48, 48 }, new[] { 50, 50 }, new[] { 52, 52 }, new[] { 54, 54 }, new[] { 56, 56 }, new[] { 58, 58 }, new[] { 60, 60 }, new[] { 62, 62 }, new[] { 64, 64 }, new[] { 66, 66 }, new[] { 68, 68 }, new[] { 70, 70 }, new[] { 72, 72 }, new[] { 74, 74 }, new[] { 76, 76 }, new[] { 78, 78 }, new[] { 80, 80 }, new[] { 82, 82 }, new[] { 84, 84 }, new[] { 86, 86 }, new[] { 88, 88 }, new[] { 90, 90 }, new[] { 92, 92 }, new[] { 94, 94 }, new[] { 96, 96 }, new[] { 98, 98 } }, new[] { 10, 60 }, new[] { new[] { 0, 0 }, new[] { 2, 2 }, new[] { 4, 4 }, new[] { 6, 6 }, new[] { 8, 8 }, new[] { 10, 60 }, new[] { 62, 62 }, new[] { 64, 64 }, new[] { 66, 66 }, new[] { 68, 68 }, new[] { 70, 70 }, new[] { 72, 72 }, new[] { 74, 74 }, new[] { 76, 76 }, new[] { 78, 78 }, new[] { 80, 80 }, new[] { 82, 82 }, new[] { 84, 84 }, new[] { 86, 86 }, new[] { 88, 88 }, new[] { 90, 90 }, new[] { 92, 92 }, new[] { 94, 94 }, new[] { 96, 96 }, new[] { 98, 98 } }];
    }
}