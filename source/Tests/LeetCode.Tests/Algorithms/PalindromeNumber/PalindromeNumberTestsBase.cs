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