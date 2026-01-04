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

using LeetCode.Algorithms.CheckBalancedString;

namespace LeetCode.Tests.Algorithms.CheckBalancedString;

public abstract class CheckBalancedStringTestsBase<T> where T : ICheckBalancedString, new()
{
    [TestMethod]
    [DataRow("1234", false)]
    [DataRow("24123", true)]
    public void IsBalanced_WithInputNumberString_ReturnsIfNumberIsBalanced(string num, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.IsBalanced(num);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}