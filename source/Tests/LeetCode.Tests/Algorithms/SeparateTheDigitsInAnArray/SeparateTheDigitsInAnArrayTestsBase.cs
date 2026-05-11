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

using LeetCode.Algorithms.SeparateTheDigitsInAnArray;

namespace LeetCode.Tests.Algorithms.SeparateTheDigitsInAnArray;

public abstract class SeparateTheDigitsInAnArrayTestsBase<T> where T : ISeparateTheDigitsInAnArray, new()
{
    [TestMethod]
    [DataRow(new[] { 13, 25, 83, 77 }, new[] { 1, 3, 2, 5, 8, 3, 7, 7 })]
    [DataRow(new[] { 7, 1, 3, 9 }, new[] { 7, 1, 3, 9 })]
    [DataRow(new[] { 1 }, new[] { 1 })]
    [DataRow(new[] { 9 }, new[] { 9 })]
    [DataRow(new[] { 10 }, new[] { 1, 0 })]
    [DataRow(new[] { 100 }, new[] { 1, 0, 0 })]
    [DataRow(new[] { 1000 }, new[] { 1, 0, 0, 0 })]
    [DataRow(new[] { 10000 }, new[] { 1, 0, 0, 0, 0 })]
    [DataRow(new[] { 100000 }, new[] { 1, 0, 0, 0, 0, 0 })]
    [DataRow(new[] { 101 }, new[] { 1, 0, 1 })]
    [DataRow(new[] { 10921 }, new[] { 1, 0, 9, 2, 1 })]
    [DataRow(new[] { 99 }, new[] { 9, 9 })]
    [DataRow(new[] { 99999 }, new[] { 9, 9, 9, 9, 9 })]
    [DataRow(new[] { 12345 }, new[] { 1, 2, 3, 4, 5 })]
    [DataRow(new[] { 54321 }, new[] { 5, 4, 3, 2, 1 })]
    [DataRow(new[] { 1, 10, 100, 1000 }, new[] { 1, 1, 0, 1, 0, 0, 1, 0, 0, 0 })]
    [DataRow(new[] { 90, 80, 70 }, new[] { 9, 0, 8, 0, 7, 0 })]
    [DataRow(new[] { 11, 22, 33, 44 }, new[] { 1, 1, 2, 2, 3, 3, 4, 4 })]
    [DataRow(new[] { 5, 50, 500, 5000, 50000 }, new[] { 5, 5, 0, 5, 0, 0, 5, 0, 0, 0, 5, 0, 0, 0, 0 })]
    [DataRow(new[] { 100000, 1, 99999 }, new[] { 1, 0, 0, 0, 0, 0, 1, 9, 9, 9, 9, 9 })]
    public void SeparateDigits_WithGivenNums_ReturnsDigitsSeparatedInOriginalOrder(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SeparateDigits(nums);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}