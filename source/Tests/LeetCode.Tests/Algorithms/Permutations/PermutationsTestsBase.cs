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

using LeetCode.Algorithms.Permutations;

namespace LeetCode.Tests.Algorithms.Permutations;

public abstract class PermutationsTestsBase<T> where T : IPermutations, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void Permute_WithDifferentArraySizes_ReturnsAllPermutations(int[] nums, int[][] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.Permute(nums);

        // Assert
        Assert.AreEquivalent<IEnumerable<IEnumerable<int>>>(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { 0 }, new[] { new[] { 0 } }];

        yield return [new[] { 0, 1 }, new[] { new[] { 0, 1 }, new[] { 1, 0 } }];

        yield return
        [
            new[] { 0, 1, 2 },
            new[] { new[] { 0, 1, 2 }, new[] { 0, 2, 1 }, new[] { 1, 0, 2 }, new[] { 1, 2, 0 }, new[] { 2, 1, 0 }, new[] { 2, 0, 1 } }
        ];

        yield return [new[] { 5 }, new[] { new[] { 5 } }];

        yield return [new[] { -10 }, new[] { new[] { -10 } }];

        yield return [new[] { 10 }, new[] { new[] { 10 } }];

        yield return [new[] { 1, 2 }, new[] { new[] { 1, 2 }, new[] { 2, 1 } }];

        yield return [new[] { -1, 1 }, new[] { new[] { -1, 1 }, new[] { 1, -1 } }];

        yield return [new[] { 3, -3 }, new[] { new[] { 3, -3 }, new[] { -3, 3 } }];

        yield return [new[] { 0, 10 }, new[] { new[] { 0, 10 }, new[] { 10, 0 } }];

        yield return [new[] { 10, -10 }, new[] { new[] { 10, -10 }, new[] { -10, 10 } }];

        yield return [new[] { 1, 2, 3 }, new[] { new[] { 1, 2, 3 }, new[] { 1, 3, 2 }, new[] { 2, 1, 3 }, new[] { 2, 3, 1 }, new[] { 3, 2, 1 }, new[] { 3, 1, 2 } }];

        yield return [new[] { 3, 2, 1 }, new[] { new[] { 3, 2, 1 }, new[] { 3, 1, 2 }, new[] { 2, 3, 1 }, new[] { 2, 1, 3 }, new[] { 1, 2, 3 }, new[] { 1, 3, 2 } }];

        yield return [new[] { -1, 0, 1 }, new[] { new[] { -1, 0, 1 }, new[] { -1, 1, 0 }, new[] { 0, -1, 1 }, new[] { 0, 1, -1 }, new[] { 1, 0, -1 }, new[] { 1, -1, 0 } }];

        yield return [new[] { 5, -5, 0 }, new[] { new[] { 5, -5, 0 }, new[] { 5, 0, -5 }, new[] { -5, 5, 0 }, new[] { -5, 0, 5 }, new[] { 0, -5, 5 }, new[] { 0, 5, -5 } }];

        yield return [new[] { 10, -10, 0 }, new[] { new[] { 10, -10, 0 }, new[] { 10, 0, -10 }, new[] { -10, 10, 0 }, new[] { -10, 0, 10 }, new[] { 0, -10, 10 }, new[] { 0, 10, -10 } }];

        yield return [new[] { 7, 8, 9 }, new[] { new[] { 7, 8, 9 }, new[] { 7, 9, 8 }, new[] { 8, 7, 9 }, new[] { 8, 9, 7 }, new[] { 9, 8, 7 }, new[] { 9, 7, 8 } }];

        yield return
        [
            new[] { 1, 2, 3, 4 },
            new[]
            {
                new[] { 1, 2, 3, 4 }, new[] { 1, 2, 4, 3 }, new[] { 1, 3, 2, 4 }, new[] { 1, 3, 4, 2 },
                new[] { 1, 4, 3, 2 }, new[] { 1, 4, 2, 3 }, new[] { 2, 1, 3, 4 }, new[] { 2, 1, 4, 3 },
                new[] { 2, 3, 1, 4 }, new[] { 2, 3, 4, 1 }, new[] { 2, 4, 3, 1 }, new[] { 2, 4, 1, 3 },
                new[] { 3, 2, 1, 4 }, new[] { 3, 2, 4, 1 }, new[] { 3, 1, 2, 4 }, new[] { 3, 1, 4, 2 },
                new[] { 3, 4, 1, 2 }, new[] { 3, 4, 2, 1 }, new[] { 4, 2, 3, 1 }, new[] { 4, 2, 1, 3 },
                new[] { 4, 3, 2, 1 }, new[] { 4, 3, 1, 2 }, new[] { 4, 1, 3, 2 }, new[] { 4, 1, 2, 3 }
            }
        ];

        yield return
        [
            new[] { 4, 3, 2, 1 },
            new[]
            {
                new[] { 4, 3, 2, 1 }, new[] { 4, 3, 1, 2 }, new[] { 4, 2, 3, 1 }, new[] { 4, 2, 1, 3 },
                new[] { 4, 1, 2, 3 }, new[] { 4, 1, 3, 2 }, new[] { 3, 4, 2, 1 }, new[] { 3, 4, 1, 2 },
                new[] { 3, 2, 4, 1 }, new[] { 3, 2, 1, 4 }, new[] { 3, 1, 2, 4 }, new[] { 3, 1, 4, 2 },
                new[] { 2, 3, 4, 1 }, new[] { 2, 3, 1, 4 }, new[] { 2, 4, 3, 1 }, new[] { 2, 4, 1, 3 },
                new[] { 2, 1, 4, 3 }, new[] { 2, 1, 3, 4 }, new[] { 1, 3, 2, 4 }, new[] { 1, 3, 4, 2 },
                new[] { 1, 2, 3, 4 }, new[] { 1, 2, 4, 3 }, new[] { 1, 4, 2, 3 }, new[] { 1, 4, 3, 2 }
            }
        ];

        yield return
        [
            new[] { -1, 0, 1, 2 },
            new[]
            {
                new[] { -1, 0, 1, 2 }, new[] { -1, 0, 2, 1 }, new[] { -1, 1, 0, 2 }, new[] { -1, 1, 2, 0 },
                new[] { -1, 2, 1, 0 }, new[] { -1, 2, 0, 1 }, new[] { 0, -1, 1, 2 }, new[] { 0, -1, 2, 1 },
                new[] { 0, 1, -1, 2 }, new[] { 0, 1, 2, -1 }, new[] { 0, 2, 1, -1 }, new[] { 0, 2, -1, 1 },
                new[] { 1, 0, -1, 2 }, new[] { 1, 0, 2, -1 }, new[] { 1, -1, 0, 2 }, new[] { 1, -1, 2, 0 },
                new[] { 1, 2, -1, 0 }, new[] { 1, 2, 0, -1 }, new[] { 2, 0, 1, -1 }, new[] { 2, 0, -1, 1 },
                new[] { 2, 1, 0, -1 }, new[] { 2, 1, -1, 0 }, new[] { 2, -1, 1, 0 }, new[] { 2, -1, 0, 1 }
            }
        ];

        yield return
        [
            new[] { -10, 10, -5, 5 },
            new[]
            {
                new[] { -10, 10, -5, 5 }, new[] { -10, 10, 5, -5 }, new[] { -10, -5, 10, 5 }, new[] { -10, -5, 5, 10 },
                new[] { -10, 5, -5, 10 }, new[] { -10, 5, 10, -5 }, new[] { 10, -10, -5, 5 }, new[] { 10, -10, 5, -5 },
                new[] { 10, -5, -10, 5 }, new[] { 10, -5, 5, -10 }, new[] { 10, 5, -5, -10 }, new[] { 10, 5, -10, -5 },
                new[] { -5, 10, -10, 5 }, new[] { -5, 10, 5, -10 }, new[] { -5, -10, 10, 5 }, new[] { -5, -10, 5, 10 },
                new[] { -5, 5, -10, 10 }, new[] { -5, 5, 10, -10 }, new[] { 5, 10, -5, -10 }, new[] { 5, 10, -10, -5 },
                new[] { 5, -5, 10, -10 }, new[] { 5, -5, -10, 10 }, new[] { 5, -10, -5, 10 }, new[] { 5, -10, 10, -5 }
            }
        ];

        yield return
        [
            new[] { 0, 1, 2, 3 },
            new[]
            {
                new[] { 0, 1, 2, 3 }, new[] { 0, 1, 3, 2 }, new[] { 0, 2, 1, 3 }, new[] { 0, 2, 3, 1 },
                new[] { 0, 3, 2, 1 }, new[] { 0, 3, 1, 2 }, new[] { 1, 0, 2, 3 }, new[] { 1, 0, 3, 2 },
                new[] { 1, 2, 0, 3 }, new[] { 1, 2, 3, 0 }, new[] { 1, 3, 2, 0 }, new[] { 1, 3, 0, 2 },
                new[] { 2, 1, 0, 3 }, new[] { 2, 1, 3, 0 }, new[] { 2, 0, 1, 3 }, new[] { 2, 0, 3, 1 },
                new[] { 2, 3, 0, 1 }, new[] { 2, 3, 1, 0 }, new[] { 3, 1, 2, 0 }, new[] { 3, 1, 0, 2 },
                new[] { 3, 2, 1, 0 }, new[] { 3, 2, 0, 1 }, new[] { 3, 0, 2, 1 }, new[] { 3, 0, 1, 2 }
            }
        ];

        yield return
        [
            new[] { 2, 4, 6, 8 },
            new[]
            {
                new[] { 2, 4, 6, 8 }, new[] { 2, 4, 8, 6 }, new[] { 2, 6, 4, 8 }, new[] { 2, 6, 8, 4 },
                new[] { 2, 8, 6, 4 }, new[] { 2, 8, 4, 6 }, new[] { 4, 2, 6, 8 }, new[] { 4, 2, 8, 6 },
                new[] { 4, 6, 2, 8 }, new[] { 4, 6, 8, 2 }, new[] { 4, 8, 6, 2 }, new[] { 4, 8, 2, 6 },
                new[] { 6, 4, 2, 8 }, new[] { 6, 4, 8, 2 }, new[] { 6, 2, 4, 8 }, new[] { 6, 2, 8, 4 },
                new[] { 6, 8, 2, 4 }, new[] { 6, 8, 4, 2 }, new[] { 8, 4, 6, 2 }, new[] { 8, 4, 2, 6 },
                new[] { 8, 6, 4, 2 }, new[] { 8, 6, 2, 4 }, new[] { 8, 2, 6, 4 }, new[] { 8, 2, 4, 6 }
            }
        ];
    }
}