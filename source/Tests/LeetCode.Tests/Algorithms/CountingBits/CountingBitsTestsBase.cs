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

using LeetCode.Algorithms.CountingBits;

namespace LeetCode.Tests.Algorithms.CountingBits;

public abstract class CountingBitsTestsBase
{
    [TestMethod]
    [DataRow(2, new[] { 0, 1, 1 })]
    [DataRow(5, new[] { 0, 1, 1, 2, 1, 2 })]
    public void CountBits_WithNumber_ReturnsBitCountsUpToN(int n, int[] expectedResult)
    {
        // Arrange
        var solution = GetSolution();

        // Act
        var actualResult = solution.CountBits(n);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    protected abstract ICountingBits GetSolution();
}