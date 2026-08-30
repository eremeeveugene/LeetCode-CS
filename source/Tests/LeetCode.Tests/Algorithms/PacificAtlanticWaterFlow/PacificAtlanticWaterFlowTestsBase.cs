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

using LeetCode.Algorithms.PacificAtlanticWaterFlow;

namespace LeetCode.Tests.Algorithms.PacificAtlanticWaterFlow;

public abstract class PacificAtlanticWaterFlowTestsBase<T> where T : IPacificAtlanticWaterFlow, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void PacificAtlantic_WithGivenHeightGrid_ReturnsCoordinatesReachingBothOceans(int[][] heights, int[][] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.PacificAtlantic(heights);

        // Assert
        Assert.AreEquivalent<IEnumerable<IEnumerable<int>>>(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1 } }, new[] { new[] { 0, 0 } }];
        yield return [new[] { new[] { 0 } }, new[] { new[] { 0, 0 } }];
        yield return [new[] { new[] { 1, 2 } }, new[] { new[] { 0, 0 }, new[] { 0, 1 } }];
        yield return [new[] { new[] { 4, 1, 3, 2 } }, new[] { new[] { 0, 0 }, new[] { 0, 1 }, new[] { 0, 2 }, new[] { 0, 3 } }];
        yield return [new[] { new[] { 1 }, new[] { 2 } }, new[] { new[] { 0, 0 }, new[] { 1, 0 } }];
        yield return
        [
            new[] { new[] { 4 }, new[] { 1 }, new[] { 3 }, new[] { 2 } }, new[] { new[] { 0, 0 }, new[] { 1, 0 }, new[] { 2, 0 }, new[] { 3, 0 } }
        ];
        yield return [new[] { new[] { 1, 1 }, new[] { 1, 1 } }, new[] { new[] { 0, 0 }, new[] { 0, 1 }, new[] { 1, 0 }, new[] { 1, 1 } }];
        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 } }, new[] { new[] { 0, 1 }, new[] { 1, 0 }, new[] { 1, 1 } }];
        yield return [new[] { new[] { 4, 3 }, new[] { 2, 1 } }, new[] { new[] { 0, 0 }, new[] { 0, 1 }, new[] { 1, 0 } }];
        yield return [new[] { new[] { 1, 4 }, new[] { 3, 2 } }, new[] { new[] { 0, 1 }, new[] { 1, 0 } }];

        yield return
        [
            new[] { new[] { 1, 2, 2, 3, 5 }, new[] { 3, 2, 3, 4, 4 }, new[] { 2, 4, 5, 3, 1 }, new[] { 6, 7, 1, 4, 5 }, new[] { 5, 1, 1, 2, 4 } },
            new[] { new[] { 0, 4 }, new[] { 1, 3 }, new[] { 1, 4 }, new[] { 2, 2 }, new[] { 3, 0 }, new[] { 3, 1 }, new[] { 4, 0 } }
        ];

        yield return
        [
            new[] { new[] { 5, 5, 5 }, new[] { 5, 5, 5 }, new[] { 5, 5, 5 } },
            new[]
            {
                new[] { 0, 0 },
                new[] { 0, 1 },
                new[] { 0, 2 },
                new[] { 1, 0 },
                new[] { 1, 1 },
                new[] { 1, 2 },
                new[] { 2, 0 },
                new[] { 2, 1 },
                new[] { 2, 2 }
            }
        ];

        yield return
        [
            new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } },
            new[] { new[] { 0, 2 }, new[] { 1, 2 }, new[] { 2, 0 }, new[] { 2, 1 }, new[] { 2, 2 } }
        ];
        yield return
        [
            new[] { new[] { 9, 8, 7 }, new[] { 6, 5, 4 }, new[] { 3, 2, 1 } },
            new[] { new[] { 0, 0 }, new[] { 0, 1 }, new[] { 0, 2 }, new[] { 1, 0 }, new[] { 2, 0 } }
        ];
        yield return
        [
            new[] { new[] { 1, 1, 1 }, new[] { 1, 9, 1 }, new[] { 1, 1, 1 } },
            new[]
            {
                new[] { 0, 0 },
                new[] { 0, 1 },
                new[] { 0, 2 },
                new[] { 1, 0 },
                new[] { 1, 1 },
                new[] { 1, 2 },
                new[] { 2, 0 },
                new[] { 2, 1 },
                new[] { 2, 2 }
            }
        ];
        yield return
        [
            new[] { new[] { 9, 9, 9 }, new[] { 9, 1, 9 }, new[] { 9, 9, 9 } },
            new[]
            {
                new[] { 0, 0 }, new[] { 0, 1 }, new[] { 0, 2 }, new[] { 1, 0 }, new[] { 1, 2 }, new[] { 2, 0 }, new[] { 2, 1 }, new[] { 2, 2 }
            }
        ];
        yield return
        [
            new[] { new[] { 1, 2, 2 }, new[] { 3, 2, 3 }, new[] { 2, 4, 5 } },
            new[]
            {
                new[] { 0, 1 }, new[] { 0, 2 }, new[] { 1, 0 }, new[] { 1, 1 }, new[] { 1, 2 }, new[] { 2, 0 }, new[] { 2, 1 }, new[] { 2, 2 }
            }
        ];
        yield return
        [
            new[] { new[] { 10, 10, 10 }, new[] { 10, 0, 10 }, new[] { 10, 10, 10 } },
            new[]
            {
                new[] { 0, 0 }, new[] { 0, 1 }, new[] { 0, 2 }, new[] { 1, 0 }, new[] { 1, 2 }, new[] { 2, 0 }, new[] { 2, 1 }, new[] { 2, 2 }
            }
        ];
        yield return
        [
            new[] { new[] { 1, 2, 3 }, new[] { 1, 2, 3 }, new[] { 1, 2, 3 } },
            new[]
            {
                new[] { 0, 0 },
                new[] { 0, 1 },
                new[] { 0, 2 },
                new[] { 1, 0 },
                new[] { 1, 1 },
                new[] { 1, 2 },
                new[] { 2, 0 },
                new[] { 2, 1 },
                new[] { 2, 2 }
            }
        ];
        yield return
        [
            new[] { new[] { 1, 1, 1 }, new[] { 2, 2, 2 }, new[] { 3, 3, 3 } },
            new[]
            {
                new[] { 0, 0 },
                new[] { 0, 1 },
                new[] { 0, 2 },
                new[] { 1, 0 },
                new[] { 1, 1 },
                new[] { 1, 2 },
                new[] { 2, 0 },
                new[] { 2, 1 },
                new[] { 2, 2 }
            }
        ];
        yield return
        [
            new[] { new[] { 1, 9, 1 }, new[] { 9, 1, 9 }, new[] { 1, 9, 1 } },
            new[] { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 1, 0 }, new[] { 1, 2 }, new[] { 2, 0 }, new[] { 2, 1 } }
        ];
        yield return
        [
            new[] { new[] { 1, 2, 3, 4 }, new[] { 2, 1, 4, 3 }, new[] { 3, 5, 2, 1 } },
            new[] { new[] { 0, 3 }, new[] { 1, 2 }, new[] { 2, 0 }, new[] { 2, 1 } }
        ];
        yield return
        [
            new[] { new[] { 8, 7, 6 }, new[] { 5, 4, 3 }, new[] { 2, 1, 0 }, new[] { 3, 6, 9 } },
            new[]
            {
                new[] { 0, 0 }, new[] { 0, 1 }, new[] { 0, 2 }, new[] { 1, 0 }, new[] { 2, 0 }, new[] { 3, 0 }, new[] { 3, 1 }, new[] { 3, 2 }
            }
        ];

        yield return
        [
            new[] { new[] { 0, 0, 0, 0 }, new[] { 0, 0, 0, 0 }, new[] { 0, 0, 0, 0 }, new[] { 0, 0, 0, 0 } },
            new[]
            {
                new[] { 0, 0 },
                new[] { 0, 1 },
                new[] { 0, 2 },
                new[] { 0, 3 },
                new[] { 1, 0 },
                new[] { 1, 1 },
                new[] { 1, 2 },
                new[] { 1, 3 },
                new[] { 2, 0 },
                new[] { 2, 1 },
                new[] { 2, 2 },
                new[] { 2, 3 },
                new[] { 3, 0 },
                new[] { 3, 1 },
                new[] { 3, 2 },
                new[] { 3, 3 }
            }
        ];

        yield return
        [
            new[] { new[] { 100_000, 0, 100_000 }, new[] { 0, 100_000, 0 } },
            new[] { new[] { 0, 0 }, new[] { 0, 2 }, new[] { 1, 0 }, new[] { 1, 1 } }
        ];
    }
}