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

using LeetCode.Algorithms.UniqueThreeDigitEvenNumbers;

namespace LeetCode.Tests.Algorithms.UniqueThreeDigitEvenNumbers;

public abstract class UniqueThreeDigitEvenNumbersTestsBase<T> where T : IUniqueThreeDigitEvenNumbers, new()
{
    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4 }, 12)]
    [DataRow(new[] { 0, 2, 2 }, 2)]
    [DataRow(new[] { 6, 6, 6 }, 1)]
    [DataRow(new[] { 1, 3, 5 }, 0)]
    [DataRow(new[] { 0, 0, 0 }, 0)]
    [DataRow(new[] { 2, 2, 2 }, 1)]
    [DataRow(new[] { 1, 0, 2 }, 3)]
    [DataRow(new[] { 9, 8, 7, 6 }, 12)]
    [DataRow(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 328)]
    [DataRow(new[] { 1, 1, 1 }, 0)]
    [DataRow(new[] { 2, 4, 6, 8 }, 24)]
    [DataRow(new[] { 1, 2, 2 }, 2)]
    [DataRow(new[] { 0, 0, 1 }, 1)]
    [DataRow(new[] { 5, 5, 5 }, 0)]
    [DataRow(new[] { 3, 1, 4, 1, 5, 9, 2, 6 }, 93)]
    [DataRow(new[] { 0, 2, 4 }, 4)]
    public void TotalNumbers_WithGivenDigitsArray_ReturnsUniqueThreeDigitEvenNumbers(int[] digits, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.TotalNumbers(digits);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}