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
    public void EventualSafeNodes_WithGraphContainingCyclesAndTerminalNodes_ReturnsOnlySafeNodesInAscendingOrder(
        int[][] graph, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.EventualSafeNodes(graph).ToArray();

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return
        [
            new[]
            {
                new[] { 1, 2 }, new[] { 2, 3 }, new[] { 5 }, new[] { 0 }, new[] { 5 }, Array.Empty<int>(),
                Array.Empty<int>()
            },
            new[] { 2, 4, 5, 6 }
        ];

        yield return
        [
            new[] { new[] { 1, 2, 3, 4 }, new[] { 1, 2 }, new[] { 3, 4 }, new[] { 0, 4 }, Array.Empty<int>() },
            new[] { 4 }
        ];
    }
}