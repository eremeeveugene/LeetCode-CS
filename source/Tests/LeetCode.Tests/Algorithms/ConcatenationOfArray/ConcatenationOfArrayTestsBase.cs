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

using LeetCode.Algorithms.ConcatenationOfArray;

namespace LeetCode.Tests.Algorithms.ConcatenationOfArray;

public abstract class ConcatenationOfArrayTestsBase<T> where T : IConcatenationOfArray, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 1 }, new[] { 1, 2, 1, 1, 2, 1 })]
    [DataRow(new[] { 1, 3, 2, 1 }, new[] { 1, 3, 2, 1, 1, 3, 2, 1 })]
    [DataRow(new[] { 1 }, new[] { 1, 1 })]
    [DataRow(new[] { 5, 5 }, new[] { 5, 5, 5, 5 })]
    [DataRow(new[] { 1, 2 }, new[] { 1, 2, 1, 2 })]
    [DataRow(new[] { 1000 }, new[] { 1000, 1000 })]
    [DataRow(new[] { 3, 2, 1 }, new[] { 3, 2, 1, 3, 2, 1 })]
    [DataRow(new[] { 7, 8, 9, 10 }, new[] { 7, 8, 9, 10, 7, 8, 9, 10 })]
    [DataRow(new[] { 2, 1 }, new[] { 2, 1, 2, 1 })]
    [DataRow(new[] { 4, 4, 4 }, new[] { 4, 4, 4, 4, 4, 4 })]
    [DataRow(new[] { 10, 20, 30 }, new[] { 10, 20, 30, 10, 20, 30 })]
    [DataRow(new[] { 9, 1, 9 }, new[] { 9, 1, 9, 9, 1, 9 })]
    [DataRow(new[] { 100, 1 }, new[] { 100, 1, 100, 1 })]
    [DataRow(new[] { 6, 7, 8, 9, 10 }, new[] { 6, 7, 8, 9, 10, 6, 7, 8, 9, 10 })]
    [DataRow(new[] { 999, 1 }, new[] { 999, 1, 999, 1 })]
    [DataRow(new[] { 1, 1, 2, 2 }, new[] { 1, 1, 2, 2, 1, 1, 2, 2 })]
    [DataRow(new[] { 42 }, new[] { 42, 42 })]
    [DataRow(new[] { 8, 6, 7 }, new[] { 8, 6, 7, 8, 6, 7 })]
    [DataRow(new[] { 11, 22, 33, 44 }, new[] { 11, 22, 33, 44, 11, 22, 33, 44 })]
    [DataRow(new[] { 5, 4, 3, 2, 1 }, new[] { 5, 4, 3, 2, 1, 5, 4, 3, 2, 1 })]
    public void GetConcatenation_WithInputArray_ReturnsConcatenatedArray(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.GetConcatenation(nums);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}