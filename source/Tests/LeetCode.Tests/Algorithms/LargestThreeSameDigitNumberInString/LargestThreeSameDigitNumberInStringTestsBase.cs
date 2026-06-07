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

using LeetCode.Algorithms.LargestThreeSameDigitNumberInString;

namespace LeetCode.Tests.Algorithms.LargestThreeSameDigitNumberInString;

public abstract class LargestThreeSameDigitNumberInStringTestsBase<T> where T : ILargestThreeSameDigitNumberInString, new()
{
    [TestMethod]
    [DataRow("222", "222")]
    [DataRow("74444", "444")]
    [DataRow("6777133339", "777")]
    [DataRow("2300019", "000")]
    [DataRow("42352338", "")]
    [DataRow("000", "000")]
    [DataRow("999", "999")]
    [DataRow("111", "111")]
    [DataRow("1112", "111")]
    [DataRow("9990000", "999")]
    [DataRow("0001112223334445556667778889990000", "999")]
    [DataRow("12345678901234567890", "")]
    [DataRow("11122233344", "333")]
    [DataRow("555444333", "555")]
    [DataRow("100011", "000")]
    [DataRow("9999", "999")]
    [DataRow("8882228889", "888")]
    [DataRow("1234555", "555")]
    [DataRow("77700088", "777")]
    [DataRow("11199988", "999")]
    public void LargestGoodInteger_WithTripleRepeatingDigitSubstring_ReturnsMaximumGoodIntegerOrEmptyString(string num, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.LargestGoodInteger(num);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}