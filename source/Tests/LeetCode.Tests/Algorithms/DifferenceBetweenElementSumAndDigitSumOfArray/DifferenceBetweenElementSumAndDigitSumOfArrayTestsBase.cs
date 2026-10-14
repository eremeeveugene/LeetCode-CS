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

using LeetCode.Algorithms.DifferenceBetweenElementSumAndDigitSumOfArray;

namespace LeetCode.Tests.Algorithms.DifferenceBetweenElementSumAndDigitSumOfArray;

public abstract class DifferenceBetweenElementSumAndDigitSumOfArrayTestsBase<T> where T : IDifferenceBetweenElementSumAndDigitSumOfArray, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 15, 6, 3 }, 9)]
    [DataRow(new[] { 1, 2, 3, 4 }, 0)]
    [DataRow(new[] { 1 }, 0)]
    [DataRow(new[] { 10 }, 9)]
    [DataRow(new[] { 2000 }, 1998)]
    [DataRow(new[] { 9 }, 0)]
    [DataRow(new[] { 11 }, 9)]
    [DataRow(new[] { 1, 2, 3 }, 0)]
    [DataRow(new[] { 99, 99 }, 162)]
    [DataRow(new[] { 100, 200, 300 }, 594)]
    [DataRow(new[] { 1999, 2000 }, 3969)]
    [DataRow(new[] { 5, 5, 5, 5, 5 }, 0)]
    [DataRow(new[] { 12, 34, 56, 78 }, 144)]
    [DataRow(new[] { 1000, 1000, 1000 }, 2997)]
    [DataRow(new[] { 101, 202, 303 }, 594)]
    [DataRow(new[] { 7, 70, 700 }, 756)]
    [DataRow(new[] { 19, 28, 37, 46 }, 90)]
    [DataRow(new[] { 1, 10, 100, 1000 }, 1107)]
    [DataRow(new[] { 2000, 1999, 1998, 1997, 1996 }, 9882)]
    [DataRow(new[] { 123, 456, 789 }, 1323)]
    public void DifferenceOfSum_WithArrayOfIntegers_ReturnsAbsoluteDifferenceBetweenElementAndDigitSums(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.DifferenceOfSum(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}