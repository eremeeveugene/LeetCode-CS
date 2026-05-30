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

namespace LeetCode.Tests.Algorithms.DiagonalTraverse;

public abstract class DiagonalTraverseTestsBase<T> where T : IDiagonalTraverse, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void FindDiagonalOrder_WithMatrix_ReturnsElementsInDiagonalTraversalOrder(int[][] mat, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindDiagonalOrder(mat);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } }, new[] { 1, 2, 4, 7, 5, 3, 6, 8, 9 }];

        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 } }, new[] { 1, 2, 3, 4 }];
    }
}