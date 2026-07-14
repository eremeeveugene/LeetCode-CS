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
using LeetCode.Tests.Base.Extensions;

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
        NestedCollectionAssert.AreEqual(expectedResult, actualResult);
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
    }
}