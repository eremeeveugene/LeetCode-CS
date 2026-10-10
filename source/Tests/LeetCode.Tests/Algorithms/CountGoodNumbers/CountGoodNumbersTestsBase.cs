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
    [DataRow(9, 800000)]
    [DataRow(10, 3200000)]
    [DataRow(11, 16000000)]
    [DataRow(12, 64000000)]
    [DataRow(13, 320000000)]
    [DataRow(16, 599999825)]
    [DataRow(20, 999928327)]
    [DataRow(100, 564490093)]
    [DataRow(1000, 36020987)]
    [DataRow(123456, 182747849)]
    [DataRow(1000000, 171395901)]
    [DataRow(2000000000, 767857146)]
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