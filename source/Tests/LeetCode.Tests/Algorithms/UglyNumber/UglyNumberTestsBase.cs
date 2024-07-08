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

using LeetCode.Algorithms.UglyNumber;

namespace LeetCode.Tests.Algorithms.UglyNumber;

public abstract class UglyNumberTestsBase<T> where T : IUglyNumber, new()
{
    [TestMethod]
    [DataRow(1, true)]
    [DataRow(6, true)]
    [DataRow(14, false)]
    public void IsUgly_WithVariousInputs_ReturnsExpectedResult(int n, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.IsUgly(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}