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

using LeetCode.Algorithms.SortMatrixByDiagonals;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.SortMatrixByDiagonals;

public abstract class SortMatrixByDiagonalsTestsBase<T> where T : ISortMatrixByDiagonals, new()
{
    [TestMethod]
    [DataRow("[[1]]", "[[1]]")]
    [DataRow("[[0,1],[1,2]]", "[[2,1],[1,0]]")]
    [DataRow("[[1,7,3],[9,8,2],[4,5,6]]", "[[8,2,3],[9,6,7],[4,5,1]]")]
    [DataRow("[[2,-4,0],[2,0,-4],[-4,2,0]]", "[[2,-4,0],[2,0,-4],[-4,2,0]]")]
    public void SortMatrix_WithSquareMatrix_SortsBottomLeftDiagonalsDescendingAndTopRightDiagonalsAscending(
        string gridJson, string expectedResultJson)
    {
        // Arrange
        var grid = JsonHelper.Parse<int[][]>(gridJson);
        var expectedResult = JsonHelper.Parse<int[][]>(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.SortMatrix(grid);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}