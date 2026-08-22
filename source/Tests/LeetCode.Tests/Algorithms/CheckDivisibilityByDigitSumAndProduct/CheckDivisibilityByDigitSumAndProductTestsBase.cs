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

using LeetCode.Algorithms.CheckDivisibilityByDigitSumAndProduct;

namespace LeetCode.Tests.Algorithms.CheckDivisibilityByDigitSumAndProduct;

public abstract class CheckDivisibilityByDigitSumAndProductTestsBase<T> where T : ICheckDivisibilityByDigitSumAndProduct, new()
{
    [TestMethod]
    [DataRow(1, false)]
    [DataRow(8, false)]
    [DataRow(9, false)]
    [DataRow(10, true)]
    [DataRow(11, false)]
    [DataRow(19, true)]
    [DataRow(20, true)]
    [DataRow(23, false)]
    [DataRow(29, true)]
    [DataRow(42, true)]
    [DataRow(49, true)]
    [DataRow(57, false)]
    [DataRow(99, true)]
    [DataRow(100, true)]
    [DataRow(101, false)]
    [DataRow(102, true)]
    [DataRow(108, true)]
    [DataRow(111, false)]
    [DataRow(120, true)]
    [DataRow(126, true)]
    [DataRow(132, true)]
    [DataRow(285, true)]
    [DataRow(999, false)]
    [DataRow(1_000, true)]
    [DataRow(1_001, false)]
    [DataRow(9_999, false)]
    [DataRow(10_000, true)]
    [DataRow(100_000, true)]
    [DataRow(999_999, false)]
    [DataRow(1_000_000, true)]
    public void CheckDivisibility_WithPositiveInteger_ReturnsTrueIfDivisible(int n, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.CheckDivisibility(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}