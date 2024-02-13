// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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
    [DataRow(new[] { -12, -9, -3, -12, -6, 15, 20, -25, -20, -15, -10 }, new[] { 0, 1, 6, 4, 8, 7 },
        new[] { 4, 4, 9, 7, 9, 10 }, new[] { false, true, false, false, true, true })]
    public void CheckArithmeticSubarrays_WithVariousRanges_VerifiesIfSubarraysAreArithmetic(int[] nums, int[] l,
        int[] r, bool[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CheckArithmeticSubarrays(nums, l, r);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult.ToArray());
    }
}