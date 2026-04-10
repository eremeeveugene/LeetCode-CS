// --------------------------------------------------------------------------------
// Copyright (C) 2026 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.CountUnguardedCellsInTheGrid;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.CountUnguardedCellsInTheGrid;

public abstract class CountUnguardedCellsInTheGridTestsBase<T> where T : ICountUnguardedCellsInTheGrid, new()
{
    [TestMethod]
    [DataRow(4, 6, "[[0,0],[1,1],[2,3]]", "[[0,1],[2,2],[1,4]]", 7)]
    [DataRow(3, 3, "[[1,1]]", "[[0,1],[1,0],[2,1],[1,2]]", 4)]
    public void CountUnguarded_WithGridSizeGuardsAndWalls_ReturnsNumberOfUnguardedCells(int m, int n,
        string guardsJson, string wordsJson, int expectedResult)
    {
        // Arrange
        var guards = JsonHelper.Parse<int[][]>(guardsJson);
        var words = JsonHelper.Parse<int[][]>(wordsJson);

        var solution = new T();

        // Act
        var actualResult = solution.CountUnguarded(m, n, guards, words);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}