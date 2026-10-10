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

using LeetCode.Algorithms.MaximumNumberOfIntegersToChooseFromRange1;

namespace LeetCode.Tests.Algorithms.MaximumNumberOfIntegersToChooseFromRange1;

public abstract class MaximumNumberOfIntegersToChooseFromRange1TestsBase<T> where T : IMaximumNumberOfIntegersToChooseFromRange1, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 6, 5 }, 5, 6, 2)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7 }, 8, 1, 0)]
    [DataRow(new[] { 11 }, 7, 50, 7)]
    [DataRow(new int[] { }, 1, 1, 1)]
    [DataRow(new[] { 1 }, 1, 1, 0)]
    [DataRow(new int[] { }, 10, 55, 10)]
    [DataRow(new int[] { }, 10, 54, 9)]
    [DataRow(new[] { 2, 4, 6, 8 }, 10, 20, 4)]
    [DataRow(new[] { 1, 2, 3 }, 3, 100, 0)]
    [DataRow(new[] { 5 }, 5, 10, 4)]
    [DataRow(new[] { 1, 1, 1 }, 4, 6, 2)]
    [DataRow(new[] { 10000 }, 10000, 1000000000, 9999)]
    [DataRow(new int[] { }, 10000, 1000000000, 10000)]
    [DataRow(new int[] { }, 10000, 50005000, 10000)]
    [DataRow(new int[] { }, 10000, 50004999, 9999)]
    [DataRow(new[] { 3, 3, 3, 7, 7 }, 8, 15, 4)]
    [DataRow(new[] { 9999, 10000, 1 }, 10000, 100, 12)]
    [DataRow(new[] { 2, 3, 5, 7, 11, 13 }, 15, 40, 6)]
    [DataRow(new[] { 4 }, 3, 5, 2)]
    [DataRow(new[] { 1, 3, 5, 7, 9 }, 10, 30, 5)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104 }, 200, 1000, 9)]
    public void MaxCount_WithBannedArrayNAndMaxSum_ReturnsMaximumCount(int[] banned, int n, int maxSum, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxCount(banned, n, maxSum);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}