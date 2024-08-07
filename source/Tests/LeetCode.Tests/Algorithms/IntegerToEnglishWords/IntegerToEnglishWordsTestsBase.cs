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

using LeetCode.Algorithms.IntegerToEnglishWords;

namespace LeetCode.Tests.Algorithms.IntegerToEnglishWords;

public abstract class IntegerToEnglishWordsTestsBase<T> where T : IIntegerToEnglishWords, new()
{
    [TestMethod]
    [DataRow(0, "Zero")]
    [DataRow(1, "One")]
    [DataRow(2, "Two")]
    [DataRow(3, "Three")]
    [DataRow(10, "Ten")]
    [DataRow(11, "Eleven")]
    [DataRow(21, "Twenty One")]
    [DataRow(100, "One Hundred")]
    [DataRow(101, "One Hundred One")]
    [DataRow(110, "One Hundred Ten")]
    [DataRow(111, "One Hundred Eleven")]
    [DataRow(999, "Nine Hundred Ninety Nine")]
    [DataRow(1000, "One Thousand")]
    [DataRow(1001, "One Thousand One")]
    [DataRow(1010, "One Thousand Ten")]
    [DataRow(1100, "One Thousand One Hundred")]
    [DataRow(1111, "One Thousand One Hundred Eleven")]
    [DataRow(20000, "Twenty Thousand")]
    [DataRow(25942, "Twenty Five Thousand Nine Hundred Forty Two")]
    [DataRow(300000, "Three Hundred Thousand")]
    [DataRow(1000000, "One Million")]
    [DataRow(123, "One Hundred Twenty Three")]
    [DataRow(12345, "Twelve Thousand Three Hundred Forty Five")]
    [DataRow(123456, "One Hundred Twenty Three Thousand Four Hundred Fifty Six")]
    [DataRow(1234567, "One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven")]
    [DataRow(987654321, "Nine Hundred Eighty Seven Million Six Hundred Fifty Four Thousand Three Hundred Twenty One")]
    [DataRow(1000000000, "One Billion")]
    public void NumberToWords_GivenInteger_ReturnsEnglishWords(int num, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.NumberToWords(num);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}