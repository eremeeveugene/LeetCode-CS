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

using LeetCode.Algorithms.GreatestSumDivisibleByThree;

namespace LeetCode.Tests.Algorithms.GreatestSumDivisibleByThree;

public abstract class GreatestSumDivisibleByThreeTestsBase<T> where T : IGreatestSumDivisibleByThree, new()
{
    [TestMethod]
    [DataRow(new[] { 3, 6, 5, 1, 8 }, 18)]
    [DataRow(new[] { 4 }, 0)]
    [DataRow(new[] { 1, 2, 3, 4, 4 }, 12)]
    [DataRow(new[] { 3 }, 3)]
    [DataRow(new[] { 6 }, 6)]
    [DataRow(new[] { 1 }, 0)]
    [DataRow(new[] { 3, 3, 3 }, 9)]
    [DataRow(new[] { 1, 2 }, 3)]
    [DataRow(new[] { 2, 2, 2 }, 6)]
    [DataRow(new[] { 1, 1, 1 }, 3)]
    [DataRow(new[] { 9, 9, 9 }, 27)]
    [DataRow(new[] { 7, 7, 7 }, 21)]
    [DataRow(new[] { 5, 5, 5 }, 15)]
    [DataRow(new[] { 2, 5, 3, 1 }, 9)]
    [DataRow(new[] { 100, 200, 300 }, 600)]
    [DataRow(new[] { 100, 200, 301 }, 501)]
    [DataRow(new[] { 0, 0, 0 }, 0)]
    [DataRow(new[] { 300000000, 600000000, 900000000 }, 1800000000)]
    [DataRow(new[] { 2, 1, 3, 4 }, 9)]
    [DataRow(new[] { 6, 3, 9, 1, 2 }, 21)]
    public void MaxSumDivThree_WithNumsArray_ReturnsMaxSumDivisibleByThree(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxSumDivThree(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}