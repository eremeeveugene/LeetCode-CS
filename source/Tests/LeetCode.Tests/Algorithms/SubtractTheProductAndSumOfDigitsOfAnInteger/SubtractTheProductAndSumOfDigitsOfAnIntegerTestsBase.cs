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

using LeetCode.Algorithms.SubtractTheProductAndSumOfDigitsOfAnInteger;

namespace LeetCode.Tests.Algorithms.SubtractTheProductAndSumOfDigitsOfAnInteger;

public abstract class SubtractTheProductAndSumOfDigitsOfAnIntegerTestsBase<T> where T : ISubtractTheProductAndSumOfDigitsOfAnInteger, new()
{
    [TestMethod]
    [DataRow(234, 15)]
    [DataRow(4421, 21)]
    [DataRow(1, 0)]
    [DataRow(5, 0)]
    [DataRow(9, 0)]
    [DataRow(10, -1)]
    [DataRow(11, -1)]
    [DataRow(25, 3)]
    [DataRow(99, 63)]
    [DataRow(100, -1)]
    [DataRow(123, 0)]
    [DataRow(999, 702)]
    [DataRow(1000, -1)]
    [DataRow(1234, 14)]
    [DataRow(12345, 105)]
    [DataRow(55555, 3100)]
    [DataRow(56789, 15085)]
    [DataRow(90909, -27)]
    [DataRow(98765, 15085)]
    [DataRow(99999, 59004)]
    [DataRow(100000, -1)]
    public void SubtractProductAndSum_WithIntegerInput_ReturnsDifferenceBetweenDigitProductAndSum(int n, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SubtractProductAndSum(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}