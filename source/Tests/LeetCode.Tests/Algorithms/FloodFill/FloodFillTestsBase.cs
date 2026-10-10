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

using LeetCode.Algorithms.FloodFill;

namespace LeetCode.Tests.Algorithms.FloodFill;

public abstract class FloodFillTestsBase<T> where T : IFloodFill, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void FloodFill_WithInitialPositionAndNewColor_ReturnsModifiedImage(int[][] image, int sr, int sc, int color, int[][] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FloodFill(image, sr, sc, color);

        // Assert
        Assert.AreEquivalent(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 0, 0, 0 }, new[] { 0, 0, 0 } }, 0, 0, 0, new[] { new[] { 0, 0, 0 }, new[] { 0, 0, 0 } }];

        yield return [new[] { new[] { 0, 0, 0 }, new[] { 0, 0, 0 } }, 1, 0, 2, new[] { new[] { 2, 2, 2 }, new[] { 2, 2, 2 } }];

        yield return
        [
            new[] { new[] { 1, 1, 1 }, new[] { 1, 1, 0 }, new[] { 1, 0, 1 } },
            1,
            1,
            2,
            new[] { new[] { 2, 2, 2 }, new[] { 2, 2, 0 }, new[] { 2, 0, 1 } }
        ];

        yield return [new[] { new[] { 0 } }, 0, 0, 5, new[] { new[] { 5 } }];

        yield return [new[] { new[] { 0 } }, 0, 0, 0, new[] { new[] { 0 } }];

        yield return [new[] { new[] { 2, 2, 1, 1 } }, 0, 2, 3, new[] { new[] { 2, 2, 3, 3 } }];

        yield return [new[] { new[] { 2 }, new[] { 0 }, new[] { 1 }, new[] { 1 } }, 3, 0, 9, new[] { new[] { 2 }, new[] { 0 }, new[] { 9 }, new[] { 9 } }];

        yield return [new[] { new[] { 0, 1 }, new[] { 1, 0 } }, 0, 0, 1, new[] { new[] { 1, 1 }, new[] { 1, 0 } }];

        yield return [new[] { new[] { 1, 0, 2 }, new[] { 2, 1, 2 }, new[] { 0, 1, 0 } }, 1, 1, 7, new[] { new[] { 1, 0, 2 }, new[] { 2, 7, 2 }, new[] { 0, 7, 0 } }];

        yield return [new[] { new[] { 1, 0, 0 }, new[] { 2, 2, 1 }, new[] { 2, 1, 1 } }, 0, 2, 4, new[] { new[] { 1, 4, 4 }, new[] { 2, 2, 1 }, new[] { 2, 1, 1 } }];

        yield return [new[] { new[] { 1, 1, 0, 2 }, new[] { 0, 2, 0, 1 }, new[] { 1, 2, 1, 1 }, new[] { 0, 1, 2, 2 } }, 2, 2, 8, new[] { new[] { 1, 1, 0, 2 }, new[] { 0, 2, 0, 8 }, new[] { 1, 2, 8, 8 }, new[] { 0, 1, 2, 2 } }];

        yield return [new[] { new[] { 1, 2, 1, 0, 1 }, new[] { 0, 2, 1, 2, 2 }, new[] { 2, 2, 1, 2, 2 }, new[] { 2, 1, 0, 0, 0 } }, 0, 0, 2, new[] { new[] { 2, 2, 1, 0, 1 }, new[] { 0, 2, 1, 2, 2 }, new[] { 2, 2, 1, 2, 2 }, new[] { 2, 1, 0, 0, 0 } }];

        yield return [new[] { new[] { 0, 1, 0, 0, 1 }, new[] { 0, 2, 1, 1, 2 }, new[] { 1, 0, 2, 1, 2 }, new[] { 0, 1, 1, 1, 2 }, new[] { 0, 2, 1, 0, 1 } }, 4, 4, 65535, new[] { new[] { 0, 1, 0, 0, 1 }, new[] { 0, 2, 1, 1, 2 }, new[] { 1, 0, 2, 1, 2 }, new[] { 0, 1, 1, 1, 2 }, new[] { 0, 2, 1, 0, 65535 } }];

        yield return [new[] { new[] { 0, 0, 2, 0, 2 }, new[] { 1, 2, 0, 0, 2 }, new[] { 0, 2, 2, 0, 0 }, new[] { 1, 2, 0, 1, 1 }, new[] { 1, 0, 1, 0, 0 } }, 2, 2, 0, new[] { new[] { 0, 0, 2, 0, 2 }, new[] { 1, 0, 0, 0, 2 }, new[] { 0, 0, 0, 0, 0 }, new[] { 1, 0, 0, 1, 1 }, new[] { 1, 0, 1, 0, 0 } }];

        yield return [new[] { new[] { 0, 2, 1, 1, 0, 0 }, new[] { 0, 2, 1, 0, 2, 1 }, new[] { 0, 0, 0, 2, 1, 0 }, new[] { 0, 1, 0, 1, 2, 1 }, new[] { 2, 0, 2, 0, 0, 0 }, new[] { 2, 1, 0, 2, 0, 0 } }, 3, 3, 1, new[] { new[] { 0, 2, 1, 1, 0, 0 }, new[] { 0, 2, 1, 0, 2, 1 }, new[] { 0, 0, 0, 2, 1, 0 }, new[] { 0, 1, 0, 1, 2, 1 }, new[] { 2, 0, 2, 0, 0, 0 }, new[] { 2, 1, 0, 2, 0, 0 } }];

        yield return [new[] { new[] { 1, 0, 0, 2, 0, 0 }, new[] { 1, 0, 1, 1, 0, 1 }, new[] { 2, 1, 0, 1, 2, 0 } }, 1, 4, 6, new[] { new[] { 1, 0, 0, 2, 6, 6 }, new[] { 1, 0, 1, 1, 6, 1 }, new[] { 2, 1, 0, 1, 2, 0 } }];

        yield return [new[] { new[] { 1, 0, 1 }, new[] { 2, 1, 1 }, new[] { 2, 1, 0 }, new[] { 2, 1, 0 }, new[] { 1, 1, 1 }, new[] { 2, 0, 1 } }, 5, 0, 3, new[] { new[] { 1, 0, 1 }, new[] { 2, 1, 1 }, new[] { 2, 1, 0 }, new[] { 2, 1, 0 }, new[] { 1, 1, 1 }, new[] { 3, 0, 1 } }];

        yield return [new[] { new[] { 0, 0, 0, 2, 2, 1, 0, 0 }, new[] { 1, 2, 2, 2, 0, 0, 1, 0 }, new[] { 2, 0, 0, 2, 1, 2, 1, 2 }, new[] { 2, 0, 2, 0, 0, 0, 2, 2 }, new[] { 2, 2, 2, 0, 1, 2, 0, 0 }, new[] { 2, 2, 0, 1, 0, 2, 0, 0 }, new[] { 2, 2, 2, 0, 1, 1, 2, 2 }, new[] { 0, 1, 0, 0, 2, 0, 1, 1 } }, 0, 7, 9, new[] { new[] { 0, 0, 0, 2, 2, 1, 9, 9 }, new[] { 1, 2, 2, 2, 0, 0, 1, 9 }, new[] { 2, 0, 0, 2, 1, 2, 1, 2 }, new[] { 2, 0, 2, 0, 0, 0, 2, 2 }, new[] { 2, 2, 2, 0, 1, 2, 0, 0 }, new[] { 2, 2, 0, 1, 0, 2, 0, 0 }, new[] { 2, 2, 2, 0, 1, 1, 2, 2 }, new[] { 0, 1, 0, 0, 2, 0, 1, 1 } }];

        yield return [new[] { new[] { 1, 2, 0, 0, 1, 2, 0, 2, 2, 0 }, new[] { 1, 1, 2, 0, 1, 2, 1, 1, 2, 2 }, new[] { 1, 1, 2, 2, 0, 2, 0, 0, 1, 2 }, new[] { 2, 0, 2, 0, 2, 1, 1, 1, 2, 0 }, new[] { 1, 0, 0, 1, 1, 2, 0, 1, 1, 1 }, new[] { 0, 0, 2, 2, 0, 2, 0, 2, 1, 2 }, new[] { 0, 2, 2, 2, 1, 2, 1, 2, 0, 0 }, new[] { 1, 1, 0, 2, 2, 2, 0, 1, 2, 1 }, new[] { 2, 0, 2, 0, 1, 2, 1, 2, 1, 0 }, new[] { 2, 2, 0, 1, 1, 2, 0, 1, 1, 1 } }, 5, 5, 2, new[] { new[] { 1, 2, 0, 0, 1, 2, 0, 2, 2, 0 }, new[] { 1, 1, 2, 0, 1, 2, 1, 1, 2, 2 }, new[] { 1, 1, 2, 2, 0, 2, 0, 0, 1, 2 }, new[] { 2, 0, 2, 0, 2, 1, 1, 1, 2, 0 }, new[] { 1, 0, 0, 1, 1, 2, 0, 1, 1, 1 }, new[] { 0, 0, 2, 2, 0, 2, 0, 2, 1, 2 }, new[] { 0, 2, 2, 2, 1, 2, 1, 2, 0, 0 }, new[] { 1, 1, 0, 2, 2, 2, 0, 1, 2, 1 }, new[] { 2, 0, 2, 0, 1, 2, 1, 2, 1, 0 }, new[] { 2, 2, 0, 1, 1, 2, 0, 1, 1, 1 } }];

        yield return [new[] { new[] { 2, 0, 0, 1, 2, 2, 0, 0, 2 }, new[] { 1, 0, 1, 1, 2, 0, 1, 0, 2 }, new[] { 2, 1, 0, 2, 2, 1, 0, 0, 1 }, new[] { 0, 1, 2, 0, 0, 1, 2, 0, 0 }, new[] { 0, 1, 1, 2, 2, 1, 0, 0, 1 }, new[] { 0, 0, 2, 0, 2, 2, 2, 0, 1 }, new[] { 1, 1, 0, 1, 0, 0, 1, 2, 0 } }, 3, 4, 5, new[] { new[] { 2, 0, 0, 1, 2, 2, 0, 0, 2 }, new[] { 1, 0, 1, 1, 2, 0, 1, 0, 2 }, new[] { 2, 1, 0, 2, 2, 1, 0, 0, 1 }, new[] { 0, 1, 2, 5, 5, 1, 2, 0, 0 }, new[] { 0, 1, 1, 2, 2, 1, 0, 0, 1 }, new[] { 0, 0, 2, 0, 2, 2, 2, 0, 1 }, new[] { 1, 1, 0, 1, 0, 0, 1, 2, 0 } }];
    }
}