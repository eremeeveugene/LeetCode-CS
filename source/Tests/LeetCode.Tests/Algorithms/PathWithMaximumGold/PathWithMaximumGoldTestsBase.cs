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

using LeetCode.Algorithms.PathWithMaximumGold;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.PathWithMaximumGold;

public abstract class PathWithMaximumGoldTestsBase<T> where T : IPathWithMaximumGold, new()
{
    [TestMethod]
    [DataRow("[[0]]", 0)]
    [DataRow("[[100]]", 100)]
    [DataRow("[[0,6,0],[5,8,7],[0,9,0]]", 24)]
    [DataRow("[[1,0,7],[2,0,6],[3,4,5],[0,3,0],[9,0,20]]", 28)]
    [DataRow("[[0,56,0,41,0],[0,0,45,0,0],[70,0,0,0,0],[11,0,67,0,0],[66,0,0,67,0]]", 147)]
    [DataRow("[[1,0,7,0,0,0],[2,0,6,0,1,0],[3,5,6,7,4,2],[4,3,1,0,2,0],[3,0,5,0,20,0]]", 60)]
    [DataRow(
        "[[0,0,0,0,0,0,11,0,0,98],[69,31,0,0,80,0,0,0,0,0],[0,0,0,0,0,34,0,0,0,0],[51,0,0,0,0,69,9,0,0,0],[0,44,91,0,0,0,0,0,0,0],[0,0,0,0,0,0,0,0,0,0],[0,0,0,0,0,83,0,0,49,0],[0,0,0,0,0,0,0,0,0,0],[0,0,0,74,6,0,59,0,0,0],[46,0,0,0,0,0,69,0,0,0]]",
        135)]
    public void GetMaximumGold_WithGridJsonArray_ReturnsMaximumGoldCollected(string gridJsonArray, int expectedResult)
    {
        // Arrange
        var solution = new T();

        var grid = JsonConvertHelper<int>.JsonArrayToJaggedArray(gridJsonArray);

        // Act
        var actualResult = solution.GetMaximumGold(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}