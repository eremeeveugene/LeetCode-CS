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

using LeetCode.Algorithms.MaximumNumberOfKDivisibleComponents;

namespace LeetCode.Tests.Algorithms.MaximumNumberOfKDivisibleComponents;

public abstract class MaximumNumberOfKDivisibleComponentsTestsBase<T> where T : IMaximumNumberOfKDivisibleComponents, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void MaxKDivisibleComponents_WithGraphEdgesAndValues_ReturnsComponentCount(int n, int[][] edges, int[] values, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxKDivisibleComponents(n, edges, values, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [5, new[] { new[] { 0, 2 }, new[] { 1, 2 }, new[] { 1, 3 }, new[] { 2, 4 } }, new[] { 1, 8, 1, 4, 4 }, 6, 2];

        yield return
        [
            7,
            new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 1, 3 }, new[] { 1, 4 }, new[] { 2, 5 }, new[] { 2, 6 } },
            new[] { 3, 0, 6, 1, 5, 2, 1 },
            3,
            3
        ];

        yield return [1, Array.Empty<int[]>(), new[] { 5 }, 3, 0];

        yield return [4, new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 1, 3 } }, new[] { 6, 3, 3, 3 }, 3, 4];

        yield return [6, new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 2, 3 }, new[] { 2, 4 }, new[] { 4, 5 } }, new[] { 4, 2, 2, 1, 3, 1 }, 4, 1];

        yield return [3, new[] { new[] { 0, 1 }, new[] { 1, 2 } }, new[] { 1, 1, 1 }, 2, 1];

        yield return [5, new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 } }, new[] { 2, 2, 2, 2, 2 }, 2, 5];

        yield return [2, new[] { new[] { 0, 1 } }, new[] { 4, 4 }, 4, 2];

        yield return
        [
            7,
            new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 1, 3 }, new[] { 1, 4 }, new[] { 2, 5 }, new[] { 2, 6 } },
            new[] { 1, 2, 3, 4, 5, 6, 7 },
            5,
            1
        ];

        yield return [4, new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 2, 3 } }, new[] { 5, 5, 5, 5 }, 5, 4];

        yield return [6, new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 1, 3 }, new[] { 3, 4 }, new[] { 3, 5 } }, new[] { 2, 4, 2, 6, 3, 3 }, 2, 4];

        yield return [1, Array.Empty<int[]>(), new[] { 6 }, 3, 1];

        yield return [1, Array.Empty<int[]>(), new[] { 6 }, 4, 0];

        yield return
        [
            8,
            new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 1, 3 }, new[] { 1, 4 }, new[] { 2, 5 }, new[] { 2, 6 }, new[] { 6, 7 } },
            new[] { 1, 1, 1, 1, 1, 1, 1, 1 },
            1,
            8
        ];

        yield return [5, new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 0, 3 }, new[] { 0, 4 } }, new[] { 3, 3, 3, 3, 3 }, 3, 5];

        yield return [6, new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 }, new[] { 4, 5 } }, new[] { 1, 2, 3, 4, 5, 6 }, 3, 4];

        yield return [3, new[] { new[] { 0, 1 }, new[] { 0, 2 } }, new[] { 5, 7, 2 }, 7, 2];

        yield return
        [
            9,
            new[]
            {
                new[] { 0, 1 }, new[] { 1, 2 }, new[] { 1, 3 }, new[] { 0, 4 }, new[] { 4, 5 }, new[] { 4, 6 }, new[] { 6, 7 }, new[] { 6, 8 }
            },
            new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            6,
            2
        ];

        yield return [2, new[] { new[] { 0, 1 } }, new[] { 3, 5 }, 4, 1];

        yield return [4, new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 0, 3 } }, new[] { 4, 4, 4, 4 }, 4, 4];

        yield return
        [
            10,
            new[]
            {
                new[] { 0, 1 },
                new[] { 1, 2 },
                new[] { 2, 3 },
                new[] { 3, 4 },
                new[] { 4, 5 },
                new[] { 5, 6 },
                new[] { 6, 7 },
                new[] { 7, 8 },
                new[] { 8, 9 }
            },
            new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
            2,
            5
        ];

        yield return [5, new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 1, 3 }, new[] { 3, 4 } }, new[] { 2, 3, 5, 7, 1 }, 6, 1];

        yield return [6, new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 1, 3 }, new[] { 2, 4 }, new[] { 2, 5 } }, new[] { 9, 3, 6, 1, 2, 4 }, 3, 1];

        yield return
        [
            7,
            new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 0, 3 }, new[] { 3, 4 }, new[] { 3, 5 }, new[] { 3, 6 } },
            new[] { 1, 1, 1, 3, 1, 1, 1 },
            1,
            7
        ];

        yield return [3, new[] { new[] { 0, 1 }, new[] { 1, 2 } }, new[] { 4, 4, 4 }, 5, 0];
    }
}