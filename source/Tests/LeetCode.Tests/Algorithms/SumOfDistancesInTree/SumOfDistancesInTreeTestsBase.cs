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

using LeetCode.Algorithms.SumOfDistancesInTree;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.SumOfDistancesInTree;

public abstract class SumOfDistancesInTreeTestsBase<T> where T : ISumOfDistancesInTree, new()
{
    [TestMethod]
    [DataRow(6, "[[0,1],[0,2],[2,3],[2,4],[2,5]]", new[] { 8, 12, 6, 10, 10, 10 })]
    [DataRow(1, "[]", new[] { 0 })]
    [DataRow(2, "[[1,0]]", new[] { 1, 1 })]
    public void SumOfDistancesInTree_GivenNumberOfNodesAndEdges_ReturnsDistanceSumsArray(int n, string edgesJsonArray,
        int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        var edges = JsonConvertHelper<int>.JsonArrayToJaggedArray(edgesJsonArray);

        // Act
        var actualResult = solution.SumOfDistancesInTree(n, edges);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}