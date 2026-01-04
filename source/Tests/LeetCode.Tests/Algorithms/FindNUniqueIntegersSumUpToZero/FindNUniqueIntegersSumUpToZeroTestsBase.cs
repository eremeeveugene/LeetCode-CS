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

using LeetCode.Algorithms.FindNUniqueIntegersSumUpToZero;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindNUniqueIntegersSumUpToZero;

public abstract class FindNUniqueIntegersSumUpToZeroTestsBase<T> where T : IFindNUniqueIntegersSumUpToZero, new()
{
    [TestMethod]
    [DataRow(1, "[0]")]
    [DataRow(2, "[-1,1]")]
    [DataRow(3, "[-1,0,1]")]
    [DataRow(4, "[-2,-1,1,2]")]
    [DataRow(5, "[-2,-1,0,1,2]")]
    public void SumZero_WithCountOfUniqueIntegers_ReturnsArraySummingToZero(int n, string expectedResultJson)
    {
        // Arrange
        var expectedResult = JsonHelper<int[]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.SumZero(n);

        // Assert
        CollectionAssert.AreEquivalent(expectedResult, actualResult);
    }
}