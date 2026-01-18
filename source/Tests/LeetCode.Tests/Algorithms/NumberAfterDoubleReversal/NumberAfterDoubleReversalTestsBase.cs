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