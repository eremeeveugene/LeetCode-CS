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

using LeetCode.Algorithms.MinimumNumberOfOperationsToMoveAllBallsToEachBox;

namespace LeetCode.Tests.Algorithms.MinimumNumberOfOperationsToMoveAllBallsToEachBox;

public abstract class MinimumNumberOfOperationsToMoveAllBallsToEachBoxTestsBase<T> where T : IMinimumNumberOfOperationsToMoveAllBallsToEachBox, new()
{
    [TestMethod]
    [DataRow("110", new[] { 1, 1, 3 })]
    [DataRow("001011", new[] { 11, 8, 5, 4, 3, 4 })]
    [DataRow("1", new[] { 0 })]
    [DataRow("0", new[] { 0 })]
    [DataRow("11", new[] { 1, 1 })]
    [DataRow("00", new[] { 0, 0 })]
    [DataRow("01", new[] { 1, 0 })]
    [DataRow("10", new[] { 0, 1 })]
    [DataRow("111", new[] { 3, 2, 3 })]
    [DataRow("000", new[] { 0, 0, 0 })]
    [DataRow("101", new[] { 2, 2, 2 })]
    [DataRow("010", new[] { 1, 0, 1 })]
    [DataRow("1001", new[] { 3, 3, 3, 3 })]
    [DataRow("11110", new[] { 6, 4, 4, 6, 10 })]
    [DataRow("00001", new[] { 4, 3, 2, 1, 0 })]
    [DataRow("1010101", new[] { 12, 10, 8, 8, 8, 10, 12 })]
    [DataRow("100000001", new[] { 8, 8, 8, 8, 8, 8, 8, 8, 8 })]
    [DataRow("0110110", new[] { 12, 8, 6, 6, 6, 8, 12 })]
    [DataRow("11111111", new[] { 28, 22, 18, 16, 16, 18, 22, 28 })]
    [DataRow("10000000000", new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
    [DataRow("0101010101010", new[] { 36, 30, 26, 22, 20, 18, 18, 18, 20, 22, 26, 30, 36 })]
    [DataRow("111000111000", new[] { 24, 20, 18, 18, 18, 18, 18, 20, 24, 30, 36, 42 })]
    public void MinOperations_WithBinaryString_ReturnsOperationsCountArray(string s, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinOperations(s);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}