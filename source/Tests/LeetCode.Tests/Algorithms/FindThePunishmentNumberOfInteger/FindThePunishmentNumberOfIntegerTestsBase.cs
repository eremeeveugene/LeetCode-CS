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