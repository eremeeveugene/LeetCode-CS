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

using LeetCode.Algorithms.CheckIfDigitsAreEqualInStringAfterOperations1;

namespace LeetCode.Tests.Algorithms.CheckIfDigitsAreEqualInStringAfterOperations1;

public abstract class CheckIfDigitsAreEqualInStringAfterOperations1TestsBase<T> where T : ICheckIfDigitsAreEqualInStringAfterOperations1, new()
{
    [TestMethod]
    [DataRow("323", true)]
    [DataRow("3902", true)]
    [DataRow("34789", false)]
    [DataRow("000", true)]
    [DataRow("111", true)]
    [DataRow("123", false)]
    [DataRow("100", false)]
    [DataRow("999", true)]
    [DataRow("555", true)]
    [DataRow("0000", true)]
    [DataRow("1234", false)]
    [DataRow("1111", true)]
    [DataRow("9876", false)]
    [DataRow("5555", true)]
    [DataRow("1000", false)]
    [DataRow("12345", false)]
    [DataRow("00000", true)]
    [DataRow("11111", true)]
    [DataRow("10101", true)]
    [DataRow("13579", false)]
    public void HasSameDigits_WithStringInput_ReturnsWhetherAllDigitsAreTheSame(string s, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.HasSameDigits(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}