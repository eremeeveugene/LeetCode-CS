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

using LeetCode.Algorithms.DiagonalTraverse;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.DiagonalTraverse;

public abstract class DiagonalTraverseTestsBase<T> where T : IDiagonalTraverse, new()
{
    [TestMethod]
    [DataRow("[[1,2,3],[4,5,6],[7,8,9]]", "[1,2,4,7,5,3,6,8,9]")]
    [DataRow("[[1,2],[3,4]]", "[1,2,3,4]")]
    public void FindDiagonalOrder_WithMatrix_ReturnsElementsInDiagonalTraversalOrder(string matJson,
        string expectedResultJson)
    {
        // Arrange
        var mat = JsonHelper<int[][]>.Parse(matJson);
        var expectedResult = JsonHelper<int[]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.FindDiagonalOrder(mat);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}