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

using LeetCode.Algorithms.SelfDividingNumbers;

namespace LeetCode.Tests.Algorithms.SelfDividingNumbers;

public abstract class SelfDividingNumbersTestsBase<T> where T : ISelfDividingNumbers, new()
{
    [TestMethod]
    [DataRow(1, 22, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22 })]
    [DataRow(47, 85, new[] { 48, 55, 66, 77 })]
    [DataRow(1, 1, new[] { 1 })]
    [DataRow(11, 11, new[] { 11 })]
    [DataRow(1, 9, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })]
    [DataRow(10, 30, new[] { 11, 12, 15, 22, 24 })]
    [DataRow(100, 130, new[] { 111, 112, 115, 122, 124, 126, 128 })]
    [DataRow(120, 130, new[] { 122, 124, 126, 128 })]
    [DataRow(9990, 10000, new[] { 9999 })]
    [DataRow(9999, 9999, new[] { 9999 })]
    [DataRow(128, 128, new[] { 128 })]
    [DataRow(200, 250, new[] { 212, 216, 222, 224, 244, 248 })]
    [DataRow(1, 100, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22, 24, 33, 36, 44, 48, 55, 66, 77, 88, 99 })]
    [DataRow(77, 77, new[] { 77 })]
    [DataRow(99, 100, new[] { 99 })]
    [DataRow(22, 22, new[] { 22 })]
    [DataRow(1, 50, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22, 24, 33, 36, 44, 48 })]
    [DataRow(36, 36, new[] { 36 })]
    [DataRow(48, 48, new[] { 48 })]
    [DataRow(500, 600, new[] { 515, 555 })]
    [DataRow(700, 800, new[] { 728, 735, 777, 784 })]
    [DataRow(9000, 9999, new[] { 9126, 9135, 9144, 9162, 9216, 9288, 9315, 9324, 9333, 9396, 9432, 9612, 9648, 9666, 9864, 9936, 9999 })]
    public void SelfDividingNumbers_WithRangeBounds_ReturnsListOfSelfDividingNumbersWithinRange(int left, int right, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SelfDividingNumbers(left, right);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}