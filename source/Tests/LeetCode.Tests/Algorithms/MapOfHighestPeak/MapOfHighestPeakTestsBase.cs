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

using LeetCode.Algorithms.MapOfHighestPeak;

namespace LeetCode.Tests.Algorithms.MapOfHighestPeak;

public abstract class MapOfHighestPeakTestsBase<T> where T : IMapOfHighestPeak, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void HighestPeak_WithBinaryWaterLandMatrix_ReturnsHeightAssignmentWithMaximizedPeak(int[][] isWater, int[][] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.HighestPeak(isWater);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 0, 1 }, new[] { 0, 0 } }, new[] { new[] { 1, 0 }, new[] { 2, 1 } }];
        yield return
        [
            new[] { new[] { 0, 0, 1 }, new[] { 1, 0, 0 }, new[] { 0, 0, 0 } }, new[] { new[] { 1, 1, 0 }, new[] { 0, 1, 1 }, new[] { 1, 2, 2 } }
        ];
        yield return [new[] { new[] { 1 } }, new[] { new[] { 0 } }];
        yield return [new[] { new[] { 1, 0 } }, new[] { new[] { 0, 1 } }];
        yield return [new[] { new[] { 0, 1 } }, new[] { new[] { 1, 0 } }];
        yield return [new[] { new[] { 1 }, new[] { 0 } }, new[] { new[] { 0 }, new[] { 1 } }];
        yield return [new[] { new[] { 0 }, new[] { 1 } }, new[] { new[] { 1 }, new[] { 0 } }];
        yield return [new[] { new[] { 1 }, new[] { 0 }, new[] { 0 } }, new[] { new[] { 0 }, new[] { 1 }, new[] { 2 } }];
        yield return [new[] { new[] { 0, 0, 0, 1 } }, new[] { new[] { 3, 2, 1, 0 } }];
        yield return [new[] { new[] { 1, 1, 1 } }, new[] { new[] { 0, 0, 0 } }];
        yield return [new[] { new[] { 1, 0, 1 } }, new[] { new[] { 0, 1, 0 } }];
        yield return [new[] { new[] { 0 }, new[] { 1 }, new[] { 0 } }, new[] { new[] { 1 }, new[] { 0 }, new[] { 1 } }];
        yield return [new[] { new[] { 1, 1 }, new[] { 1, 1 } }, new[] { new[] { 0, 0 }, new[] { 0, 0 } }];
        yield return [new[] { new[] { 1, 0, 0, 0, 1 } }, new[] { new[] { 0, 1, 2, 1, 0 } }];
        yield return
        [
            new[] { new[] { 0, 0, 0 }, new[] { 0, 1, 0 }, new[] { 0, 0, 0 } }, new[] { new[] { 2, 1, 2 }, new[] { 1, 0, 1 }, new[] { 2, 1, 2 } }
        ];
        yield return
        [
            new[] { new[] { 1, 0, 0 }, new[] { 0, 0, 0 }, new[] { 0, 0, 1 } }, new[] { new[] { 0, 1, 2 }, new[] { 1, 2, 1 }, new[] { 2, 1, 0 } }
        ];
        yield return [new[] { new[] { 0, 0 }, new[] { 0, 0 }, new[] { 0, 1 } }, new[] { new[] { 3, 2 }, new[] { 2, 1 }, new[] { 1, 0 } }];
        yield return [new[] { new[] { 1, 0, 0, 0 } }, new[] { new[] { 0, 1, 2, 3 } }];
        yield return [new[] { new[] { 1 }, new[] { 0 }, new[] { 0 }, new[] { 0 } }, new[] { new[] { 0 }, new[] { 1 }, new[] { 2 }, new[] { 3 } }];
        yield return
        [
            new[] { new[] { 0, 1, 0 }, new[] { 0, 0, 0 }, new[] { 0, 1, 0 } }, new[] { new[] { 1, 0, 1 }, new[] { 2, 1, 2 }, new[] { 1, 0, 1 } }
        ];
        yield return
        [
            new[] { new[] { 0, 0, 0 }, new[] { 0, 0, 0 }, new[] { 0, 0, 1 } }, new[] { new[] { 4, 3, 2 }, new[] { 3, 2, 1 }, new[] { 2, 1, 0 } }
        ];
        yield return
        [
            new[] { new[] { 1, 0, 0 }, new[] { 0, 0, 0 }, new[] { 0, 0, 0 } }, new[] { new[] { 0, 1, 2 }, new[] { 1, 2, 3 }, new[] { 2, 3, 4 } }
        ];
        yield return
        [
            new[] { new[] { 1, 1, 1, 1 }, new[] { 1, 0, 0, 1 }, new[] { 1, 0, 0, 1 }, new[] { 1, 1, 1, 1 } },
            new[] { new[] { 0, 0, 0, 0 }, new[] { 0, 1, 1, 0 }, new[] { 0, 1, 1, 0 }, new[] { 0, 0, 0, 0 } }
        ];
        yield return
        [
            new[] { new[] { 1, 0, 1 }, new[] { 0, 0, 0 }, new[] { 1, 0, 1 } }, new[] { new[] { 0, 1, 0 }, new[] { 1, 2, 1 }, new[] { 0, 1, 0 } }
        ];
    }
}