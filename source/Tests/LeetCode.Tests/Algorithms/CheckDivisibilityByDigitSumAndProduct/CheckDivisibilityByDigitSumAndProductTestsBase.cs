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
    [DataRow(8, false)]
    [DataRow(99, true)]
    [DataRow(23, false)]
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