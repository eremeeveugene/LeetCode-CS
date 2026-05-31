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

using LeetCode.Algorithms.UglyNumber;

namespace LeetCode.Tests.Algorithms.UglyNumber;

public abstract class UglyNumberTestsBase<T> where T : IUglyNumber, new()
{
    [TestMethod]
    [DataRow(1, true)]
    [DataRow(6, true)]
    [DataRow(14, false)]
    [DataRow(0, false)]
    [DataRow(-1, false)]
    [DataRow(-6, false)]
    [DataRow(2, true)]
    [DataRow(3, true)]
    [DataRow(4, true)]
    [DataRow(5, true)]
    [DataRow(8, true)]
    [DataRow(9, true)]
    [DataRow(10, true)]
    [DataRow(12, true)]
    [DataRow(15, true)]
    [DataRow(25, true)]
    [DataRow(30, true)]
    [DataRow(7, false)]
    [DataRow(11, false)]
    [DataRow(49, false)]
    public void IsUgly_WithPositiveInteger_ReturnsTrueIfOnlyPrimeFactorsAreTwoThreeOrFive(int n, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.IsUgly(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}