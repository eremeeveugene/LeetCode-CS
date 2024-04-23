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

using LeetCode.Algorithms.MinimumHeightTrees;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MinimumHeightTrees;

public abstract class MinimumHeightTreesTestsBase<T> where T : IMinimumHeightTrees, new()
{
    [TestMethod]
    [DataRow(4, "[[1,0],[1,2],[1,3]]", new[] { 1 })]
    [DataRow(6, "[[3,0],[3,1],[3,2],[3,4],[5,4]]", new[] { 3, 4 })]
    public void FindMinHeightTrees_WithGraphEdgesAndNodeCount_ReturnsMinHeightRoots(int n, string edgesJsonArray,
        int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        var edges = JsonConvertHelper<int>.JsonArrayToJaggedArray(edgesJsonArray);

        // Act
        var actualResult = solution.FindMinHeightTrees(n, edges);

        // Assert
        CollectionAssert.AreEquivalent(expectedResult, actualResult.ToArray());
    }
}