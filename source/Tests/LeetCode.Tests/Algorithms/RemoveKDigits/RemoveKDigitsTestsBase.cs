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

using LeetCode.Algorithms.RemoveKDigits;

namespace LeetCode.Tests.Algorithms.RemoveKDigits;

public abstract class RemoveKDigitsTestsBase<T> where T : IRemoveKDigits, new()
{
    [TestMethod]
    [DataRow("10", 2, "0")]
    [DataRow("500", 3, "0")]
    [DataRow("100", 1, "0")]
    [DataRow("10200", 1, "200")]
    [DataRow("1432219", 3, "1219")]
    [DataRow("1234567", 1, "123456")]
    [DataRow("3238900989831", 5, "989831")]
    [DataRow("3238900989831", 6, "89831")]
    [DataRow("52374333400072837283091820", 6, "23300072837283091820")]
    [DataRow("1234567890", 3, "1234560")]
    [DataRow("112", 1, "11")]
    [DataRow("7654321", 7, "0")]
    [DataRow("9999", 2, "99")]
    [DataRow("112", 2, "1")]
    [DataRow("10001", 2, "0")]
    [DataRow("20001", 2, "0")]
    [DataRow("112", 0, "112")]
    [DataRow("1111111", 3, "1111")]
    [DataRow("987654321", 5, "4321")]
    [DataRow("123456789", 3, "123456")]
    [DataRow("4321", 2, "21")]
    [DataRow("1000000", 1, "0")]
    [DataRow("9", 0, "9")]
    [DataRow("10001", 1, "1")]
    [DataRow("1173", 2, "11")]
    [DataRow("9876", 1, "876")]
    [DataRow("1000", 4, "0")]
    public void RemoveKDigits_WithNumericStringAndDigitsToRemove_ReturnsSmallestPossibleNumberAsString(string num, int k, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.RemoveKdigits(num, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}