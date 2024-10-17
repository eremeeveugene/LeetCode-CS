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

using LeetCode.Algorithms.MaximumSwap;

namespace LeetCode.Tests.Algorithms.MaximumSwap;

public abstract class MaximumSwapTestsBase<T> where T : IMaximumSwap, new()
{
    [TestMethod]
    [DataRow(2736, 7236)]
    [DataRow(9973, 9973)]
    public void MaximumSwap_GivenNumber_ReturnsMaxPossibleSwap(int num, int expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.MaximumSwap(num);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}