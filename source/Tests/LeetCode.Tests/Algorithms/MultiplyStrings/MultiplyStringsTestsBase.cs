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