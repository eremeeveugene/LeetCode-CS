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

using LeetCode.Algorithms.HarshadNumber;

namespace LeetCode.Tests.Algorithms.HarshadNumber;

public abstract class HarshadNumberTestsBase<T> where T : IHarshadNumber, new()
{
    [TestMethod]
    [DataRow(18, 9)]
    [DataRow(23, -1)]
    [DataRow(0, -1)]
    [DataRow(1, 1)]
    [DataRow(2, 2)]
    [DataRow(9, 9)]
    [DataRow(10, 1)]
    [DataRow(11, -1)]
    [DataRow(12, 3)]
    [DataRow(13, -1)]
    [DataRow(19, -1)]
    [DataRow(21, 3)]
    [DataRow(27, 9)]
    [DataRow(36, 9)]
    [DataRow(45, 9)]
    [DataRow(54, 9)]
    [DataRow(67, -1)]
    [DataRow(81, 9)]
    [DataRow(90, 9)]
    [DataRow(99, -1)]
    [DataRow(100, 1)]
    [DataRow(17, -1)]
    [DataRow(20, 2)]
    public void SumOfTheDigitsOfHarshadNumber_GivenInputNumber_ReturnsSumOrMinusOne(int x, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SumOfTheDigitsOfHarshadNumber(x);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}