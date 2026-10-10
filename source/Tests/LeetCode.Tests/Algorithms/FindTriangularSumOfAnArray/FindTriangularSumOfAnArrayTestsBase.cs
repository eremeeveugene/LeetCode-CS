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

using LeetCode.Algorithms.FindTriangularSumOfAnArray;

namespace LeetCode.Tests.Algorithms.FindTriangularSumOfAnArray;

public abstract class FindTriangularSumOfAnArrayTestsBase<T> where T : IFindTriangularSumOfAnArray, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 8)]
    [DataRow(new[] { 5 }, 5)]
    [DataRow(new[] { 0 }, 0)]
    [DataRow(new[] { 9 }, 9)]
    [DataRow(new[] { 1, 1 }, 2)]
    [DataRow(new[] { 9, 9 }, 8)]
    [DataRow(new[] { 0, 0, 0 }, 0)]
    [DataRow(new[] { 1, 2, 3 }, 8)]
    [DataRow(new[] { 9, 8, 7, 6 }, 0)]
    [DataRow(new[] { 5, 5, 5, 5, 5 }, 0)]
    [DataRow(new[] { 0, 1, 0, 1, 0, 1 }, 6)]
    [DataRow(new[] { 1, 2, 3, 4 }, 0)]
    [DataRow(new[] { 4, 3, 2, 1, 0 }, 2)]
    [DataRow(new[] { 9, 9, 9, 9, 9, 9, 9 }, 6)]
    [DataRow(new[] { 3, 1, 4, 1, 5, 9, 2, 6 }, 3)]
    [DataRow(new[] { 2, 7, 1, 8, 2, 8, 1, 8, 2, 8 }, 1)]
    [DataRow(new[] { 0, 9 }, 9)]
    [DataRow(new[] { 7, 3 }, 0)]
    [DataRow(new[] { 6, 0, 6, 0, 6 }, 8)]
    [DataRow(new[] { 7, 9, 5, 4, 2, 2, 0, 5, 8, 7, 9, 1, 5, 8, 9, 0, 6, 2, 7, 6 }, 6)]
    [DataRow(new[] { 2, 2, 3, 0, 1, 2, 8, 9, 1, 6, 1, 4, 3, 3, 6, 1, 4, 3, 6, 4, 5, 0, 3, 0, 6, 0, 6, 7, 2, 0 }, 8)]
    public void TriangularSum_WithNums_ReturnsTriangularSumOfNums(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.TriangularSum(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}