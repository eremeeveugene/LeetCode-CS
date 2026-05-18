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

using LeetCode.Algorithms.CheckAdjacentDigitDifferences;

namespace LeetCode.Tests.Algorithms.CheckAdjacentDigitDifferences;

public abstract class CheckAdjacentDigitDifferencesTestsBase<T> where T : ICheckAdjacentDigitDifferences, new()
{
    [TestMethod]
    [DataRow("132", true)]
    [DataRow("129", false)]
    [DataRow("00", true)]
    [DataRow("99", true)]
    [DataRow("02", true)]
    [DataRow("20", true)]
    [DataRow("03", false)]
    [DataRow("30", false)]
    [DataRow("0123456789", true)]
    [DataRow("9876543210", true)]
    [DataRow("02468", true)]
    [DataRow("86420", true)]
    [DataRow("0369", false)]
    [DataRow("9630", false)]
    [DataRow("111111", true)]
    [DataRow("909", false)]
    [DataRow("121212", true)]
    [DataRow("123454321", true)]
    [DataRow("13579", true)]
    [DataRow("97531", true)]
    public void IsAdjacentDiffAtMostTwo_WithGivenDigitString_ReturnsTrueWhenAllAdjacentDifferencesWithinLimit(string num, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.IsAdjacentDiffAtMostTwo(num);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}