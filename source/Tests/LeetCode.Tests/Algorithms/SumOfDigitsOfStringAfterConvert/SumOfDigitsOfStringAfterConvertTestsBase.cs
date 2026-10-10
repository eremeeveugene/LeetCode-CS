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
    [DataRow("sssssswwsssssrrrrrrrrrttttttttttttttttttttttttttttttttttttttttttttttrrrrrrrrrrrrrrrrrrssssssssssssss", 10, 1)]
    [DataRow("ssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssss", 1, 1000)]
    [DataRow("a", 1, 1)]
    [DataRow("z", 1, 8)]
    [DataRow("z", 10, 8)]
    [DataRow("zz", 2, 7)]
    [DataRow("abc", 1, 6)]
    [DataRow("abc", 3, 6)]
    [DataRow("jjjjjjjjjj", 1, 10)]
    [DataRow("jjjjjjjjjj", 2, 1)]
    [DataRow("hello", 5, 7)]
    [DataRow("zyxwvutsrqponmlkjihgfedcba", 1, 135)]
    [DataRow("zyxwvutsrqponmlkjihgfedcba", 2, 9)]
    [DataRow("zyxwvutsrqponmlkjihgfedcba", 10, 9)]
    [DataRow("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", 1, 100)]
    [DataRow("zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz", 1, 800)]
    [DataRow("zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz", 4, 8)]
    [DataRow("qwertyuiop", 2, 7)]
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