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

using LeetCode.Algorithms.XORQueriesOfSubarray;

namespace LeetCode.Tests.Algorithms.XORQueriesOfSubarray;

public abstract class XORQueriesOfSubarrayTestsBase<T> where T : IXORQueriesOfSubarray, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void XorQueries_WithArrayAndRangeQueries_ReturnsXorOfElementsForEachQuery(int[] arr, int[][] queries, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.XorQueries(arr, queries);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { 1, 3, 4, 8 }, new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 0, 3 }, new[] { 3, 3 } }, new[] { 2, 7, 14, 8 }];

        yield return [new[] { 4, 8, 2, 10 }, new[] { new[] { 2, 3 }, new[] { 1, 3 }, new[] { 0, 0 }, new[] { 0, 3 } }, new[] { 8, 0, 4, 4 }];

        yield return [new[] { 16 }, new[] { new[] { 0, 0 }, new[] { 0, 0 }, new[] { 0, 0 } }, new[] { 16, 16, 16 }];

        yield return [new[] { 15, 8, 8, 8, 15 }, new[] { new[] { 2, 2 }, new[] { 3, 3 } }, new[] { 8, 8 }];

        yield return [new[] { 1 }, new[] { new[] { 0, 0 } }, new[] { 1 }];

        yield return [new[] { 0 }, new[] { new[] { 0, 0 } }, new[] { 0 }];

        yield return [new[] { 5, 5 }, new[] { new[] { 0, 1 }, new[] { 0, 0 }, new[] { 1, 1 } }, new[] { 0, 5, 5 }];

        yield return [new[] { 1, 2, 3 }, new[] { new[] { 0, 2 }, new[] { 1, 2 } }, new[] { 0, 1 }];

        yield return [new[] { 7, 7, 7 }, new[] { new[] { 0, 2 }, new[] { 0, 1 } }, new[] { 7, 0 }];

        yield return [new[] { 1, 2, 4, 8, 16 }, new[] { new[] { 0, 4 }, new[] { 1, 3 }, new[] { 2, 2 } }, new[] { 31, 14, 4 }];

        yield return [new[] { 1000000000, 1000000000 }, new[] { new[] { 0, 1 } }, new[] { 0 }];

        yield return [new[] { 1000000000, 1 }, new[] { new[] { 0, 1 }, new[] { 1, 1 } }, new[] { 1000000001, 1 }];

        yield return [new[] { 3, 6, 9, 12, 15, 18 }, new[] { new[] { 0, 5 }, new[] { 2, 4 }, new[] { 1, 1 }, new[] { 5, 5 } }, new[] { 29, 10, 6, 18 }];

        yield return [new[] { 255, 128, 64, 32, 16, 8, 4, 2, 1 }, new[] { new[] { 0, 8 }, new[] { 4, 8 }, new[] { 0, 3 } }, new[] { 0, 31, 31 }];

        yield return [new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }, new[] { new[] { 0, 9 }, new[] { 9, 9 }, new[] { 3, 6 }, new[] { 0, 0 } }, new[] { 1, 0, 4, 9 }];

        yield return [new[] { 2, 2, 2, 2 }, new[] { new[] { 0, 3 }, new[] { 0, 2 }, new[] { 1, 2 }, new[] { 2, 3 } }, new[] { 0, 2, 0, 0 }];

        yield return [new[] { 1, 1, 1, 1, 1 }, new[] { new[] { 0, 4 }, new[] { 1, 3 } }, new[] { 1, 1 }];

        yield return [new[] { 10, 20, 30 }, new[] { new[] { 0, 0 }, new[] { 1, 1 }, new[] { 2, 2 }, new[] { 0, 2 } }, new[] { 10, 20, 30, 0 }];

        yield return [new[] { 12, 34, 56, 78, 90 }, new[] { new[] { 4, 4 }, new[] { 0, 4 }, new[] { 1, 3 } }, new[] { 90, 2, 84 }];

        yield return [new[] { 6, 0, 6, 0, 6 }, new[] { new[] { 0, 4 }, new[] { 1, 3 }, new[] { 0, 2 } }, new[] { 6, 6, 0 }];

        yield return [CreateSequentialArray(30000), new[] { new[] { 0, 29999 }, new[] { 1, 29999 }, new[] { 5, 5 } }, new[] { 30000, 30001, 6 }];
    }

    private static int[] CreateSequentialArray(int length)
    {
        var arr = new int[length];

        for (var i = 0; i < length; i++)
        {
            arr[i] = i + 1;
        }

        return arr;
    }
}