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

using LeetCode.Algorithms.SubarraysDistinctElementSumOfSquares1;

namespace LeetCode.Tests.Algorithms.SubarraysDistinctElementSumOfSquares1;

public abstract class SubarraysDistinctElementSumOfSquares1TestsBase<T> where T : ISubarraysDistinctElementSumOfSquares1, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 1 }, 15)]
    [DataRow(new[] { 1, 1 }, 3)]
    [DataRow(new[] { 1 }, 1)]
    [DataRow(new[] { 100 }, 1)]
    [DataRow(new[] { 1, 2 }, 6)]
    [DataRow(new[] { 100, 1 }, 6)]
    [DataRow(new[] { 1, 2, 3 }, 20)]
    [DataRow(new[] { 1, 2, 3, 4 }, 50)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 105)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, 196)]
    [DataRow(new[] { 7, 7, 7 }, 6)]
    [DataRow(new[] { 1, 1, 1, 1 }, 10)]
    [DataRow(new[] { 4, 4, 4, 4, 4 }, 15)]
    [DataRow(new[] { 1, 1, 2 }, 12)]
    [DataRow(new[] { 1, 2, 2 }, 12)]
    [DataRow(new[] { 1, 100, 100 }, 12)]
    [DataRow(new[] { 1, 2, 1, 2 }, 28)]
    [DataRow(new[] { 1, 1, 2, 2 }, 22)]
    [DataRow(new[] { 1, 2, 2, 1 }, 25)]
    [DataRow(new[] { 1, 2, 3, 1 }, 43)]
    [DataRow(new[] { 1, 2, 1, 3 }, 38)]
    [DataRow(new[] { 2, 2, 2, 1 }, 19)]
    [DataRow(new[] { 5, 3, 5, 3, 5 }, 45)]
    [DataRow(new[] { 1, 2, 3, 2, 1 }, 70)]
    [DataRow(new[] { 7, 7, 7, 7, 8 }, 27)]
    public void SumCounts_WithInputNums_ReturnsSumOfSquaresOfDistinctCounts(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SumCounts(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}