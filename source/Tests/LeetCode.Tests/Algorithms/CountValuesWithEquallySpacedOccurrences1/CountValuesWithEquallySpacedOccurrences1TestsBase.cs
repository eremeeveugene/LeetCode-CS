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

using LeetCode.Algorithms.CountValuesWithEquallySpacedOccurrences1;

namespace LeetCode.Tests.Algorithms.CountValuesWithEquallySpacedOccurrences1;

public abstract class CountValuesWithEquallySpacedOccurrences1TestsBase<T> where T : ICountValuesWithEquallySpacedOccurrences1, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 8, 1, 5, 1, 5, 8, 5 }, 2)]
    [DataRow(new[] { 8, 8, 8, 8 }, 0)]
    [DataRow(new[] { 8, 6, 6, 8, 8 }, 0)]
    [DataRow(new[] { 1, 1, 1 }, 1)]
    [DataRow(new[] { 100, 100, 100 }, 1)]
    [DataRow(new[] { 1, 2, 3 }, 0)]
    [DataRow(new[] { 1, 1, 2 }, 0)]
    [DataRow(new[] { 1, 2, 1 }, 0)]
    [DataRow(new[] { 1, 2, 2 }, 0)]
    [DataRow(new[] { 1, 1, 1, 1, 1 }, 0)]
    [DataRow(new[] { 1, 2, 1, 2, 1 }, 1)]
    [DataRow(new[] { 1, 2, 1, 2, 1, 2 }, 2)]
    [DataRow(new[] { 1, 1, 2, 1 }, 0)]
    [DataRow(new[] { 1, 2, 1, 1 }, 0)]
    [DataRow(new[] { 1, 1, 1, 2 }, 1)]
    [DataRow(new[] { 2, 1, 1, 1 }, 1)]
    [DataRow(new[] { 1, 1, 1, 2, 2, 2 }, 2)]
    [DataRow(new[] { 1, 2, 3, 1, 2, 3, 1, 2, 3 }, 3)]
    [DataRow(new[] { 1, 2, 1, 2, 1, 2, 1 }, 1)]
    [DataRow(new[] { 1, 2, 1, 2, 1, 2, 1, 2 }, 0)]
    [DataRow(new[] { 1, 2, 3, 1, 4, 5, 1 }, 1)]
    [DataRow(new[] { 1, 2, 3, 1, 4, 1 }, 0)]
    [DataRow(new[] { 1, 2, 1, 3, 4, 1 }, 0)]
    [DataRow(new[] { 100, 1, 100, 2, 100 }, 1)]
    [DataRow(new[] { 1, 100, 1, 100, 1, 100 }, 2)]
    [DataRow(new[] { 1, 2, 2, 1, 2, 1 }, 0)]
    [DataRow(new[] { 1, 2, 1, 2, 2, 1 }, 0)]
    [DataRow(new[] { 1, 1, 1, 2, 3, 2, 3, 2 }, 2)]
    [DataRow(new[] { 1, 1, 1, 1, 2, 2, 2 }, 1)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 0)]
    [DataRow(new[] { 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4 }, 4)]
    [DataRow(new[] { 100, 99, 98, 100, 99, 98, 100, 99, 98 }, 3)]
    public void CountSpecialIntegers_WithGivenNumbers_ReturnsCountOfValuesWithThreeEquallySpacedOccurrences(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountSpecialIntegers(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}