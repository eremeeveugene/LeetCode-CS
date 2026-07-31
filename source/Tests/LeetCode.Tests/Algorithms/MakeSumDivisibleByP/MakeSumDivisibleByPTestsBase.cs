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

using LeetCode.Algorithms.MakeSumDivisibleByP;

namespace LeetCode.Tests.Algorithms.MakeSumDivisibleByP;

public abstract class MakeSumDivisibleByPTestsBase<T> where T : IMakeSumDivisibleByP, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 1, 4, 2 }, 6, 1)]
    [DataRow(new[] { 6, 3, 5, 2 }, 9, 2)]
    [DataRow(new[] { 1, 2, 3 }, 3, 0)]
    [DataRow(new[] { 1, 2, 3 }, 7, -1)]
    [DataRow(new[] { 2, 6, 4, 8 }, 5, 0)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 3, 0)]
    [DataRow(new[] { 9, 9, 9 }, 9, 0)]
    [DataRow(new[] { 4, 4, 4, 4, 4 }, 8, 1)]
    [DataRow(new[] { 1, 1, 1, 1, 1, 1 }, 4, 2)]
    [DataRow(new[] { 10, 20, 30 }, 7, -1)]
    [DataRow(new[] { 5, 5, 5, 5 }, 5, 0)]
    [DataRow(new[] { 2, 3, 5, 7, 11 }, 4, 0)]
    [DataRow(new[] { 1 }, 2, -1)]
    [DataRow(new[] { 6 }, 3, 0)]
    [DataRow(new[] { 3, 3, 3, 3 }, 6, 0)]
    [DataRow(new[] { 1, 4, 7, 2, 9 }, 5, 3)]
    [DataRow(new[] { 8, 2, 4, 6 }, 5, 0)]
    [DataRow(new[] { 1, 1, 1 }, 2, 1)]
    [DataRow(new[] { 100, 200, 300, 400 }, 13, -1)]
    [DataRow(new[] { 5, 10, 15, 20, 25 }, 11, 1)]
    [DataRow(new[] { 2, 2, 2, 2, 2, 2, 2 }, 3, 1)]
    [DataRow(new[] { 7, 14, 21 }, 6, 0)]
    [DataRow(new[] { 1, 2, 4, 8, 16 }, 6, 1)]
    [DataRow(new[] { 3, 6, 9, 12, 15 }, 10, 1)]
    [DataRow(new[] { 11, 13, 17, 19 }, 8, 2)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 15, 0)]
    public void MinSubarray_WithArrayAndDivisor_ReturnsMinSubarrayToRemove(int[] nums, int p, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinSubarray(nums, p);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}