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

using LeetCode.Algorithms.AddStrings;

namespace LeetCode.Tests.Algorithms.AddStrings;

public abstract class AddStringsTestsBase<T> where T : IAddStrings, new()
{
    [TestMethod]
    [DataRow("0", "0", "0")]
    [DataRow("11", "123", "134")]
    [DataRow("456", "77", "533")]
    [DataRow("3876620623801494171", "6529364523802684779", "10405985147604178950")]
    [DataRow("1", "9", "10")]
    [DataRow("9", "1", "10")]
    [DataRow("99", "1", "100")]
    [DataRow("999", "999", "1998")]
    [DataRow("0", "123", "123")]
    [DataRow("123", "0", "123")]
    [DataRow("500", "500", "1000")]
    [DataRow("1", "999999999999999999", "1000000000000000000")]
    [DataRow("12345", "678", "13023")]
    [DataRow("100", "900", "1000")]
    [DataRow("55", "55", "110")]
    [DataRow("9", "9", "18")]
    [DataRow("10", "10", "20")]
    [DataRow("1234567890", "9876543210", "11111111100")]
    [DataRow("111111111", "888888889", "1000000000")]
    [DataRow("5", "5", "10")]
    public void AddStrings_WithNumericStrings_ReturnsSumAsString(string num1, string num2, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.AddStrings(num1, num2);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}