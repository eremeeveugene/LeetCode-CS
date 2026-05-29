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

using LeetCode.Algorithms.FirstCompletelyPaintedRowOrColumn;

namespace LeetCode.Tests.Algorithms.FirstCompletelyPaintedRowOrColumn;

public abstract class FirstCompletelyPaintedRowOrColumnTestsBase<T> where T : IFirstCompletelyPaintedRowOrColumn, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void FirstCompleteIndex_WithSequenceAndMatrix_ReturnsFirstCompletedRowOrColumnIndex(int[] arr,
        int[][] mat, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FirstCompleteIndex(arr, mat);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return [new[] { 1, 3, 4, 2 }, new[] { new[] { 1, 4 }, new[] { 2, 3 } }, 2];

        yield return [new[] { 2, 8, 7, 4, 1, 3, 5, 6, 9 }, new[] { new[] { 3, 2, 5 }, new[] { 1, 4, 6 }, new[] { 8, 7, 9 } }, 3];
    }
}