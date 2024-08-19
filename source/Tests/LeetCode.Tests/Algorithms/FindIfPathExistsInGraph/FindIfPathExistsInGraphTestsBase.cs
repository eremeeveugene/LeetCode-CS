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

using LeetCode.Algorithms.FindIfPathExistsInGraph;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindIfPathExistsInGraph;

public abstract class FindIfPathExistsInGraphTestsBase<T> where T : IFindIfPathExistsInGraph, new()
{
    [TestMethod]
    [DataRow(3, "[[0,1],[1,2],[2,0]]", 0, 2, true)]
    [DataRow(6, "[[0,1],[0,2],[3,5],[5,4],[4,3]]", 0, 5, false)]
    public void ValidPath_GivenNumberOfNodesEdgesSourceAndDestination_ReturnsExpectedBoolean(int n,
        string edgesJsonArray, int source, int destination, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        var edges = JsonHelper<int>.DeserializeToJaggedArray(edgesJsonArray);

        // Act
        var actualResult = solution.ValidPath(n, edges, source, destination);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}