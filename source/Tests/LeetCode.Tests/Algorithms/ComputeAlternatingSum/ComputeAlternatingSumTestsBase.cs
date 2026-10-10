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

using LeetCode.Algorithms.ComputeAlternatingSum;

namespace LeetCode.Tests.Algorithms.ComputeAlternatingSum;

public abstract class ComputeAlternatingSumTestsBase<T> where T : IComputeAlternatingSum, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 3, 5, 7 }, -4)]
    [DataRow(new[] { 100 }, 100)]
    [DataRow(new[] { 1, 2 }, -1)]
    [DataRow(new[] { 5, 5 }, 0)]
    [DataRow(new[] { 1, 2, 3 }, 2)]
    [DataRow(new[] { 10, 20, 30, 40 }, -20)]
    [DataRow(new[] { 100, 1 }, 99)]
    [DataRow(new[] { 1, 100 }, -99)]
    [DataRow(new[] { 1, 1, 1, 1, 1 }, 1)]
    [DataRow(new[] { 2, 4, 6, 8, 10 }, 6)]
    [DataRow(new[] { 100, 100, 100 }, 100)]
    [DataRow(new[] { 50, 25 }, 25)]
    [DataRow(new[] { 7, 3, 9 }, 13)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, -3)]
    [DataRow(new[] { 99, 1, 99, 1 }, 196)]
    [DataRow(new[] { 10, 1, 10, 1, 10, 1 }, 27)]
    [DataRow(new[] { 4, 3, 2, 1 }, 2)]
    [DataRow(new[] { 8, 8, 8, 8 }, 0)]
    [DataRow(new[] { 3, 1, 4, 1, 5 }, 10)]
    [DataRow(new[] { 100, 100 }, 0)]
    public void AlternatingSum_WithNumsArray_ReturnsAlternatingIndexedSum(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.AlternatingSum(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}