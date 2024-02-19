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

using LeetCode.Algorithms.CountTheDigitsThatDivideNumber;

namespace LeetCode.Tests.Algorithms.CountTheDigitsThatDivideNumber;

public abstract class CountTheDigitsThatDivideNumberTestsBase<T> where T : ICountTheDigitsThatDivideNumber, new()
{
    [TestMethod]
    [DataRow(7, 1)]
    [DataRow(121, 2)]
    [DataRow(1248, 4)]
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