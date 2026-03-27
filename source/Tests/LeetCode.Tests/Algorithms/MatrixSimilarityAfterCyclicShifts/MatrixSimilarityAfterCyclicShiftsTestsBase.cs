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
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MatrixSimilarityAfterCyclicShifts;

public abstract class MatrixSimilarityAfterCyclicShiftsTestsBase<T> where T : IMatrixSimilarityAfterCyclicShifts, new()
{
    [TestMethod]
    [DataRow("[[1,2,3],[4,5,6],[7,8,9]]", 4, false)]
    [DataRow("[[1,2,1,2],[5,5,5,5],[6,3,6,3]]", 2, true)]
    [DataRow("[[2,2],[2,2]]", 3, true)]
    public void AreSimilar_WithMatrixAndShiftCount_ReturnsTrueIfMatrixRemainsUnchanged(string matJson, int k,
        bool expectedResult)
    {
        // Arrange
        var mat = JsonHelper<int[][]>.Parse(matJson);

        var solution = new T();

        // Act
        var actualResult = solution.AreSimilar(mat, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}