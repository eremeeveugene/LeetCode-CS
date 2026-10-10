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

using LeetCode.Algorithms.ArithmeticSubarrays;

namespace LeetCode.Tests.Algorithms.ArithmeticSubarrays;

public abstract class ArithmeticSubarraysTestsBase<T> where T : IArithmeticSubarrays, new()
{
    [TestMethod]
    [DataRow(new[] { 4, 6, 5, 9, 3, 7 }, new[] { 0, 0, 2 }, new[] { 2, 3, 5 }, new[] { true, false, true })]
    [DataRow(
        new[] { -12, -9, -3, -12, -6, 15, 20, -25, -20, -15, -10 },
        new[] { 0, 1, 6, 4, 8, 7 },
        new[] { 4, 4, 9, 7, 9, 10 },
        new[] { false, true, false, false, true, true })]
    [DataRow(new[] { 1, 2, 3 }, new[] { 0, 1 }, new[] { 1, 2 }, new[] { true, true })]
    [DataRow(new[] { 10, 1, 3, 5 }, new[] { 0, 1 }, new[] { 2, 3 }, new[] { false, true })]
    [DataRow(new[] { 1, 3, 5, 7, 9 }, new[] { 0, 1, 2 }, new[] { 4, 3, 4 }, new[] { true, true, true })]
    [DataRow(new[] { 1, 2, 4 }, new[] { 0, 1 }, new[] { 2, 2 }, new[] { false, true })]
    [DataRow(new[] { 1, 2 }, new[] { 0 }, new[] { 1 }, new[] { true })]
    [DataRow(new[] { 5, 5 }, new[] { 0 }, new[] { 1 }, new[] { true })]
    [DataRow(new[] { 1, 3, 2 }, new[] { 0 }, new[] { 2 }, new[] { true })]
    [DataRow(new[] { 1, 2, 4 }, new[] { 0 }, new[] { 2 }, new[] { false })]
    [DataRow(new[] { 3, 1, 2, 5 }, new[] { 0, 1 }, new[] { 3, 3 }, new[] { false, false })]
    [DataRow(new[] { 10, 8, 6, 4 }, new[] { 0 }, new[] { 3 }, new[] { true })]
    [DataRow(new[] { 1, 1, 1, 1 }, new[] { 0, 1, 2 }, new[] { 3, 3, 3 }, new[] { true, true, true })]
    [DataRow(new[] { 1, 2, 3, 5 }, new[] { 0, 1, 0 }, new[] { 2, 3, 3 }, new[] { true, false, false })]
    [DataRow(new[] { -1, -3, -5, 0 }, new[] { 0, 1 }, new[] { 2, 3 }, new[] { true, false })]
    [DataRow(new[] { 0, 0, 1 }, new[] { 0, 1 }, new[] { 1, 2 }, new[] { true, true })]
    [DataRow(new[] { 7, 1, 4, 10 }, new[] { 0 }, new[] { 3 }, new[] { true })]
    [DataRow(new[] { 1, 5, 2, 9 }, new[] { 0, 2 }, new[] { 2, 3 }, new[] { false, true })]
    [DataRow(new[] { 100000, 0, 50000 }, new[] { 0 }, new[] { 2 }, new[] { true })]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6 }, new[] { 0, 1, 2 }, new[] { 5, 4, 3 }, new[] { true, true, true })]
    [DataRow(new[] { 3, 6, 9, 12, 15, 1 }, new[] { 0, 0 }, new[] { 4, 5 }, new[] { true, false })]
    public void CheckArithmeticSubarrays_WithVariousRanges_VerifiesIfSubarraysAreArithmetic(int[] nums, int[] l, int[] r, bool[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CheckArithmeticSubarrays(nums, l, r);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}