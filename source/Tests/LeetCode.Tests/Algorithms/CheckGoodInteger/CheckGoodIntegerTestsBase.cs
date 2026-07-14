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

using LeetCode.Algorithms.CheckGoodInteger;

namespace LeetCode.Tests.Algorithms.CheckGoodInteger;

public abstract class CheckGoodIntegerTestsBase<T> where T : ICheckGoodInteger, new()
{
    [TestMethod]
    [DataRow(1000, false)]
    [DataRow(19, true)]
    [DataRow(1, false)]
    [DataRow(9, true)]
    [DataRow(7, false)]
    [DataRow(8, true)]
    [DataRow(10, false)]
    [DataRow(12, false)]
    [DataRow(17, false)]
    [DataRow(18, true)]
    [DataRow(28, true)]
    [DataRow(44, false)]
    [DataRow(46, false)]
    [DataRow(47, true)]
    [DataRow(48, true)]
    [DataRow(50, false)]
    [DataRow(55, false)]
    [DataRow(66, true)]
    [DataRow(77, true)]
    [DataRow(88, true)]
    [DataRow(98, true)]
    [DataRow(99, true)]
    [DataRow(123456789, true)]
    [DataRow(999999999, true)]
    [DataRow(1000000000, false)]
    public void IsGood_WithPositiveInteger_ReturnsWhetherIntegerIsGood(int n, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.IsGood(n);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}