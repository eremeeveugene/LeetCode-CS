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

using LeetCode.Algorithms.SumOfSquareNumbers;

namespace LeetCode.Tests.Algorithms.SumOfSquareNumbers;

public abstract class SumOfSquareNumbersTestsBase<T> where T : ISumOfSquareNumbers, new()
{
    [TestMethod]
    [DataRow(0, true)]
    [DataRow(1, true)]
    [DataRow(2, true)]
    [DataRow(3, false)]
    [DataRow(4, true)]
    [DataRow(5, true)]
    [DataRow(6, false)]
    [DataRow(7, false)]
    [DataRow(8, true)]
    [DataRow(9, true)]
    [DataRow(2147483600, true)]
    [DataRow(10, true)]
    [DataRow(13, true)]
    [DataRow(15, false)]
    [DataRow(16, true)]
    [DataRow(25, true)]
    [DataRow(100, true)]
    [DataRow(999, false)]
    [DataRow(1000, true)]
    [DataRow(65536, true)]
    [DataRow(99999999, false)]
    [DataRow(1000000000, true)]
    [DataRow(2147483647, false)]
    [DataRow(2147483646, false)]
    [DataRow(2147395600, true)]
    [DataRow(2147483645, false)]
    public void JudgeSquareSum_GivenInput_ReturnsWhetherSumOfSquares(int c, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.JudgeSquareSum(c);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}