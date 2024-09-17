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
    [DataRow(1, "[]", "[0]")]
    [DataRow(2, "[[0,1]]", "[0,1]")]
    [DataRow(3, "[[0,1],[1,2]]", "[1]")]
    [DataRow(4, "[[1,0],[1,2],[1,3]]", "[1]")]
    [DataRow(5, "[[0,1],[0,2],[0,3],[3,4]]", "[0,3]")]
    [DataRow(6, "[[0,1],[0,2],[0,3],[3,4],[4,5]]", "[3]")]
    [DataRow(6, "[[3,0],[3,1],[3,2],[3,4],[5,4]]", "[3,4]")]
    [DataRow(7, "[[0,1],[1,2],[1,3],[2,4],[3,5],[4,6]]", "[1,2]")]
    [DataRow(8, "[[0,1],[0,2],[1,3],[1,4],[2,5],[2,6],[6,7]]", "[0,2]")]
    [DataRow(9, "[[0,1],[1,2],[1,3],[3,4],[4,5],[5,6],[6,7],[7,8]]", "[4,5]")]
    public void FindMinHeightTrees_WithGraphEdgesAndNodeCount_ReturnsMinHeightRoots(int n, string edgesJsonArray,
        string expectedResultJsonArray)
    {
        // Arrange
        var edges = JsonHelper<int>.DeserializeToJaggedArray(edgesJsonArray);
        var expectedResult = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.FindMinHeightTrees(n, edges);

        // Assert
        CollectionAssert.AreEquivalent(expectedResult, actualResult.ToArray());
    }
}