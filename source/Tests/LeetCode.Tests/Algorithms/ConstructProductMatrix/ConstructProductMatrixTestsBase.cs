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

using LeetCode.Algorithms.ConstructProductMatrix;

namespace LeetCode.Tests.Algorithms.ConstructProductMatrix;

public abstract class ConstructProductMatrixTestsBase<T> where T : IConstructProductMatrix, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void ConstructProductMatrix_WithValidGrid_ReturnsProductOfAllOtherElementsModulo(int[][] grid,
        int[][] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ConstructProductMatrix(grid);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 2 }, new[] { 3, 4 } }, new[] { new[] { 24, 12 }, new[] { 8, 6 } }];

        yield return [new[] { new[] { 12345 }, new[] { 2 }, new[] { 1 } }, new[] { new[] { 2 }, new[] { 0 }, new[] { 0 } }];
    }
}