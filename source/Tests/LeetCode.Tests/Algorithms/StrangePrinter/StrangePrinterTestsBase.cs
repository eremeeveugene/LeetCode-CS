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

using LeetCode.Algorithms.StrangePrinter;

namespace LeetCode.Tests.Algorithms.StrangePrinter;

public abstract class StrangePrinterTestsBase<T> where T : IStrangePrinter, new()
{
    [TestMethod]
    [DataRow("aaabbb", 2)]
    [DataRow("aba", 2)]
    public void StrangePrinter_GivenString_ReturnsMinimumPrints(string s, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.StrangePrinter(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}