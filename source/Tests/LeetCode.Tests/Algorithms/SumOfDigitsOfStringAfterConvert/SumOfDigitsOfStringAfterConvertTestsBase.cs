﻿// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.SumOfDigitsOfStringAfterConvert;

namespace LeetCode.Tests.Algorithms.SumOfDigitsOfStringAfterConvert;

public abstract class SumOfDigitsOfStringAfterConvertTestsBase<T> where T : ISumOfDigitsOfStringAfterConvert, new()
{
    [TestMethod]
    [DataRow("iiii", 1, 36)]
    [DataRow("zbax", 2, 8)]
    [DataRow("leetcode", 2, 6)]
    [DataRow("abcdefghijklmnopqrstuvwxyz", 5, 9)]
    [DataRow("asdfghlqwertyuiopzxcvbnmazqsxwdcefvrgbthnmyujkukl", 2, 7)]
    [DataRow("aucnewitainwctuancgacguagrycbfhsdbffhbfnvfhsrtsyfhyshfytufhsutgfghshejfhsjeghfjsehg", 2, 18)]
    [DataRow("ijsbiushfjhsbfhaxvgrgvrjbxhrgghgujdjdkjaaqiuiwueubcbcnzkozizoiwowekdkdjkddjdji", 2, 19)]
    [DataRow("sssssswwsssssrrrrrrrrrttttttttttttttttttttttttttttttttttttttttttttttrrrrrrrrrrrrrrrrrrssssssssssssss", 10,
        1)]
    [DataRow("ssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssss", 1,
        1000)]
    public void GetLucky_WithStringAndIterations_ReturnsTransformedSum(string s, int k, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.GetLucky(s, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}