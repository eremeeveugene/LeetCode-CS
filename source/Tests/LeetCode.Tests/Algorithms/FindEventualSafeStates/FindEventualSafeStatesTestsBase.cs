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

using LeetCode.Algorithms.FindEventualSafeStates;

namespace LeetCode.Tests.Algorithms.FindEventualSafeStates;

public abstract class FindEventualSafeStatesTestsBase<T> where T : IFindEventualSafeStates, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void EventualSafeNodes_WithGraphContainingCyclesAndTerminalNodes_ReturnsOnlySafeNodesInAscendingOrder(int[][] graph, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.EventualSafeNodes(graph);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return
        [
            new[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 5 }, new[] { 0 }, new[] { 5 }, Array.Empty<int>(), Array.Empty<int>() },
            new[] { 2, 4, 5, 6 }
        ];

        yield return [new[] { new[] { 1, 2, 3, 4 }, new[] { 1, 2 }, new[] { 3, 4 }, new[] { 0, 4 }, Array.Empty<int>() }, new[] { 4 }];

        yield return [new[] { Array.Empty<int>() }, new[] { 0 }];

        yield return [new[] { new[] { 0 } }, Array.Empty<int>()];

        yield return [new[] { new[] { 0, 1 }, new[] { 1 } }, Array.Empty<int>()];

        yield return [new[] { Array.Empty<int>(), new[] { 1 }, new[] { 2 } }, new[] { 0 }];

        yield return [new[] { new[] { 0, 2 }, new[] { 0, 2 }, new[] { 0, 1 } }, Array.Empty<int>()];

        yield return [new[] { new[] { 1 }, Array.Empty<int>(), new[] { 0, 1 }, new[] { 2, 3 } }, new[] { 0, 1, 2 }];

        yield return [new[] { new[] { 0, 3 }, Array.Empty<int>(), new[] { 0, 1, 3 }, new[] { 0, 2 } }, new[] { 1 }];

        yield return [new[] { new[] { 1, 2 }, new[] { 1, 4 }, new[] { 0, 1, 2 }, Array.Empty<int>(), new[] { 3, 4 } }, new[] { 3 }];

        yield return [new[] { new[] { 1, 3, 4 }, new[] { 0, 3 }, new[] { 0, 1, 2 }, new[] { 2 }, new[] { 3 } }, Array.Empty<int>()];

        yield return [new[] { new[] { 0, 2, 5 }, new[] { 2 }, new[] { 2 }, new[] { 4, 5 }, new[] { 0 }, new[] { 0, 3 } }, Array.Empty<int>()];

        yield return [new[] { new[] { 0, 1 }, new[] { 0, 3, 5 }, new[] { 4 }, Array.Empty<int>(), new[] { 1, 5 }, Array.Empty<int>() }, new[] { 3, 5 }];

        yield return [new[] { new[] { 0, 2, 3 }, new[] { 3 }, new[] { 4 }, new[] { 0, 4, 5 }, new[] { 1, 2 }, new[] { 2 }, new[] { 3, 5 } }, Array.Empty<int>()];

        yield return [new[] { new[] { 1, 3 }, new[] { 1, 5 }, new[] { 3 }, new[] { 0, 2 }, new[] { 2 }, new[] { 0 }, new[] { 0, 1 }, new[] { 1, 2 } }, Array.Empty<int>()];

        yield return [new[] { new[] { 0, 2 }, new[] { 4 }, new[] { 1, 4, 7 }, new[] { 3, 7 }, new[] { 2, 5, 7 }, new[] { 2, 3 }, new[] { 0 }, new[] { 5 } }, Array.Empty<int>()];

        yield return [new[] { new[] { 3, 7 }, new[] { 0, 4, 8 }, new[] { 0, 1, 8 }, new[] { 4, 6 }, new[] { 3 }, new[] { 6 }, new[] { 0, 4 }, Array.Empty<int>(), new[] { 1, 6 } }, new[] { 7 }];

        yield return [new[] { new[] { 3, 8 }, new[] { 5 }, new[] { 0, 2, 6 }, new[] { 0, 2, 8 }, Array.Empty<int>(), new[] { 3, 8 }, new[] { 1, 5 }, new[] { 4 }, new[] { 8 }, new[] { 1, 9 } }, new[] { 4, 7 }];

        yield return [new[] { new[] { 8 }, new[] { 3, 6 }, Array.Empty<int>(), new[] { 5, 9 }, Array.Empty<int>(), new[] { 1, 2, 5 }, new[] { 2, 4, 9 }, new[] { 2, 5, 6 }, Array.Empty<int>(), new[] { 7 } }, new[] { 0, 2, 4, 8 }];

        yield return [new[] { new[] { 7, 11 }, new[] { 0 }, new[] { 5, 7, 9 }, new[] { 5 }, Array.Empty<int>(), new[] { 0 }, new[] { 5 }, new[] { 3 }, new[] { 3, 4, 6 }, new[] { 2, 8 }, new[] { 2, 5, 8 }, new[] { 6, 9 } }, new[] { 4 }];
    }
}