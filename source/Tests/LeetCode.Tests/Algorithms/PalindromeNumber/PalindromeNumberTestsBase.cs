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

using LeetCode.Algorithms.PalindromeNumber;

namespace LeetCode.Tests.Algorithms.PalindromeNumber;

public abstract class PalindromeNumberTestsBase<T> where T : IPalindromeNumber, new()
{
    [TestMethod]
    [DataRow(121, true)]
    [DataRow(-121, false)]
    [DataRow(10, false)]
    [DataRow(0, true)]
    [DataRow(12321, true)]
    [DataRow(123321, true)]
    [DataRow(123456, false)]
    [DataRow(1234321, true)]
    [DataRow(12344321, true)]
    [DataRow(1001, true)]
    [DataRow(10001, true)]
    [DataRow(10010, false)]
    [DataRow(-101, false)]
    [DataRow(1, true)]
    [DataRow(9, true)]
    [DataRow(11, true)]
    [DataRow(22, true)]
    public void IsPalindrome_WithNumber_ChecksIfNumberIsPalindrome(int x, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.IsPalindrome(x);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}