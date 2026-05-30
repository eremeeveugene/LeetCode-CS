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

using LeetCode.Algorithms.MatrixSimilarityAfterCyclicShifts;

namespace LeetCode.Tests.Algorithms.MatrixSimilarityAfterCyclicShifts;

public abstract class MatrixSimilarityAfterCyclicShiftsTestsBase<T> where T : IMatrixSimilarityAfterCyclicShifts, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void AreSimilar_WithMatrixAndShiftCount_ReturnsTrueIfMatrixRemainsUnchanged(int[][] mat, int k,
        bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.AreSimilar(mat, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } }, 4, false];

        yield return [new[] { new[] { 1, 2, 1, 2 }, new[] { 5, 5, 5, 5 }, new[] { 6, 3, 6, 3 } }, 2, true];

        yield return [new[] { new[] { 2, 2 }, new[] { 2, 2 } }, 3, true];
    }
}