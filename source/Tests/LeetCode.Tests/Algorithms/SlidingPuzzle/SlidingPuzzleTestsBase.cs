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

using LeetCode.Algorithms.SlidingPuzzle;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.SlidingPuzzle;

public abstract class SlidingPuzzleTestsBase<T> where T : ISlidingPuzzle, new()
{
    [TestMethod]
    [DataRow("[[1,2,3],[4,0,5]]", 1)]
    [DataRow("[[1,2,3],[5,4,0]]", -1)]
    [DataRow("[[4,1,2],[5,0,3]]", 5)]
    public void SlidingPuzzle_WithBoard_ReturnsMinimumMovesToSolve(string boardJsonArray, int expectedResult)
    {
        // Arrange
        var board = JsonHelper<int>.DeserializeToJaggedArray(boardJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.SlidingPuzzle(board);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}