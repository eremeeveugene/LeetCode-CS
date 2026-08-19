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

using LeetCode.Algorithms.NearestAvailableDrone;

namespace LeetCode.Tests.Algorithms.NearestAvailableDrone;

public abstract class NearestAvailableDroneTestsBase<T> where T : INearestAvailableDrone, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void NearestDrone_WithDronesAndTarget_ReturnsNearestReachableDroneIndex(int[][] drones, int[] target, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NearestDrone(drones, target);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 0, 0, 8 }, new[] { 2, 2, 9 } }, new[] { 3, 4 }, 1];

        yield return [new[] { new[] { 2, 1, 5 }, new[] { 4, 4, 5 }, new[] { 6, 6, 8 } }, new[] { 5, 5 }, 1];

        yield return [new[] { new[] { 4, 4, 5 } }, new[] { 8, 6 }, -1];

        yield return [new[] { new[] { 0, 0, 2 } }, new[] { 1, 1 }, 0];

        yield return [new[] { new[] { -25, -25, 100 }, new[] { 25, 25, 100 } }, new[] { 0, 0 }, 0];

        yield return [new[] { new[] { 1, 1, 1 }, new[] { 0, 0, 10 } }, new[] { 1, 1 }, 0];

        yield return [new[] { new[] { 1, 0, 1 }, new[] { 0, 1, 1 }, new[] { -1, 0, 1 } }, new[] { 0, 0 }, 0];

        yield return [new[] { new[] { 0, 0, 1 }, new[] { 2, 2, 4 }, new[] { 3, 3, 10 } }, new[] { 0, 0 }, 0];

        yield return [new[] { new[] { 5, -3, 20 } }, new[] { 0, 0 }, 0];

        yield return [new[] { new[] { 5, -3, 7 } }, new[] { 0, 0 }, -1];

        yield return [new[] { new[] { 2, 0, 1 }, new[] { 3, 0, 3 } }, new[] { 0, 0 }, 1];

        yield return [new[] { new[] { -5, 0, 5 }, new[] { 1, 1, 2 } }, new[] { 0, 0 }, 1];

        yield return [new[] { new[] { -2, 0, 2 }, new[] { 2, 0, 2 } }, new[] { 0, 0 }, 0];

        yield return [new[] { new[] { -10, -10, 25 }, new[] { -3, -4, 6 } }, new[] { -1, -1 }, 1];

        yield return [new[] { new[] { 25, 25, 100 }, new[] { 24, 25, 1 } }, new[] { 25, 25 }, 0];

        yield return [new[] { new[] { -25, 25, 49 }, new[] { 25, -25, 49 } }, new[] { 0, 0 }, -1];

        yield return [new[] { new[] { 10, 10, 30 }, new[] { 5, 5, 20 }, new[] { 1, 1, 10 } }, new[] { 0, 0 }, 2];

        yield return [new[] { new[] { 10, 10, 5 }, new[] { 5, 5, 9 }, new[] { 4, 4, 8 } }, new[] { 0, 0 }, 2];

        yield return [new[] { new[] { 0, 5, 5 }, new[] { 5, 0, 5 }, new[] { 3, 3, 6 } }, new[] { 0, 0 }, 0];

        yield return [new[] { new[] { 0, 0, 100 }, new[] { -1, -1, 2 } }, new[] { -1, -1 }, 1];

        yield return [new[] { new[] { -25, -25, 99 }, new[] { 25, 25, 100 } }, new[] { 25, -25 }, 0];

        yield return [new[] { new[] { 3, 4, 6 }, new[] { 4, 3, 7 }, new[] { 1, 1, 2 } }, new[] { 0, 0 }, 2];
    }
}