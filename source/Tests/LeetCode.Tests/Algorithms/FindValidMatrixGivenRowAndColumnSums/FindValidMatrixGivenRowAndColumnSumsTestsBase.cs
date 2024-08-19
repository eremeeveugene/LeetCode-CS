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

using LeetCode.Algorithms.FindValidMatrixGivenRowAndColumnSums;
using LeetCode.Core.Helpers;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.FindValidMatrixGivenRowAndColumnSums;

public abstract class FindValidMatrixGivenRowAndColumnSumsTestsBase<T>
    where T : IFindValidMatrixGivenRowAndColumnSums, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 8 }, new[] { 4, 7 }, "[[3,0],[1,7]]")]
    [DataRow(new[] { 5, 7, 10 }, new[] { 8, 6, 8 }, "[[5,0,0],[3,4,0],[0,2,8]]")]
    public void RestoreMatrix_WithGivenRowAndColumnSums_ReturnsRestoredMatrix(int[] rowSum, int[] colSum,
        string expectedResultJsonArray)
    {
        // Arrange
        var expectedResult = JsonHelper<int>.DeserializeToJaggedArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.RestoreMatrix(rowSum, colSum);

        // Assert
        JaggedArrayAssert.AreEqual(expectedResult, actualResult);
    }
}