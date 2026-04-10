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

using LeetCode.Algorithms.MaximizeTheNumberOfTargetNodesAfterConnectingTrees1;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MaximizeTheNumberOfTargetNodesAfterConnectingTrees1;

public abstract class MaximizeTheNumberOfTargetNodesAfterConnectingTrees1TestsBase<T>
    where T : IMaximizeTheNumberOfTargetNodesAfterConnectingTrees1, new()
{
    [TestMethod]
    [DataRow("[[0,1],[0,2],[2,3],[2,4]]", "[[0,1],[0,2],[0,3],[2,7],[1,4],[4,5],[4,6]]", 2, "[9,7,9,8,8]")]
    [DataRow("[[0,1],[0,2],[0,3],[0,4]]", "[[0,1],[1,2],[2,3]]", 1, "[6,3,3,3,3]")]
    public void MaxTargetNodes_WithTwoTreesAndDistanceLimit_ReturnsMaxTargetsPerNode(string edges1Json,
        string edges2Json, int k, string expectedResultJson)
    {
        // Arrange
        var edges1 = JsonHelper.Parse<int[][]>(edges1Json);
        var edges2 = JsonHelper.Parse<int[][]>(edges2Json);
        var expectedResult = JsonHelper.Parse<int[]>(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.MaxTargetNodes(edges1, edges2, k);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}