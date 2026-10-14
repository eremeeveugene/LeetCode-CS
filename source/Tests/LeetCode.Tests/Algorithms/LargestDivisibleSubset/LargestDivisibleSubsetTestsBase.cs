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

using LeetCode.Algorithms.LargestDivisibleSubset;

namespace LeetCode.Tests.Algorithms.LargestDivisibleSubset;

public abstract class LargestDivisibleSubsetTestsBase<T> where T : ILargestDivisibleSubset, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3 }, new[] { 1, 2 })]
    [DataRow(new[] { 1, 2, 4, 8 }, new[] { 1, 2, 4, 8 })]
    [DataRow(new[] { 1 }, new[] { 1 })]
    [DataRow(new[] { 5 }, new[] { 5 })]
    [DataRow(new[] { 1, 2, 4, 8, 16 }, new[] { 1, 2, 4, 8, 16 })]
    [DataRow(new[] { 3, 6, 12, 24 }, new[] { 3, 6, 12, 24 })]
    [DataRow(new[] { 1, 3, 9, 27, 81 }, new[] { 1, 3, 9, 27, 81 })]
    [DataRow(new[] { 4, 8, 16, 3 }, new[] { 4, 8, 16 })]
    [DataRow(new[] { 1000000000, 1 }, new[] { 1, 1000000000 })]
    [DataRow(new[] { 2, 4, 7, 8, 9, 16 }, new[] { 2, 4, 8, 16 })]
    [DataRow(new[] { 1, 2, 4, 8, 3, 9 }, new[] { 1, 2, 4, 8 })]
    [DataRow(new[] { 5, 10, 20, 40, 7 }, new[] { 5, 10, 20, 40 })]
    [DataRow(new[] { 8, 4, 2, 1 }, new[] { 1, 2, 4, 8 })]
    [DataRow(new[] { 16, 1, 8, 2, 4 }, new[] { 1, 2, 4, 8, 16 })]
    [DataRow(new[] { 6, 12, 24, 5, 10 }, new[] { 6, 12, 24 })]
    [DataRow(new[] { 2, 6, 12, 36, 5 }, new[] { 2, 6, 12, 36 })]
    [DataRow(new[] { 7, 14, 28, 56, 3, 9 }, new[] { 7, 14, 28, 56 })]
    [DataRow(new[] { 1, 2000000000 }, new[] { 1, 2000000000 })]
    [DataRow(new[] { 3, 4, 16, 8, 12, 48 }, new[] { 4, 8, 16, 48 })]
    [DataRow(new[] { 100, 50, 25, 5, 1 }, new[] { 1, 5, 25, 50, 100 })]
    public void LargestDivisibleSubset_WithArrayOfIntegers_ReturnsSubsetWhereEveryPairIsDivisible(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualSubset = solution.LargestDivisibleSubset(nums);
        var actualResult = new int[actualSubset.Count];

        actualSubset.CopyTo(actualResult, 0);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}