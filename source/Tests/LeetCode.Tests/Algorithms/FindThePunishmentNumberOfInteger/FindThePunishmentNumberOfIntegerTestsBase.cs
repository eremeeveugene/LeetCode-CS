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

using LeetCode.Algorithms.FindThePunishmentNumberOfInteger;

namespace LeetCode.Tests.Algorithms.FindThePunishmentNumberOfInteger;

public abstract class FindThePunishmentNumberOfIntegerTestsBase<T> where T : IFindThePunishmentNumberOfInteger, new()
{
    [TestMethod]
    [DataRow(10, 182)]
    [DataRow(37, 1478)]
    [DataRow(1, 1)]
    [DataRow(2, 1)]
    [DataRow(3, 1)]
    [DataRow(8, 1)]
    [DataRow(9, 82)]
    [DataRow(15, 182)]
    [DataRow(18, 182)]
    [DataRow(19, 182)]
    [DataRow(20, 182)]
    [DataRow(36, 1478)]
    [DataRow(45, 3503)]
    [DataRow(55, 6528)]
    [DataRow(81, 6528)]
    [DataRow(100, 41334)]
    [DataRow(200, 41334)]
    [DataRow(500, 772866)]
    [DataRow(999, 9804657)]
    [DataRow(1000, 10804657)]
    public void PunishmentNumber_WithGivenLimit_ReturnsSumOfValidNumbers(int n, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.PunishmentNumber(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}