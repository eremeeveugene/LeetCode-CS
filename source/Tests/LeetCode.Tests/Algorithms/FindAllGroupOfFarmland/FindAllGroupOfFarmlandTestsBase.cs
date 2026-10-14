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

using LeetCode.Algorithms.FindAllGroupOfFarmland;

namespace LeetCode.Tests.Algorithms.FindAllGroupOfFarmland;

public abstract class FindAllGroupOfFarmlandTestsBase<T> where T : IFindAllGroupOfFarmland, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void FindFarmland_WithLandGridInput_ReturnsTopLeftAndBottomRightCoordinatesOfFarmlandGroups(int[][] land, int[][] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindFarmland(land);

        // Assert
        Assert.AreEquivalent(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 0 } }, Array.Empty<int[]>()];

        yield return [new[] { new[] { 1, 1 }, new[] { 0, 0 } }, new[] { new[] { 0, 0, 0, 1 } }];

        yield return [new[] { new[] { 1, 1 }, new[] { 1, 1 } }, new[] { new[] { 0, 0, 1, 1 } }];

        yield return [new[] { new[] { 0, 1 }, new[] { 0, 1 } }, new[] { new[] { 0, 1, 1, 1 } }];

        yield return [new[] { new[] { 1, 0, 0 }, new[] { 0, 1, 1 }, new[] { 0, 1, 1 } }, new[] { new[] { 0, 0, 0, 0 }, new[] { 1, 1, 2, 2 } }];

        yield return
        [
            new[] { new[] { 0, 0, 0, 0, 0 }, new[] { 0, 1, 1, 1, 0 }, new[] { 0, 1, 1, 1, 0 }, new[] { 0, 1, 1, 1, 0 }, new[] { 0, 0, 0, 0, 0 } },
            new[] { new[] { 1, 1, 3, 3 } }
        ];

        yield return [new[] { new[] { 1 } }, new[] { new[] { 0, 0, 0, 0 } }];

        yield return [new[] { new[] { 0, 0, 0, 1, 1 } }, new[] { new[] { 0, 3, 0, 4 } }];

        yield return [new[] { new[] { 0 }, new[] { 1 }, new[] { 1 }, new[] { 0 }, new[] { 1 } }, new[] { new[] { 1, 0, 2, 0 }, new[] { 4, 0, 4, 0 } }];

        yield return [new[] { new[] { 0, 1, 0 }, new[] { 0, 0, 0 }, new[] { 0, 1, 0 } }, new[] { new[] { 0, 1, 0, 1 }, new[] { 2, 1, 2, 1 } }];

        yield return [new[] { new[] { 0, 0, 0, 1 }, new[] { 1, 1, 1, 0 }, new[] { 0, 0, 0, 0 }, new[] { 0, 0, 1, 1 } }, new[] { new[] { 0, 3, 0, 3 }, new[] { 1, 0, 1, 2 }, new[] { 3, 2, 3, 3 } }];

        yield return [new[] { new[] { 1, 0, 1, 0, 0 }, new[] { 1, 0, 1, 0, 1 }, new[] { 1, 0, 0, 0, 1 }, new[] { 0, 0, 0, 0, 0 }, new[] { 1, 1, 1, 0, 0 } }, new[] { new[] { 0, 0, 2, 0 }, new[] { 0, 2, 1, 2 }, new[] { 1, 4, 2, 4 }, new[] { 4, 0, 4, 2 } }];

        yield return [new[] { new[] { 1, 0, 0, 0, 0, 0 }, new[] { 1, 0, 0, 1, 0, 1 }, new[] { 1, 0, 0, 0, 0, 1 }, new[] { 0, 0, 0, 0, 0, 1 }, new[] { 0, 0, 0, 0, 0, 0 }, new[] { 0, 1, 1, 0, 0, 0 } }, new[] { new[] { 0, 0, 2, 0 }, new[] { 1, 3, 1, 3 }, new[] { 1, 5, 3, 5 }, new[] { 5, 1, 5, 2 } }];

        yield return [new[] { new[] { 1, 0, 0, 0, 0, 0, 1 }, new[] { 1, 0, 0, 1, 0, 0, 1 }, new[] { 1, 0, 0, 0, 1, 0, 1 } }, new[] { new[] { 0, 0, 2, 0 }, new[] { 0, 6, 2, 6 }, new[] { 1, 3, 1, 3 }, new[] { 2, 4, 2, 4 } }];

        yield return [new[] { new[] { 0, 0, 0 }, new[] { 1, 1, 0 }, new[] { 0, 0, 0 }, new[] { 0, 0, 0 }, new[] { 1, 1, 1 }, new[] { 0, 0, 0 }, new[] { 0, 1, 1 } }, new[] { new[] { 1, 0, 1, 1 }, new[] { 4, 0, 4, 2 }, new[] { 6, 1, 6, 2 } }];

        yield return [new[] { new[] { 0, 0, 0, 0, 0, 0, 0, 1 }, new[] { 0, 0, 0, 0, 1, 0, 0, 1 }, new[] { 0, 1, 1, 1, 0, 0, 0, 0 }, new[] { 0, 1, 1, 1, 0, 0, 0, 0 }, new[] { 0, 0, 0, 0, 0, 0, 0, 1 }, new[] { 0, 0, 0, 1, 1, 0, 0, 1 }, new[] { 0, 0, 0, 0, 0, 0, 0, 1 }, new[] { 0, 1, 1, 1, 0, 1, 0, 0 } }, new[] { new[] { 0, 7, 1, 7 }, new[] { 1, 4, 1, 4 }, new[] { 2, 1, 3, 3 }, new[] { 4, 7, 6, 7 }, new[] { 5, 3, 5, 4 }, new[] { 7, 1, 7, 3 }, new[] { 7, 5, 7, 5 } }];

        yield return [new[] { new[] { 0, 1, 0, 0, 0, 0, 0, 1, 1, 1 }, new[] { 0, 1, 0, 0, 0, 1, 0, 1, 1, 1 }, new[] { 0, 1, 0, 0, 0, 1, 0, 0, 0, 0 }, new[] { 0, 0, 0, 0, 0, 1, 0, 1, 1, 1 }, new[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1 }, new[] { 0, 0, 1, 1, 1, 0, 0, 0, 0, 0 }, new[] { 0, 0, 1, 1, 1, 0, 0, 1, 0, 1 }, new[] { 0, 0, 0, 0, 0, 1, 1, 0, 0, 0 }, new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new[] { 0, 1, 0, 1, 0, 1, 1, 1, 0, 1 } }, new[] { new[] { 0, 1, 2, 1 }, new[] { 0, 7, 1, 9 }, new[] { 1, 5, 3, 5 }, new[] { 3, 7, 4, 9 }, new[] { 5, 2, 6, 4 }, new[] { 6, 7, 6, 7 }, new[] { 6, 9, 6, 9 }, new[] { 7, 5, 7, 6 }, new[] { 9, 1, 9, 1 }, new[] { 9, 3, 9, 3 }, new[] { 9, 5, 9, 7 }, new[] { 9, 9, 9, 9 } }];

        yield return [new[] { new[] { 0, 0 }, new[] { 0, 1 } }, new[] { new[] { 1, 1, 1, 1 } }];

        yield return [new[] { new[] { 0, 0, 0, 0, 1, 0 }, new[] { 0, 0, 0, 0, 0, 1 }, new[] { 0, 0, 0, 0, 0, 0 }, new[] { 0, 0, 1, 0, 1, 1 } }, new[] { new[] { 0, 4, 0, 4 }, new[] { 1, 5, 1, 5 }, new[] { 3, 2, 3, 2 }, new[] { 3, 4, 3, 5 } }];

        yield return [new[] { new[] { 0, 0, 1, 0 }, new[] { 0, 0, 1, 0 }, new[] { 1, 1, 0, 1 }, new[] { 1, 1, 0, 1 }, new[] { 1, 1, 0, 0 }, new[] { 0, 0, 0, 0 } }, new[] { new[] { 0, 2, 1, 2 }, new[] { 2, 0, 4, 1 }, new[] { 2, 3, 3, 3 } }];
    }
}