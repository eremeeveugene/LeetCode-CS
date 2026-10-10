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

using LeetCode.Algorithms.CalculateMoneyInLeetcodeBank;

namespace LeetCode.Tests.Algorithms.CalculateMoneyInLeetcodeBank;

public abstract class CalculateMoneyInLeetcodeBankTestsBase<T> where T : ICalculateMoneyInLeetcodeBank, new()
{
    [TestMethod]
    [DataRow(4, 10)]
    [DataRow(10, 37)]
    [DataRow(20, 96)]
    [DataRow(1, 1)]
    [DataRow(2, 3)]
    [DataRow(3, 6)]
    [DataRow(5, 15)]
    [DataRow(6, 21)]
    [DataRow(7, 28)]
    [DataRow(8, 30)]
    [DataRow(9, 33)]
    [DataRow(14, 63)]
    [DataRow(15, 66)]
    [DataRow(21, 105)]
    [DataRow(28, 154)]
    [DataRow(30, 165)]
    [DataRow(35, 210)]
    [DataRow(49, 343)]
    [DataRow(100, 1060)]
    [DataRow(1000, 74926)]
    public void TotalMoney_WithNumberOfSavingDays_ReturnsTotalAccumulatedAmount(int n, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.TotalMoney(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}