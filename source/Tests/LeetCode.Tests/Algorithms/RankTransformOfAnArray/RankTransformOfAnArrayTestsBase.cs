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

using LeetCode.Algorithms.RankTransformOfAnArray;

namespace LeetCode.Tests.Algorithms.RankTransformOfAnArray;

public abstract class RankTransformOfAnArrayTestsBase<T> where T : IRankTransformOfAnArray, new()
{
    [TestMethod]
    [DataRow(new[] { 40, 10, 20, 30 }, new[] { 4, 1, 2, 3 })]
    [DataRow(new[] { 100, 100, 100 }, new[] { 1, 1, 1 })]
    [DataRow(new[] { 37, 12, 28, 9, 100, 56, 80, 5, 12 }, new[] { 5, 3, 4, 2, 8, 6, 7, 1, 3 })]
    [DataRow(new[] { 1 }, new[] { 1 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5 })]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, new[] { 5, 4, 3, 2, 1 })]
    [DataRow(new[] { 2, 2, 2, 2 }, new[] { 1, 1, 1, 1 })]
    [DataRow(new[] { 10, 3, 8, 9, 4 }, new[] { 5, 1, 3, 4, 2 })]
    [DataRow(new[] { 1, 1, 1, 2, 2, 2 }, new[] { 1, 1, 1, 2, 2, 2 })]
    [DataRow(new[] { 50, 25, 75, 12, 88, 3 }, new[] { 4, 3, 5, 2, 6, 1 })]
    [DataRow(new[] { 1, 0, 4, 8, 3 }, new[] { 2, 1, 4, 5, 3 })]
    [DataRow(new[] { 100, 50, 75, 25, 10 }, new[] { 5, 3, 4, 2, 1 })]
    [DataRow(new[] { 5, 5, 5, 5, 5 }, new[] { 1, 1, 1, 1, 1 })]
    [DataRow(new[] { 10, 5, 15, 20, 1 }, new[] { 3, 2, 4, 5, 1 })]
    [DataRow(new[] { 1, 2, 1, 3 }, new[] { 1, 2, 1, 3 })]
    [DataRow(new[] { 7, 7, 7, 1, 2, 3 }, new[] { 4, 4, 4, 1, 2, 3 })]
    [DataRow(new[] { 999, 1, 500, 250, 750 }, new[] { 5, 1, 3, 2, 4 })]
    [DataRow(new[] { 0, 0, 0 }, new[] { 1, 1, 1 })]
    [DataRow(new[] { 10, 10, 5, 5, 15, 15 }, new[] { 2, 2, 1, 1, 3, 3 })]
    [DataRow(new[] { 2, 1, 3, 4, 5, 6, 7, 8, 9, 10 }, new[] { 2, 1, 3, 4, 5, 6, 7, 8, 9, 10 })]
    public void ArrayRankTransform_WithUnsortedArray_ReturnsRankedArray(int[] arr, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ArrayRankTransform(arr);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}