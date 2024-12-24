// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.FindMinimumDiameterAfterMergingTwoTrees;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindMinimumDiameterAfterMergingTwoTrees;

public abstract class FindMinimumDiameterAfterMergingTwoTreesTestsBase<T>
    where T : IFindMinimumDiameterAfterMergingTwoTrees, new()
{
    [TestMethod]
    [DataRow("[[0,1],[0,2],[0,3]]", "[[0,1]]", 3)]
    [DataRow("[[0,1],[0,2],[0,3],[2,4],[2,5],[3,6],[2,7]]", "[[0,1],[0,2],[0,3],[2,4],[2,5],[3,6],[2,7]]", 5)]
    public void MinimumDiameterAfterMerge_WithTwoGraphs_CalculatesMinimumDiameter(string edges1JsonArray,
        string edges2JsonArray, int expectedResult)
    {
        // Arrange
        var edges1 = JsonHelper<int>.DeserializeToJaggedArray(edges1JsonArray);
        var edges2 = JsonHelper<int>.DeserializeToJaggedArray(edges2JsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.MinimumDiameterAfterMerge(edges1, edges2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}