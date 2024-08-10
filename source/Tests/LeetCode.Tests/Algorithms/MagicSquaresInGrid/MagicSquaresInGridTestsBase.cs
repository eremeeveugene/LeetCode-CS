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

using LeetCode.Algorithms.MagicSquaresInGrid;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MagicSquaresInGrid;

public abstract class MagicSquaresInGridTestsBase<T> where T : IMagicSquaresInGrid, new()
{
    [TestMethod]
    [DataRow("[[8]]", 0)]
    [DataRow("[[1,1,1],[1,1,1],[1,1,1]]", 0)]
    [DataRow("[[5,5,5],[5,5,5],[5,5,5]]", 0)]
    [DataRow("[[7,0,5],[2,4,6],[3,8,1]]", 0)]
    [DataRow("[[4,3,8,4],[9,5,1,9],[2,7,6,2]]", 1)]
    [DataRow("[[4,3,8,4],[9,5,1,9],[2,7,6,2],[4,3,8,1],[1,6,7,5]]", 1)]
    [DataRow(
        "[[9,9,5,1,9,5,5,7,2,5],[9,1,8,3,4,6,7,2,8,9],[4,1,1,5,9,1,5,9,6,4],[5,5,6,7,2,8,3,4,0,6],[1,9,1,8,3,1,4,2,9,4],[2,8,6,4,2,7,3,2,7,6],[9,2,5,0,7,8,2,9,5,1],[2,1,4,4,7,6,2,4,3,8],[1,2,5,3,0,5,10,8,5,2],[6,9,6,8,8,4,3,6,0,9]]",
        3)]
    public void NumMagicSquaresInside_GivenGridJsonArray_ReturnsCorrectMagicSquareCount(string gridJsonArray,
        int expectedResult)
    {
        // Arrange
        var solution = new T();

        var grid = JsonHelper<int>.JsonArrayToJaggedArray(gridJsonArray);

        // Act
        var actualResult = solution.NumMagicSquaresInside(grid);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}