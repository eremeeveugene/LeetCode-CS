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

using LeetCode.Algorithms.CalculateDigitSumOfAString;

namespace LeetCode.Tests.Algorithms.CalculateDigitSumOfAString;

public abstract class CalculateDigitSumOfAStringTestsBase<T> where T : ICalculateDigitSumOfAString, new()
{
    [TestMethod]
    [DataRow("11111222223", 3, "135")]
    [DataRow("00000000", 3, "000")]
    [DataRow("1", 2, "1")]
    [DataRow("12", 2, "12")]
    [DataRow("99", 2, "99")]
    [DataRow("00", 2, "00")]
    [DataRow("000", 2, "00")]
    [DataRow("100", 2, "10")]
    [DataRow("123", 2, "33")]
    [DataRow("999", 2, "99")]
    [DataRow("1111", 2, "22")]
    [DataRow("1234", 2, "37")]
    [DataRow("9999", 2, "99")]
    [DataRow("12345", 2, "15")]
    [DataRow("11111111", 2, "44")]
    [DataRow("11111111", 4, "44")]
    [DataRow("123456789", 3, "126")]
    [DataRow("123456789", 4, "99")]
    [DataRow("123456789", 9, "123456789")]
    [DataRow("987654321", 2, "36")]
    [DataRow("5555555555", 3, "95")]
    [DataRow("5555555555", 5, "2525")]
    [DataRow("1919191919", 2, "41")]
    [DataRow("1919191919", 10, "1919191919")]
    public void DigitSum_WithDigitsAndGroupSize_ReturnsFinalString(string s, int k, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.DigitSum(s, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}