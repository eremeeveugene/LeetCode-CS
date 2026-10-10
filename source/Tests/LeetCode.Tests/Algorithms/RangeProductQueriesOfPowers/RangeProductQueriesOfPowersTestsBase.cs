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

using LeetCode.Algorithms.RangeProductQueriesOfPowers;

namespace LeetCode.Tests.Algorithms.RangeProductQueriesOfPowers;

public abstract class RangeProductQueriesOfPowersTestsBase<T> where T : IRangeProductQueriesOfPowers, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void ProductQueries_WithPowersOfTwoDecompositionAndRangeQueries_ReturnsModuloProductArray(int n, int[][] queries, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ProductQueries(n, queries);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [2, new[] { new[] { 0, 0 } }, new[] { 2 }];

        yield return [15, new[] { new[] { 0, 1 }, new[] { 2, 2 }, new[] { 0, 3 } }, new[] { 2, 4, 64 }];

        yield return [1, new[] { new[] { 0, 0 } }, new[] { 1 }];

        yield return [3, new[] { new[] { 0, 1 }, new[] { 1, 1 }, new[] { 0, 0 } }, new[] { 2, 2, 1 }];

        yield return [7, new[] { new[] { 0, 2 }, new[] { 1, 2 }, new[] { 0, 1 } }, new[] { 8, 8, 2 }];

        yield return [8, new[] { new[] { 0, 0 } }, new[] { 8 }];

        yield return [10, new[] { new[] { 0, 1 }, new[] { 0, 0 }, new[] { 1, 1 } }, new[] { 16, 2, 8 }];

        yield return [1000000000, new[] { new[] { 0, 0 }, new[] { 0, 5 }, new[] { 2, 5 }, new[] { 5, 5 } }, new[] { 512, 892516375, 164688009, 524288 }];

        yield return [536870911, new[] { new[] { 0, 28 }, new[] { 0, 0 }, new[] { 28, 28 }, new[] { 10, 20 } }, new[] { 733922348, 1, 268435456, 845845078 }];

        yield return [999999999, new[] { new[] { 0, 0 }, new[] { 0, 10 }, new[] { 3, 17 } }, new[] { 1, 72793001, 998890144 }];

        yield return [255, new[] { new[] { 0, 7 }, new[] { 2, 5 }, new[] { 7, 7 } }, new[] { 268435456, 16384, 128 }];

        yield return [1023, new[] { new[] { 0, 9 }, new[] { 0, 4 }, new[] { 5, 9 } }, new[] { 371842544, 1024, 359738130 }];

        yield return [6, new[] { new[] { 0, 1 }, new[] { 0, 0 }, new[] { 1, 1 }, new[] { 0, 1 } }, new[] { 8, 2, 4, 8 }];

        yield return [100, new[] { new[] { 0, 2 }, new[] { 1, 2 } }, new[] { 8192, 2048 }];

        yield return [65535, new[] { new[] { 0, 15 }, new[] { 8, 15 } }, new[] { 489373567, 242095202 }];

        yield return [123456789, new[] { new[] { 0, 0 }, new[] { 0, 5 }, new[] { 3, 8 }, new[] { 10, 10 } }, new[] { 1, 359738130, 320260020, 524288 }];

        yield return [16, new[] { new[] { 0, 0 }, new[] { 0, 0 } }, new[] { 16, 16 }];

        yield return [31, new[] { new[] { 0, 4 }, new[] { 4, 4 } }, new[] { 1024, 16 }];

        yield return [536870912, new[] { new[] { 0, 0 } }, new[] { 536870912 }];

        yield return [777777777, new[] { new[] { 0, 3 }, new[] { 4, 9 }, new[] { 0, 14 } }, new[] { 32768, 248320570, 62430634 }];
    }

    [TestMethod]
    public void ProductQueries_WithMaxNumberOfQueries_ReturnsModuloProductArray()
    {
        // Arrange
        var solution = new T();

        var queries = new int[100000][];
        var expectedResult = new int[100000];

        for (var i = 0; i < queries.Length; i++)
        {
            queries[i] = [0, 0];
            expectedResult[i] = 1;
        }

        // Act
        var actualResult = solution.ProductQueries(1, queries);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}