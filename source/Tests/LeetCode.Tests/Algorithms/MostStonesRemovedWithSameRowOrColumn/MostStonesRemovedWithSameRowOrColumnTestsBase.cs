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

using LeetCode.Algorithms.MostStonesRemovedWithSameRowOrColumn;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MostStonesRemovedWithSameRowOrColumn;

public abstract class MostStonesRemovedWithSameRowOrColumnTestsBase<T>
    where T : IMostStonesRemovedWithSameRowOrColumn, new()
{
    [TestMethod]
    [DataRow("[[0,0]]", 0)]
    [DataRow("[[0,0],[2,2],[10000,2]]", 1)]
    [DataRow("[[0,0],[0,2],[1,1],[2,0],[2,2]]", 3)]
    [DataRow("[[0,0],[0,1],[1,0],[1,2],[2,1],[2,2]]", 5)]
    [DataRow("[[0,0],[1,0],[2,0],[1,1],[1,2],[2,2]]", 5)]
    [DataRow("[[0,0],[0,1],[0,2],[1,4],[1,5],[2,4],[2,6]]", 5)]
    [DataRow("[[0,0],[0,1],[0,2],[0,3],[1,4],[1,5],[2,4],[2,6]]", 6)]
    [DataRow("[[0,0],[0,1],[1,0],[1,2],[2,0],[2,3],[3,0],[3,4]]", 7)]
    [DataRow("[[0,5],[1,5],[2,5],[3,5],[0,4],[0,6],[1,3],[1,7],[2,2],[2,8],[3,1],[3,9]]", 11)]
    public void RemoveStones_WithGridOfStones_ReturnsMaxRemovableStones(string stonesJsonArray, int expectedResult)
    {
        // Arrange
        var solution = new T();

        var stones = JsonHelper<int>.DeserializeToJaggedArray(stonesJsonArray);

        // Act
        var actualResult = solution.RemoveStones(stones);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}