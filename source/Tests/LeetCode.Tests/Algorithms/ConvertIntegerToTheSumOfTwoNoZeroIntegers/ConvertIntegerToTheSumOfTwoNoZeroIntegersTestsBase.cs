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

using LeetCode.Algorithms.ConvertIntegerToTheSumOfTwoNoZeroIntegers;

namespace LeetCode.Tests.Algorithms.ConvertIntegerToTheSumOfTwoNoZeroIntegers;

public abstract class ConvertIntegerToTheSumOfTwoNoZeroIntegersTestsBase<T> where T : IConvertIntegerToTheSumOfTwoNoZeroIntegers, new()
{
    [TestMethod]
    [DataRow(2, new[] { 1, 1 })]
    [DataRow(11, new[] { 2, 9 })]
    [DataRow(69, new[] { 1, 68 })]
    [DataRow(699, new[] { 1, 698 })]
    [DataRow(700, new[] { 1, 699 })]
    [DataRow(701, new[] { 2, 699 })]
    [DataRow(1010, new[] { 11, 999 })]
    [DataRow(3, new[] { 1, 2 })]
    [DataRow(4, new[] { 1, 3 })]
    [DataRow(5, new[] { 1, 4 })]
    [DataRow(9, new[] { 1, 8 })]
    [DataRow(10, new[] { 1, 9 })]
    [DataRow(12, new[] { 1, 11 })]
    [DataRow(20, new[] { 1, 19 })]
    [DataRow(100, new[] { 1, 99 })]
    [DataRow(101, new[] { 2, 99 })]
    [DataRow(102, new[] { 3, 99 })]
    [DataRow(1000, new[] { 1, 999 })]
    [DataRow(10000, new[] { 1, 9999 })]
    [DataRow(1001, new[] { 2, 999 })]
    [DataRow(9999, new[] { 1, 9998 })]
    [DataRow(5000, new[] { 1, 4999 })]
    [DataRow(1111, new[] { 112, 999 })]
    [DataRow(2020, new[] { 21, 1999 })]
    public void GetNoZeroIntegers_WithPositiveIntegerN_ReturnsTwoNoZeroIntegersThatSumToN(int n, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.GetNoZeroIntegers(n);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}