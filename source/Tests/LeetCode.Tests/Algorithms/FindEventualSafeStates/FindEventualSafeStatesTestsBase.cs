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
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindEventualSafeStates;

public abstract class FindEventualSafeStatesTestsBase<T> where T : IFindEventualSafeStates, new()
{
    [TestMethod]
    [DataRow("[[1,2],[2,3],[5],[0],[5],[],[]]", "[2,4,5,6]")]
    [DataRow("[[1,2,3,4],[1,2],[3,4],[0,4],[]]", "[4]")]
    public void EventualSafeNodes_WithGraphContainingCyclesAndTerminalNodes_ReturnsOnlySafeNodesInAscendingOrder(
        string graphJson, string expectedResultJson)
    {
        // Arrange
        var graph = JsonHelper.Parse<int[][]>(graphJson);
        var expectedResult = JsonHelper.Parse<int[]>(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.EventualSafeNodes(graph).ToArray();

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}