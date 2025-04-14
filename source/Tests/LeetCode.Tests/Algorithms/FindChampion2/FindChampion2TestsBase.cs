// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.FindChampion2;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindChampion2;

public abstract class FindChampion2TestsBase<T> where T : IFindChampion2, new()
{
    [TestMethod]
    [DataRow(1, "[]", 0)]
    [DataRow(2, "[]", -1)]
    [DataRow(3, "[[0,1],[1,2]]", 0)]
    [DataRow(4, "[[0,2],[1,3],[1,2]]", -1)]
    public void FindChampion_WithNodeCountAndDirectedEdges_ReturnsChampionOrMinusOne(int n, string edgesJsonArray,
        int expectedResult)
    {
        // Arrange
        var edges = JsonHelper<int>.DeserializeToJaggedArray(edgesJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.FindChampion(n, edges);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}