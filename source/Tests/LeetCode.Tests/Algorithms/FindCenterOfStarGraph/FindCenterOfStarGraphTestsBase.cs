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

using LeetCode.Algorithms.FindCenterOfStarGraph;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindCenterOfStarGraph;

public abstract class FindCenterOfStarGraphTestsBase<T> where T : IFindCenterOfStarGraph, new()
{
    [TestMethod]
    [DataRow("[[1,2],[2,3],[4,2]]", 2)]
    [DataRow("[[1,2],[5,1],[1,3],[1,4]]", 1)]
    public void FindCenter_GivenEdgesJsonArray_ReturnsCenterNode(string edgesJsonArray, int expectedResult)
    {
        // Arrange
        var solution = new T();

        var edges = JsonHelper<int>.DeserializeToJaggedArray(edgesJsonArray);

        // Act
        var actualResult = solution.FindCenter(edges);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}