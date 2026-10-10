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

using LeetCode.Algorithms.MaximumDifferenceByRemappingDigit;

namespace LeetCode.Tests.Algorithms.MaximumDifferenceByRemappingDigit;

public abstract class MaximumDifferenceByRemappingDigitTestsBase<T> where T : IMaximumDifferenceByRemappingDigit, new()
{
    [TestMethod]
    [DataRow(11891, 99009)]
    [DataRow(90, 99)]
    [DataRow(1, 9)]
    [DataRow(9, 9)]
    [DataRow(10, 90)]
    [DataRow(99, 99)]
    [DataRow(100, 900)]
    [DataRow(999, 999)]
    [DataRow(90909, 99999)]
    [DataRow(12345, 90000)]
    [DataRow(98765, 91000)]
    [DataRow(55555, 99999)]
    [DataRow(100000000, 900000000)]
    [DataRow(99999999, 99999999)]
    [DataRow(60, 90)]
    [DataRow(19, 90)]
    [DataRow(909, 999)]
    [DataRow(1000, 9000)]
    [DataRow(87654321, 90000000)]
    [DataRow(11111111, 99999999)]
    [DataRow(28516, 90000)]
    public void MinMaxDifference_WithDigitRemapping_ReturnsDifferenceBetweenMaxAndMin(int num, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MinMaxDifference(num);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}