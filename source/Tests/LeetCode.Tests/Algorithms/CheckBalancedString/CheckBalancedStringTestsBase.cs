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

using LeetCode.Algorithms.CheckBalancedString;

namespace LeetCode.Tests.Algorithms.CheckBalancedString;

public abstract class CheckBalancedStringTestsBase<T> where T : ICheckBalancedString, new()
{
    [TestMethod]
    [DataRow("1234", false)]
    [DataRow("24123", true)]
    [DataRow("11", true)]
    [DataRow("12", false)]
    [DataRow("00", true)]
    [DataRow("99", true)]
    [DataRow("10", false)]
    [DataRow("123321", true)]
    [DataRow("1111", true)]
    [DataRow("123", false)]
    [DataRow("303", false)]
    [DataRow("121", true)]
    [DataRow("56", false)]
    [DataRow("0000", true)]
    [DataRow("1001", true)]
    [DataRow("9090", false)]
    [DataRow("98765432", false)]
    [DataRow("13579", false)]
    [DataRow("2332", true)]
    [DataRow("44", true)]
    public void IsBalanced_WithInputNumberString_ReturnsIfNumberIsBalanced(string num, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.IsBalanced(num);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}