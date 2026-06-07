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

using LeetCode.Algorithms.LengthOfLongestFibonacciSubsequence;

namespace LeetCode.Tests.Algorithms.LengthOfLongestFibonacciSubsequence;

public abstract class LengthOfLongestFibonacciSubsequenceTestsBase<T> where T : ILengthOfLongestFibonacciSubsequence, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 5)]
    [DataRow(new[] { 1, 3, 7, 11, 12, 14, 18 }, 3)]
    [DataRow(new[] { 2, 4, 7, 8, 9, 10 }, 3)]
    [DataRow(new[] { 1, 4, 7 }, 0)]
    [DataRow(new[] { 1, 4, 10 }, 0)]
    [DataRow(new[] { 1, 2 }, 0)]
    [DataRow(new[] { 1, 2, 3 }, 3)]
    [DataRow(new[] { 2, 4, 8 }, 0)]
    [DataRow(new[] { 1, 2, 3, 5, 8, 13, 21, 34 }, 8)]
    [DataRow(new[] { 1, 2, 3, 4 }, 3)]
    [DataRow(new[] { 1, 2, 3, 5, 8 }, 5)]
    [DataRow(new[] { 2, 4, 6, 10, 16, 26 }, 6)]
    [DataRow(new[] { 3, 5, 8, 13, 21 }, 5)]
    [DataRow(new[] { 5, 10, 15, 20, 25 }, 4)]
    [DataRow(new[] { 1, 5, 10, 15, 25 }, 4)]
    [DataRow(new[] { 1, 6, 7, 8, 9, 10 }, 3)]
    [DataRow(new[] { 1, 100, 101, 200, 300 }, 3)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 4)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, 4)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7 }, 4)]
    [DataRow(new[] { 1, 3 }, 0)]
    [DataRow(new[] { 1, 11, 12, 23, 35 }, 5)]
    public void LenLongestFibSubseq_GivenIntegerArray_ReturnsMaxFibonacciSubsequenceLength(int[] arr, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LenLongestFibSubseq(arr);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}