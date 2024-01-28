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

using LeetCode.Algorithms.ValidPalindrome;

namespace LeetCode.Tests.Algorithms.ValidPalindrome;

public abstract class ValidPalindromeTestsBase<T> where T : IValidPalindrome, new()
{
    [TestMethod]
    [DataRow("A man, a plan, a canal: Panama", true)]
    [DataRow("race a car", false)]
    [DataRow(" ", true)]
    [DataRow(".,", true)]
    [DataRow("0P", false)]
    public void IsPalindrome_WithStringInput_ReturnsBoolean(string s, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.IsPalindrome(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}