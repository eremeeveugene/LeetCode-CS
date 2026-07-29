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

using LeetCode.Algorithms.WalkingRobotSimulation;

namespace LeetCode.Tests.Algorithms.WalkingRobotSimulation;

public abstract class WalkingRobotSimulationTestsBase<T> where T : IWalkingRobotSimulation, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void RobotSim_WithMovementCommandsAndObstacles_ReturnsMaxSquaredDistanceFromOrigin(int[] commands, int[][] obstacles, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RobotSim(commands, obstacles);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { 4, -1, 3 }, Array.Empty<int[]>(), 25];

        yield return [new[] { 4, -1, 4, -2, 4 }, new[] { new[] { 2, 4 } }, 65];

        yield return [new[] { 6, -1, -1, 6 }, Array.Empty<int[]>(), 36];

        yield return
        [
            new[] { -2, 8, 3, 7, -1 },
            new[]
            {
                new[] { -4, -1 },
                new[] { 1, -1 },
                new[] { 1, 4 },
                new[] { 5, 0 },
                new[] { 4, 5 },
                new[] { -2, -1 },
                new[] { 2, -5 },
                new[] { 5, 1 },
                new[] { -3, -1 },
                new[] { 5, -3 }
            },
            324
        ];

        yield return [new[] { 9, -1, 9, -2, 3 }, new[] { new[] { 4, 8 }, new[] { 5, 6 }, new[] { 7, 7 }, new[] { 8, 4 } }, 225];

        yield return [new[] { 1 }, new[] { new[] { 2, 2 }, new[] { 3, 3 } }, 1];

        yield return
        [
            new[] { 9, -1, 9, 9, -2, 9, 9, -1, 9, 9, -2, 9, 9, 9, -1, 9, 9, -2, 9, 9, -1, -1, 9, 9 },
            new[] { new[] { 10, 10 }, new[] { 5, 5 }, new[] { 8, 8 }, new[] { 15, 15 }, new[] { 20, 20 } },
            8100
        ];

        yield return [new[] { 1 }, Array.Empty<int[]>(), 1];

        yield return [new[] { -1, 1 }, Array.Empty<int[]>(), 1];

        yield return [new[] { -2, 1 }, Array.Empty<int[]>(), 1];

        yield return [new[] { 2, -1, 2, -1, 2 }, Array.Empty<int[]>(), 8];

        yield return [new[] { 3, -1, 3, -1, 3 }, Array.Empty<int[]>(), 18];

        yield return [new[] { 5 }, new[] { new[] { 0, 5 } }, 16];

        yield return [new[] { 9 }, Array.Empty<int[]>(), 81];

        yield return [new[] { 1, -1, 1, -1, 1, -1, 1, -1 }, Array.Empty<int[]>(), 2];

        yield return [new[] { 4, -2, 4, -2, 4 }, Array.Empty<int[]>(), 32];

        yield return [new[] { 7, -1, 7, -1, 7 }, Array.Empty<int[]>(), 98];

        yield return [new[] { 3, -1, -1, 3 }, Array.Empty<int[]>(), 9];

        yield return [new[] { 2, 2, 2 }, Array.Empty<int[]>(), 36];

        yield return [new[] { 4, -1, -1, 4 }, Array.Empty<int[]>(), 16];

        yield return [new[] { 1, -1, 1 }, new[] { new[] { 2, 0 } }, 2];

        yield return [new[] { 5, -1, 5, -2, 5 }, Array.Empty<int[]>(), 125];

        yield return [new[] { 8, -1, 8, -1, 8 }, new[] { new[] { 4, 8 } }, 73];

        yield return [new[] { 3, 3, 3 }, Array.Empty<int[]>(), 81];

        yield return [new[] { 1, 1, 1, 1 }, new[] { new[] { 1, 1 } }, 16];

        yield return [new[] { -1, -1, 5 }, new[] { new[] { 0, -1 } }, 0];

        yield return [new[] { -2, 5 }, new[] { new[] { -1, 0 } }, 0];
    }
}