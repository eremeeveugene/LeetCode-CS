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

using LeetCode.Algorithms.MultiplyStrings;

namespace LeetCode.Tests.Algorithms.MultiplyStrings;

public abstract class MultiplyStringsTestsBase<T> where T : IMultiplyStrings, new()
{
    [TestMethod]
    [DataRow("0", "0", "0")]
    [DataRow("2", "3", "6")]
    [DataRow("123", "456", "56088")]
    [DataRow("999", "999", "998001")]
    [DataRow("999", "999999", "998999001")]
    [DataRow("1", "1", "1")]
    [DataRow("0", "1", "0")]
    [DataRow("1", "0", "0")]
    [DataRow("9", "9", "81")]
    [DataRow("10", "10", "100")]
    [DataRow("100", "100", "10000")]
    [DataRow("12", "12", "144")]
    [DataRow("99", "99", "9801")]
    [DataRow("9999", "9999", "99980001")]
    [DataRow("123456789", "987654321", "121932631112635269")]
    [DataRow("2", "100", "200")]
    [DataRow("0", "999", "0")]
    [DataRow("1000", "1000", "1000000")]
    [DataRow("11", "11", "121")]
    [DataRow("999999999", "1", "999999999")]
    public void Multiply_WithTwoStringNumbers_ReturnsProduct(string num1, string num2, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.Multiply(num1, num2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}