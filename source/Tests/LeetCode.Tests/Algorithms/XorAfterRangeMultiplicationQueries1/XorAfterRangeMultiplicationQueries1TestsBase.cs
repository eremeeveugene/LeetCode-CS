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

using LeetCode.Algorithms.XorAfterRangeMultiplicationQueries1;

namespace LeetCode.Tests.Algorithms.XorAfterRangeMultiplicationQueries1;

public abstract class XorAfterRangeMultiplicationQueries1TestsBase<T> where T : IXorAfterRangeMultiplicationQueries1, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void XorAfterQueries_WithArrayAndRangeMultiplicationQueries_ReturnsXorOfAllElements(int[] nums, int[][] queries, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.XorAfterQueries(nums, queries);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { 1, 1, 1 }, new[] { new[] { 0, 2, 1, 4 } }, 4];

        yield return [new[] { 2, 3, 1, 5, 4 }, new[] { new[] { 1, 4, 2, 3 }, new[] { 0, 2, 1, 2 } }, 31];

        yield return [new[] { 1 }, new[] { new[] { 0, 0, 1, 1 } }, 1];

        yield return [new[] { 5 }, new[] { new[] { 0, 0, 1, 2 } }, 10];

        yield return [new[] { 1, 2, 3, 4 }, new[] { new[] { 0, 3, 1, 1 } }, 4];

        yield return [new[] { 1, 2, 3, 4, 5 }, new[] { new[] { 0, 4, 2, 2 } }, 8];

        yield return [new[] { 1000000000 }, new[] { new[] { 0, 0, 1, 100000 } }, 999300007];

        yield return [new[] { 7, 7, 7, 7 }, new[] { new[] { 1, 3, 2, 3 } }, 0];

        yield return [new[] { 1, 2 }, new[] { new[] { 0, 1, 1, 3 } }, 5];

        yield return [new[] { 3, 6, 9 }, new[] { new[] { 0, 2, 3, 5 } }, 0];

        yield return [new[] { 10, 20, 30 }, new[] { new[] { 2, 2, 1, 7 } }, 204];

        yield return [new[] { 1, 1, 1, 1, 1, 1 }, new[] { new[] { 0, 5, 1, 2 }, new[] { 0, 5, 1, 2 } }, 0];

        yield return [new[] { 2, 4, 8, 16 }, new[] { new[] { 0, 3, 1, 1 }, new[] { 0, 3, 1, 1 } }, 30];

        yield return [new[] { 5, 10, 15 }, new[] { new[] { 0, 1, 1, 4 }, new[] { 1, 2, 1, 2 } }, 90];

        yield return [new[] { 9, 8, 7, 6, 5 }, new[] { new[] { 0, 4, 4, 10 } }, 97];

        yield return [new[] { 999999999, 999999998 }, new[] { new[] { 0, 1, 1, 99999 } }, 236415];

        yield return [new[] { 1, 3, 5, 7, 9, 11 }, new[] { new[] { 2, 5, 3, 6 } }, 80];

        yield return [new[] { 4, 4, 4, 4 }, new[] { new[] { 0, 3, 2, 5 }, new[] { 1, 3, 2, 5 } }, 0];

        yield return [new[] { 1, 2, 4, 8, 16, 32, 64 }, new[] { new[] { 0, 6, 1, 2 } }, 254];

        yield return [new[] { 6 }, new[] { new[] { 0, 0, 1, 100000 }, new[] { 0, 0, 1, 100000 } }, 999999587];

        yield return [new[] { 13, 17, 19, 23 }, new[] { new[] { 0, 3, 3, 7 } }, 248];

        yield return [new[] { 100, 200, 300, 400, 500 }, new[] { new[] { 1, 3, 1, 3 }, new[] { 0, 4, 2, 2 } }, 704];
    }
}