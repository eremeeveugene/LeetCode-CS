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

using LeetCode.Algorithms.RankTransformOfAnArray;

namespace LeetCode.Tests.Algorithms.RankTransformOfAnArray;

public abstract class RankTransformOfAnArrayTestsBase<T> where T : IRankTransformOfAnArray, new()
{
    [TestMethod]
    [DataRow(new[] { 40, 10, 20, 30 }, new[] { 4, 1, 2, 3 })]
    [DataRow(new[] { 100, 100, 100 }, new[] { 1, 1, 1 })]
    [DataRow(new[] { 37, 12, 28, 9, 100, 56, 80, 5, 12 }, new[] { 5, 3, 4, 2, 8, 6, 7, 1, 3 })]
    public void ArrayRankTransform_WithUnsortedArray_ReturnsRankedArray(int[] arr, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ArrayRankTransform(arr);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}