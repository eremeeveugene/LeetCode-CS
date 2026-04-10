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

using LeetCode.Algorithms.SortTheMatrixDiagonally;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.SortTheMatrixDiagonally;

public abstract class SortTheMatrixDiagonallyTestsBase<T> where T : ISortTheMatrixDiagonally, new()
{
    [TestMethod]
    [DataRow("[[3,3,1,1],[2,2,1,2],[1,1,1,2]]", "[[1,1,1,1],[1,2,2,2],[1,2,3,3]]")]
    [DataRow("[[11,25,66,1,69,7],[23,55,17,45,15,52],[75,31,36,44,58,8],[22,27,33,25,68,4],[84,28,14,11,5,50]]",
        "[[5,17,4,1,52,7],[11,11,25,45,8,69],[14,23,25,44,58,15],[22,27,31,36,50,66],[84,28,75,33,55,68]]")]
    public void DiagonalSort_WithUnsortedMatrixDiagonals_ReturnsMatrixWithEachDiagonalSortedAscending(string matJson,
        string expectedResultJson)
    {
        // Arrange
        var mat = JsonHelper.Parse<int[][]>(matJson);
        var expectedResult = JsonHelper.Parse<int[][]>(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.DiagonalSort(mat);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}