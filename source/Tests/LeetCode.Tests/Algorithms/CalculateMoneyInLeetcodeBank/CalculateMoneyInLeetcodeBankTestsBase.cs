// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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
    public void TotalMoney_WithInputN_ReturnsExpectedTotal(int n, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.TotalMoney(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}