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

using LeetCode.Algorithms.CheckIfArrayPairsAreDivisibleByK;

namespace LeetCode.Tests.Algorithms.CheckIfArrayPairsAreDivisibleByK;

public abstract class CheckIfArrayPairsAreDivisibleByKTestsBase<T> where T : ICheckIfArrayPairsAreDivisibleByK, new()
{
    [TestMethod]
    [DataRow(new[] { 0, 0, 0, 0 }, 100000, true)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 10, 6, 7, 8, 9 }, 5, true)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, 7, true)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, 10, false)]
    [DataRow(new[] { 0, 5, 10, 0 }, 5, true)]
    [DataRow(new[] { 987654321, -987654321, 765432100, -765432100 }, 99999, true)]
    [DataRow(new[] { -1, 0, -2, 2, -3, 3 }, 4, false)]
    [DataRow(new[] { -2, -4, -9, -3, -1, -17 }, 6, true)]
    [DataRow(new[] { 2, 2 }, 4, true)]
    [DataRow(new[] { 1, 3 }, 4, true)]
    [DataRow(new[] { 1, 2 }, 3, true)]
    [DataRow(new[] { 1, 1 }, 2, true)]
    [DataRow(new[] { 3, 1 }, 2, true)]
    [DataRow(new[] { 0, 0 }, 1, true)]
    [DataRow(new[] { 4, 5, 6, 7 }, 5, false)]
    [DataRow(new[] { -5, 5, -10, 10 }, 5, true)]
    [DataRow(new[] { 1, 2, 3, 4 }, 2, true)]
    [DataRow(new[] { 2, 4, 6, 8 }, 2, true)]
    [DataRow(new[] { 10, 20, 30, 40 }, 10, true)]
    [DataRow(new[] { 7, 3, 5, 15 }, 10, true)]
    public void CanArrange_WithArrayAndDivisor_ReturnsIfPairsCanBeArranged(int[] arr, int k, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CanArrange(arr, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}