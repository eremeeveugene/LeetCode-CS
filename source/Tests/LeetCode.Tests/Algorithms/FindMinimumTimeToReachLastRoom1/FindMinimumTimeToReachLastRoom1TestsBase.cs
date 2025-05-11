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

using LeetCode.Algorithms.FindMinimumTimeToReachLastRoom1;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindMinimumTimeToReachLastRoom1;

public abstract class FindMinimumTimeToReachLastRoom1TestsBase<T> where T : IFindMinimumTimeToReachLastRoom1, new()
{
    [TestMethod]
    [DataRow("[[0,4],[4,4]]", 6)]
    [DataRow("[[0,1],[1,2]]", 3)]
    [DataRow("[[0,0,0],[0,0,0]]", 3)]
    [DataRow("[[0,2,4],[3,1,5],[6,3,8]]", 9)]
    [DataRow("[[15,58],[67,4]]", 60)]
    [DataRow("[[17,56],[97,80]]", 81)]
    [DataRow("[[94,79,62,27,69,84],[6,32,11,82,42,30]]", 72)]
    [DataRow(
        "[[63,102,19,11,110,26,89,101,19],[7,17,119,94,44,3,30,111,54],[20,66,72,19,76,6,16,0,97],[7,48,113,22,14,100,99,91,60]]",
        93)]
    public void MinTimeToReach_WithMoveTimeMatrix_ReturnsMinimumTimeRequired(string moveTimeJson,
        int expectedResult)
    {
        // Arrange
        var moveTime = JsonHelper<int[][]>.Parse(moveTimeJson);

        var solution = new T();

        // Act
        var actualResult = solution.MinTimeToReach(moveTime);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}