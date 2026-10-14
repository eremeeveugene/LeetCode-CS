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

using LeetCode.Algorithms.CountTheDigitsThatDivideNumber;

namespace LeetCode.Tests.Algorithms.CountTheDigitsThatDivideNumber;

public abstract class CountTheDigitsThatDivideNumberTestsBase<T> where T : ICountTheDigitsThatDivideNumber, new()
{
    [TestMethod]
    [DataRow(7, 1)]
    [DataRow(121, 2)]
    [DataRow(1248, 4)]
    [DataRow(1, 1)]
    [DataRow(5, 1)]
    [DataRow(9, 1)]
    [DataRow(11, 2)]
    [DataRow(12, 2)]
    [DataRow(15, 2)]
    [DataRow(22, 2)]
    [DataRow(36, 2)]
    [DataRow(24, 2)]
    [DataRow(48, 2)]
    [DataRow(111, 3)]
    [DataRow(128, 3)]
    [DataRow(999, 3)]
    [DataRow(735, 3)]
    [DataRow(99999999, 8)]
    [DataRow(123456789, 3)]
    [DataRow(999999999, 9)]
    [DataRow(2, 1)]
    public void CountDigits_GivenNumber_ReturnsNumberOfDigits(int n, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountDigits(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}