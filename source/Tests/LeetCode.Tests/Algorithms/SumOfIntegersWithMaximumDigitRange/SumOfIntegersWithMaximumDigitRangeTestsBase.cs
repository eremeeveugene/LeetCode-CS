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

using LeetCode.Algorithms.SumOfIntegersWithMaximumDigitRange;

namespace LeetCode.Tests.Algorithms.SumOfIntegersWithMaximumDigitRange;

public abstract class SumOfIntegersWithMaximumDigitRangeTestsBase<T> where T : ISumOfIntegersWithMaximumDigitRange, new()
{
    [TestMethod]
    [DataRow(new[] { 5724, 111, 350 }, 6074)]
    [DataRow(new[] { 90, 900 }, 990)]
    [DataRow(new[] { 10 }, 10)]
    [DataRow(new[] { 12, 34, 56 }, 102)]
    [DataRow(new[] { 19, 28, 37 }, 19)]
    [DataRow(new[] { 10, 20, 30 }, 30)]
    [DataRow(new[] { 11, 22, 33 }, 66)]
    [DataRow(new[] { 91, 19 }, 110)]
    [DataRow(new[] { 100, 999 }, 100)]
    [DataRow(new[] { 123, 321 }, 444)]
    [DataRow(new[] { 50, 55, 59 }, 50)]
    [DataRow(new[] { 1024 }, 1024)]
    [DataRow(new[] { 13, 31, 20 }, 64)]
    [DataRow(new[] { 98, 89, 80 }, 80)]
    [DataRow(new[] { 111, 222, 333 }, 666)]
    [DataRow(new[] { 15, 51, 105 }, 105)]
    [DataRow(new[] { 70, 17 }, 70)]
    [DataRow(new[] { 1000 }, 1000)]
    [DataRow(new[] { 99999 }, 99999)]
    [DataRow(new[] { 12345, 54321 }, 66666)]
    [DataRow(new[] { 40, 44, 48 }, 88)]
    [DataRow(new[] { 10, 100, 1000 }, 1110)]
    public void MaxDigitRange_WithIntegerArray_ReturnsSumOfIntegersSharingMaximumDigitRange(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaxDigitRange(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}