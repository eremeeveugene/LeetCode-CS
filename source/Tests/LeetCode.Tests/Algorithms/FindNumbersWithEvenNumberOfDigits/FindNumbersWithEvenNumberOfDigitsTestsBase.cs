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

using LeetCode.Algorithms.FindNumbersWithEvenNumberOfDigits;

namespace LeetCode.Tests.Algorithms.FindNumbersWithEvenNumberOfDigits;

public abstract class FindNumbersWithEvenNumberOfDigitsTestsBase<T> where T : IFindNumbersWithEvenNumberOfDigits, new()
{
    [TestMethod]
    [DataRow(new[] { 555, 901, 482, 1771 }, 1)]
    [DataRow(new[] { 12, 345, 2, 6, 7896 }, 2)]
    [DataRow(new[] { 100000 }, 1)]
    [DataRow(new[] { 10 }, 1)]
    [DataRow(new[] { 9 }, 0)]
    [DataRow(new[] { 99 }, 1)]
    [DataRow(new[] { 100 }, 0)]
    [DataRow(new[] { 999 }, 0)]
    [DataRow(new[] { 1000 }, 1)]
    [DataRow(new[] { 9999 }, 1)]
    [DataRow(new[] { 10000 }, 0)]
    [DataRow(new[] { 99999 }, 0)]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, 0)]
    [DataRow(new[] { 10, 100, 1000, 10000, 100000 }, 3)]
    [DataRow(new[] { 11, 22, 33 }, 3)]
    [DataRow(new[] { 123, 4567, 89 }, 2)]
    [DataRow(new[] { 100000, 99999, 10000, 1000 }, 2)]
    [DataRow(new[] { 5 }, 0)]
    [DataRow(new[] { 50, 500, 5000, 50000 }, 2)]
    [DataRow(new[] { 1234, 5678, 9012 }, 3)]
    [DataRow(new[] { 7 }, 0)]
    [DataRow(new[] { 999999 }, 1)]
    [DataRow(new[] { 1000000 }, 0)]
    [DataRow(new[] { 1234567 }, 0)]
    [DataRow(new[] { 10000000 }, 1)]
    [DataRow(new[] { 12345678 }, 1)]
    [DataRow(new[] { 99999999 }, 1)]
    [DataRow(new[] { 100000000 }, 0)]
    [DataRow(new[] { 123456789 }, 0)]
    [DataRow(new[] { 1000000000 }, 1)]
    [DataRow(new[] { 1234567890 }, 1)]
    [DataRow(new[] { 2147483647 }, 1)]
    [DataRow(new[] { 12345678, 1234567890, 1234567, 123456789 }, 2)]
    public void FindNumbers_WithArrayOfIntegers_ReturnsCountOfNumbersWithEvenNumberOfDigits(int[] nums, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.FindNumbers(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}