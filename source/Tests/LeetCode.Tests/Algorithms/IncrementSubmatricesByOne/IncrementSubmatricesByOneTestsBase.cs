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

using LeetCode.Algorithms.IncrementSubmatricesByOne;

namespace LeetCode.Tests.Algorithms.IncrementSubmatricesByOne;

public abstract class IncrementSubmatricesByOneTestsBase<T> where T : IIncrementSubmatricesByOne, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void RangeAddQueries_WithSizeAndQueries_ReturnsMatrixAfterIncrementingSubmatrices(int n, int[][] queries, int[][] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RangeAddQueries(n, queries);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [3, new[] { new[] { 1, 1, 2, 2 }, new[] { 0, 0, 1, 1 } }, new[] { new[] { 1, 1, 0 }, new[] { 1, 2, 1 }, new[] { 0, 1, 1 } }];

        yield return [2, new[] { new[] { 0, 0, 1, 1 } }, new[] { new[] { 1, 1 }, new[] { 1, 1 } }];

        yield return [1, new[] { new[] { 0, 0, 0, 0 } }, new[] { new[] { 1 } }];

        yield return [1, new[] { new[] { 0, 0, 0, 0 }, new[] { 0, 0, 0, 0 } }, new[] { new[] { 2 } }];

        yield return [2, new[] { new[] { 0, 0, 0, 0 } }, new[] { new[] { 1, 0 }, new[] { 0, 0 } }];

        yield return [2, new[] { new[] { 1, 1, 1, 1 } }, new[] { new[] { 0, 0 }, new[] { 0, 1 } }];

        yield return [2, new[] { new[] { 0, 1, 0, 1 } }, new[] { new[] { 0, 1 }, new[] { 0, 0 } }];

        yield return [2, new[] { new[] { 1, 0, 1, 0 } }, new[] { new[] { 0, 0 }, new[] { 1, 0 } }];

        yield return [2, new[] { new[] { 0, 0, 0, 1 } }, new[] { new[] { 1, 1 }, new[] { 0, 0 } }];

        yield return [2, new[] { new[] { 0, 0, 1, 0 } }, new[] { new[] { 1, 0 }, new[] { 1, 0 } }];

        yield return [3, new[] { new[] { 0, 0, 2, 2 } }, new[] { new[] { 1, 1, 1 }, new[] { 1, 1, 1 }, new[] { 1, 1, 1 } }];

        yield return [3, new[] { new[] { 1, 1, 1, 1 } }, new[] { new[] { 0, 0, 0 }, new[] { 0, 1, 0 }, new[] { 0, 0, 0 } }];

        yield return [3, new[] { new[] { 0, 0, 1, 1 }, new[] { 1, 1, 2, 2 } }, new[] { new[] { 1, 1, 0 }, new[] { 1, 2, 1 }, new[] { 0, 1, 1 } }];

        yield return [3, new[] { new[] { 0, 0, 0, 2 } }, new[] { new[] { 1, 1, 1 }, new[] { 0, 0, 0 }, new[] { 0, 0, 0 } }];

        yield return [3, new[] { new[] { 0, 2, 2, 2 } }, new[] { new[] { 0, 0, 1 }, new[] { 0, 0, 1 }, new[] { 0, 0, 1 } }];

        yield return
        [
            3,
            new[] { new[] { 0, 0, 2, 2 }, new[] { 0, 0, 2, 2 }, new[] { 0, 0, 2, 2 } },
            new[] { new[] { 3, 3, 3 }, new[] { 3, 3, 3 }, new[] { 3, 3, 3 } }
        ];

        yield return [3, new[] { new[] { 0, 0, 0, 0 }, new[] { 2, 2, 2, 2 } }, new[] { new[] { 1, 0, 0 }, new[] { 0, 0, 0 }, new[] { 0, 0, 1 } }];

        yield return [3, new[] { new[] { 0, 0, 1, 2 }, new[] { 1, 0, 2, 2 } }, new[] { new[] { 1, 1, 1 }, new[] { 2, 2, 2 }, new[] { 1, 1, 1 } }];

        yield return [3, new[] { new[] { 0, 1, 1, 2 }, new[] { 1, 0, 2, 1 } }, new[] { new[] { 0, 1, 1 }, new[] { 1, 2, 1 }, new[] { 1, 1, 0 } }];

        yield return
        [
            3,
            new[] { new[] { 0, 0, 0, 0 }, new[] { 0, 0, 0, 0 }, new[] { 0, 0, 0, 0 } },
            new[] { new[] { 3, 0, 0 }, new[] { 0, 0, 0 }, new[] { 0, 0, 0 } }
        ];

        yield return [2, new[] { new[] { 0, 0, 1, 1 }, new[] { 0, 0, 1, 1 }, new[] { 1, 1, 1, 1 } }, new[] { new[] { 2, 2 }, new[] { 2, 3 } }];

        yield return
        [
            4, new[] { new[] { 1, 1, 2, 2 } }, new[] { new[] { 0, 0, 0, 0 }, new[] { 0, 1, 1, 0 }, new[] { 0, 1, 1, 0 }, new[] { 0, 0, 0, 0 } }
        ];

        yield return
        [
            4,
            new[] { new[] { 0, 0, 3, 3 }, new[] { 1, 1, 2, 2 } },
            new[] { new[] { 1, 1, 1, 1 }, new[] { 1, 2, 2, 1 }, new[] { 1, 2, 2, 1 }, new[] { 1, 1, 1, 1 } }
        ];

        yield return
        [
            4,
            new[] { new[] { 0, 0, 0, 3 }, new[] { 3, 0, 3, 3 }, new[] { 0, 0, 3, 0 }, new[] { 0, 3, 3, 3 } },
            new[] { new[] { 2, 1, 1, 2 }, new[] { 1, 0, 0, 1 }, new[] { 1, 0, 0, 1 }, new[] { 2, 1, 1, 2 } }
        ];
    }
}