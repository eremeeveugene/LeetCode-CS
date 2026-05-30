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

using LeetCode.Algorithms.SpiralMatrix;

namespace LeetCode.Tests.Algorithms.SpiralMatrix;

public abstract class SpiralMatrixTestsBase<T> where T : ISpiralMatrix, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void SpiralOrder_With2DMatrix_ReturnsElementsInSpiralOrder(int[][] matrix, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SpiralOrder(matrix).ToArray();

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } }, new[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 }];

        yield return [new[] { new[] { 1, 2, 3, 4 }, new[] { 5, 6, 7, 8 }, new[] { 9, 10, 11, 12 } }, new[] { 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 }];
    }
}