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

using LeetCode.Algorithms.SumOfSquaresOfSpecialElements;

namespace LeetCode.Tests.Algorithms.SumOfSquaresOfSpecialElements;

public abstract class SumOfSquaresOfSpecialElementsTestsBase<T> where T : ISumOfSquaresOfSpecialElements, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4 }, 21)]
    [DataRow(new[] { 2, 7, 1, 19, 18, 3 }, 63)]
    [DataRow(new[] { 1 }, 1)]
    [DataRow(new[] { 50 }, 2500)]
    [DataRow(new[] { 3, 4 }, 25)]
    [DataRow(new[] { 50, 50 }, 5000)]
    [DataRow(new[] { 1, 2, 3 }, 10)]
    [DataRow(new[] { 4, 3, 2, 1 }, 26)]
    [DataRow(new[] { 10, 20, 30, 40 }, 2100)]
    [DataRow(new[] { 5, 5, 5, 5, 5 }, 50)]
    [DataRow(new[] { 2, 2, 2, 2, 2, 2 }, 16)]
    [DataRow(new[] { 6, 5, 4, 3, 2, 1 }, 78)]
    [DataRow(new[] { 1, 50, 1, 50, 1, 50 }, 5002)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7 }, 50)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 85)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 91)]
    [DataRow(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 }, 131)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 130)]
    [DataRow(new[] { 7, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 50)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, 210)]
    [DataRow(new[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 8 }, 172)]
    [DataRow(new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 5)]
    public void SumOfSquares_WithNums_ReturnsSumOfSquaresOfSpecialElements(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SumOfSquares(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}