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

using LeetCode.Algorithms.NumberAfterDoubleReversal;

namespace LeetCode.Tests.Algorithms.NumberAfterDoubleReversal;

public abstract class NumberAfterDoubleReversalTestsBase<T> where T : INumberAfterDoubleReversal, new()
{
    [TestMethod]
    [DataRow(0, true)]
    [DataRow(526, true)]
    [DataRow(1800, false)]
    [DataRow(1, true)]
    [DataRow(9, true)]
    [DataRow(10, false)]
    [DataRow(100, false)]
    [DataRow(1000000, false)]
    [DataRow(999999, true)]
    [DataRow(123, true)]
    [DataRow(120, false)]
    [DataRow(12300, false)]
    [DataRow(101, true)]
    [DataRow(1001, true)]
    [DataRow(10001, true)]
    [DataRow(50, false)]
    [DataRow(505, true)]
    [DataRow(900000, false)]
    [DataRow(999990, false)]
    [DataRow(100001, true)]
    [DataRow(65432, true)]
    [DataRow(6540, false)]
    [DataRow(20, false)]
    public void IsSameAfterReversals_WithInputNum_ReturnsTrueIfFinalEqualsOriginal(int num, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.IsSameAfterReversals(num);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}