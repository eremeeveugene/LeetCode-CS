// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.CountGoodNumbers;

namespace LeetCode.Tests.Algorithms.CountGoodNumbers;

public abstract class CountGoodNumbersTestsBase<T> where T : ICountGoodNumbers, new()
{
    [TestMethod]
    [DataRow(1, 5)]
    [DataRow(2, 20)]
    [DataRow(3, 100)]
    [DataRow(4, 400)]
    [DataRow(5, 2000)]
    [DataRow(6, 8000)]
    [DataRow(7, 40000)]
    [DataRow(8, 160000)]
    [DataRow(50, 564908303)]
    public void CountGoodNumbers_WithInputLength_ReturnsTotalNumberOfGoodDigitStings(int n, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CountGoodNumbers(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}