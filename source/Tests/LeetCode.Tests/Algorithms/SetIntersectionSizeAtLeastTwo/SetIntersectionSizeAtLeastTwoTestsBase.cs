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

using LeetCode.Algorithms.SetIntersectionSizeAtLeastTwo;

namespace LeetCode.Tests.Algorithms.SetIntersectionSizeAtLeastTwo;

public abstract class SetIntersectionSizeAtLeastTwoTestsBase<T> where T : ISetIntersectionSizeAtLeastTwo, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void IntersectionSizeTwo_GivenDifferentIntervals_ReturnsMinimumContainingSetSize(int[][] intervals, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.IntersectionSizeTwo(intervals);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 3 }, new[] { 3, 7 }, new[] { 8, 9 } }, 5];

        yield return [new[] { new[] { 1, 3 }, new[] { 1, 4 }, new[] { 2, 5 }, new[] { 3, 5 } }, 3];

        yield return [new[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 2, 4 }, new[] { 4, 5 } }, 5];

        yield return [new[] { new[] { 1, 2 } }, 2];

        yield return [new[] { new[] { 0, 1 } }, 2];

        yield return [new[] { new[] { 1, 10 } }, 2];

        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 } }, 4];

        yield return [new[] { new[] { 1, 2 }, new[] { 1, 2 }, new[] { 1, 2 } }, 2];

        yield return [new[] { new[] { 1, 3 }, new[] { 2, 4 } }, 2];

        yield return [new[] { new[] { 1, 5 }, new[] { 2, 3 } }, 2];

        yield return [new[] { new[] { 1, 5 }, new[] { 2, 6 }, new[] { 3, 7 } }, 2];

        yield return [new[] { new[] { 1, 2 }, new[] { 2, 3 } }, 3];

        yield return [new[] { new[] { 1, 3 }, new[] { 3, 5 }, new[] { 5, 7 } }, 4];

        yield return [new[] { new[] { 0, 2 }, new[] { 1, 3 }, new[] { 2, 4 }, new[] { 3, 5 } }, 4];

        yield return [new[] { new[] { 1, 9 }, new[] { 2, 8 }, new[] { 3, 7 }, new[] { 4, 6 } }, 2];

        yield return [new[] { new[] { 1, 4 }, new[] { 2, 5 }, new[] { 3, 6 }, new[] { 4, 7 } }, 3];

        yield return [new[] { new[] { 1, 2 }, new[] { 2, 4 }, new[] { 4, 6 }, new[] { 6, 8 } }, 5];

        yield return
        [
            new[]
            {
                new[] { 2, 10 },
                new[] { 3, 7 },
                new[] { 3, 15 },
                new[] { 4, 11 },
                new[] { 6, 12 },
                new[] { 6, 16 },
                new[] { 7, 8 },
                new[] { 7, 11 },
                new[] { 7, 15 },
                new[] { 11, 12 }
            },
            5
        ];

        yield return [new[] { new[] { 1, 3 }, new[] { 1, 4 }, new[] { 2, 5 }, new[] { 3, 5 }, new[] { 6, 9 } }, 5];

        yield return [new[] { new[] { 0, 3 }, new[] { 3, 6 }, new[] { 6, 9 }, new[] { 9, 12 } }, 5];

        yield return [new[] { new[] { 1, 100000000 } }, 2];

        yield return [new[] { new[] { 0, 100000000 }, new[] { 99999999, 100000000 } }, 2];

        yield return [new[] { new[] { 5, 6 }, new[] { 1, 2 }, new[] { 3, 4 } }, 6];

        yield return [new[] { new[] { 1, 4 }, new[] { 4, 7 }, new[] { 7, 10 }, new[] { 2, 9 } }, 4];

        yield return [new[] { new[] { 0, 1 }, new[] { 99999999, 100000000 } }, 4];
    }
}